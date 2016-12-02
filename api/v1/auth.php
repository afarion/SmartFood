<?

define("LOG_REQUESTS",      true);

class Auth
{
    private $config;
    private $db;
    
    public function __construct()
    {
        $this->LoadConfig();
        
        $this->DbConnect();
    }
    
    public function Close()
    {
        $this->DbClose();
    }
    
    private function LoadConfig()
    {
        $this->config = GetAuthConfigArray();
    }
    
    private function ConvertRequest($json)
    {
        $data = json_decode($json, true);
        
        return $data;
    }
	
	public function GetParams($method, $type)
	{
		$data = array();
		
		if(!isset($this->config[$method]))
			return $data;
		
        $config = $this->config[$method];
        
		foreach($config["params"] as $item => $itemData)
		{
        	if(strtolower($type) == "post" && isset($_POST[$item]))
				$data[$item] = $_POST[$item];
			else if(strtolower($type) == "get" && isset($_GET[$item]))
				$data[$item] = $_GET[$item];
		}
		
		return $data;
	}
	    
    public function LogIn($params)
    {
        $config     = $this->config["login"];
        
        $data = array();
        
        $resultData = array();
        
        foreach($config["params"] as $item => $itemData)
        {
            $field  = $itemData["field"];
            $type   = $itemData["type"];
            
            if(!isset($params[$item]))
                $this->ShowError("required");
            
            $value = $params[$item];
            
            $regValid = $this->CheckRegexp($type, $value);
            
            if(!$regValid)
                $this->ShowError($type);
                
            if($type == "pass")
                $value = md5($value);
            
            $data[$field] = $value;
        }
        
        if(count($data) <= 0)
            $this->ShowError("login");
        
        $userData = $this->GetUserData($data);
        
        if(!isset($userData["id"]) || $userData["id"] <= 0)
            $this->ShowError("login");
            
        $userId = $userData["id"];
            
        $sid = $this->GenerateHash($userData);
        
        $sidData = array( "sid" => $sid );
            
        $this->UpdateUser($userId, $sidData);
        
        $userData["sid"] = $sid;
        
        $this->ShowJson($userData);
    }
    
    function GetUrlContent($url)
    {
        $ch = curl_init($url);  
        
        
        curl_setopt($ch, CURLOPT_URL, $url);  
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, 1);
        //curl_setopt($ch, CURLOPT_PROTOCOLS, CURLPROTO_HTTPS);
        curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, false);
        
        $result = curl_exec($ch);
        
        //$info = curl_getinfo($ch);
        
        //print_r($info);
        
        curl_close($ch);
        
        return $result;
    }
    
    private function GenerateHash($data, $addData = "")
    {
        $text = join("", $data);
        
        $hash = sha1($text . $addData . time());
        
        return $hash;
    }
	
	private function CheckRegexp($type, $value)
	{
		$regulars 	= $this->config["settings"]["regulars"];
		
		if(!isset($regulars[$type]))
			return true;
		
		if(!preg_match($regulars[$type], $value))
            return false;
        
		return true;
	}
	    
    private function UpdateUser($id, $data)
    {
        $id = intval($id);
        
        $table  = $this->config["table"];
        
        $values = array();
        
        foreach($data as $f => $v)
            $values[] = "$f = '".$this->MySqlScreening($v)."'";
        
        $query = "UPDATE $table SET ".join(',', $values)." WHERE id = $id";
        
        $this->ExecuteNonQuery($query);
    }
    
    private function GetUserData($data)
    {
        $table = $this->config["table"];
        
        $responseUserFields = $this->config["response_user_fields"];
        
        $fields = array();
        
        foreach($responseUserFields as $name => $fieldData)
        {
            if(isset($fieldData["field"]))
                $fields[] = $fieldData["field"] . ' as ' . $name;
        }
        
        $where = array();
        
        foreach($data as $f => $v)
        {
            $where[] = $f . " = '".$this->MySqlScreening($v)."'";
        }
        
        $query = "SELECT ".join(",", $fields)." FROM $table WHERE ".join(' AND ', $where)." LIMIT 1";
        
        $userData = $this->GetValuesByQuery($query);
        
        return $userData;
    }
    
    private function LastInsertedId()
    {
        return mysql_insert_id();
    }
    
    private function LogRequest($data)
    {
        $key = session_id();
        
        $date = date("Y-m-d");
        
        $dir = dirname(__FILE__)."/logs/".$date;
        
        if(!file_exists($dir))
            mkdir($dir);
            
        $dir .= "/".$key;
        
        if(!file_exists($dir))
            mkdir($dir);
            
        $fileName = $_SERVER["REQUEST_URI"];
        $fileNameArr = explode("?", $fileName);
        $fileName = $fileNameArr[0];
        $fileName = str_replace("/", "_", $fileName);
        $fileName = trim($fileName, "_");
        $fileName .= "_".date("H-i-s")."_".rand(1111, 9999).".txt";
        
        $f = fopen($dir."/".$fileName, "w");
        
        @fwrite($f, "REQUEST:\n");
        @fwrite($f, $_SERVER["REQUEST_URI"]."\n\n");
        @fwrite($f, "==========\nGET:\n");
        @fwrite($f, print_r($_GET, true)."\n");
        @fwrite($f, "==========\nPOST:\n");
        @fwrite($f, print_r($_POST, true)."\n");
        @fwrite($f, "==========\nRESPONSE:\n");
        @fwrite($f, print_r($data, true)."\n");
        
        @fclose($f);
    }
    
    private function GetStatusHeader($code)
    {
        $header = "";
        
        $sapi_name = php_sapi_name();
        if ($sapi_name == 'cgi' OR $sapi_name == 'cgi-fcgi') 
            $header = "Status: ";
        else
            $header = "HTTP/1.1 ";
        
        switch($code)
        {
            case 200:   $header .= "200 OK";            break;
            case 400:   $header .= "400 Bad Request";   break;
            case 401:   $header .= "401 Unauthorized";  break;
            case 403:   $header .= "403 Forbidden";     break;
            case 404:   $header .= "404 Not Found";     break;
            case 500:   $header .= "500 Internal Server Error";     break;
            default:    $header .= "500 Internal Server Error";     break;
        }
        
        return $header;
    }
    
    private function ShowJson($data, $statusCode = "200")
    {
        if(LOG_REQUESTS)
            $this->LogRequest($data);
        
        $json = json_encode($data);

        $statusHeader = $this->GetStatusHeader($statusCode);
        
        header($statusHeader);
        header('Content-Type: application/json; charset=utf-8');
        echo $json;
    }
    
    function MySqlScreening($text)
    {
        $text = str_replace("\\", "\\\\", $text);
        $text = str_replace("'", "\\'", $text);
        
        return $text;
    }

    function ShowError($key)
    {
        $errors = $this->config["errors"];
        
        if(!isset($errors[$key]))
            $key = "undefined";
        
        $statusCode = $errors[$key]["status_code"];
        
        $error = array("code" => $errors[$key]["code"], "message" => $errors[$key]["message"]);
        
        $this->ShowJson($error, $statusCode);
        
        exit;
    }
    
    function GetRowsByQuery($query)
    {
        $rows = array();
        
        $this->db->sql_query($query);
        while($row = $this->db->sql_fetchrow())
        {
            $rows[] = $row;
        }
        $this->db->sql_freeresult();
        
        return $rows;
    }
    
    protected function GetValueByQuery($query)
    {
        $this->db->sql_query($query);
        
        $row = $this->db->sql_fetchrow();
        
        $value = "";
        if($this->db->sql_numrows() > 0)
            $value = $row["id"];
        
        $this->db->sql_freeresult();

        return $value;
    }
    
    protected function GetValueByWhere($field, $table, $where = "1")
    {
        $query = "select $field as id from $table where $where limit 1";

        return $this->GetValueByQuery($query);
    }
    
    protected function GetValue($field, $table, $id)
    {
        $query = "select $field as id from $table where id='$id' limit 1";
        
        return $this->GetValueByQuery($query);
    }
    
    protected function GetValuesByQuery($query)
    {
        $row = array();
        
        $this->db->sql_query($query);
        
        if($this->db->sql_numrows() > 0)
            $row = $this->db->sql_fetchrow();
        
        $this->db->sql_freeresult();
        
        return $row;
    }
    
    protected function GetValuesByWhere($fields, $table, $where = "1")
    {
        $query = "select $fields from $table where $where limit 1";

        return $this->GetValuesByQuery($query);
    }

    protected function GetValues($fields, $table, $id)
    {
        $query = "select $fields from $table where id='$id' limit 1";

        return $this->GetValuesByQuery($query);
    }

    function ExecuteNonQuery($query)
    {
        $this->db->sql_query($query);
        $this->db->sql_freeresult();
    }

    function DbConnect()
    {
        $this->db = new sql_db(sql_server, sql_user, sql_password, sql_database, false);
        if(!$this->db->db_connect_id)
            $this->MessageDie(CRITICAL_ERROR, "Could not connect to the database","Critical Error",__LINE__,__FILE__);
    }

    function DbClose()
    {
        $this->db->sql_close();
    }

    function MessageDie($msg_code, $msg_text = '', $msg_title = '', $err_line = '', $err_file = '', $sql = '')
    {
        echo "<h3 align=center>$msg_title</h3><br>
              <h4 align=center>$msg_text</h4><br>
              <h4 align=center>$err_file : $err_line</h4><br>";
        exit;
    }
}

?>