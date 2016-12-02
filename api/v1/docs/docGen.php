<?

include "config.php";
include "../constants.php";

class DocumentationGenerator
{
    var $config;
    
    public function __construct()
    {
        $this->LoadConfig();
    }
    
    function LoadConfig()
    {
        $this->config = DocConfigArray();
    }
    
    function GetMainMenu()
    {
        $items = "";
        
        foreach($this->config as $page => $data)
        {
            $items .= "<li><a href=\"?page=$page\">".$data["name"]."</a></li>";
        }
        
        $text = '<h3>API Requests:</h3><ul class="main_menu">'.$items.'</ul>';
        
        return $text;
    }
    
    function GetPage($page)
    {
        $content = $this->GetPageContent($page);
        
        $menu = $this->GetMainMenu();
        
        $text = '<!DOCTYPE html>
<html>
    <head>
        <link href="style.css" type="text/css" rel="stylesheet"/>
        
        <script type="text/javascript" src="jquery-1.11.2.js"></script>
        <script type="text/javascript" src="script.js"></script>
    </head>
    <body>
        <div id="leftcol">'.$menu.'</div>
        <div id="rightcol">'.$content.'</div>
    </body>
</html>';

        return $text;
    }
    
    function GetMainPageContent()
    {
        $text = $this->GetNameText("Overview");
        
        return $text;
    }
    
    function GetPageContent($page)
    {
        if($page == "main")
            return $this->GetMainPageContent();
        
        $text = "";
        
        if(!isset($this->config[$page]))
            return $text;
            
        $config = $this->config[$page];
            
        if(isset($config["name"]))
        {
            $text .= $this->GetNameText($config["name"]);
        }
        
        if(isset($config["properties"]))
        {
            $text .= $this->StartProperties();
            
            foreach($config["properties"] as $name => $data)
            {
                $text .= $this->GetProperty($name, $data["value"], $data["type"], $data["descr"]);
            }
            
            $text .= $this->EndProperties();
        }
        
        if(isset($config["request"]))
        {
            $text .= $this->GetRequestText($config["request"]);
        }
        
        if(isset($config["request_post"]))
        {
            $text .= $this->GetRequestPostText($config["request_post"]);
        }
        
        if(isset($config["response"]))
        {
            $text .= $this->GetResponseText($config["response"]);
        }
        
        if(isset($config["errors"]))
        {
            $text .= $this->StartErrors();
            
            //foreach($config["errors"] as $code => $descr)
            foreach($config["errors"] as $errorName => $errorData)
            {
                $code       = $errorData["code"];
                $statusCode = $errorData["status_code"];
                $descr      = $errorData["message"];
                
                $text .= $this->GetError($code, $statusCode, $descr);
            }
            
            $text .= $this->EndErrors();
        }
        
        return $text;
    }
    
    function GetNameText($name)
    {
        $text = "<h2>$name</h2>";
        
        return $text;
    }

    function StartProperties()
    {
        $text = "<h3>Properties:</h3><div class=\"wrap\"><table class=\"properties-table\">";
        
        return $text;
    }
    
    function GetProperty($name, $value, $type, $description)
    {
        $text = "<tr class=\"row\"><td class=\"name\"><b>$name</b><br />$value</td><td class=\"description\"><b>$type</b><br />$description</td></tr>";
        
        return $text;
    }
    
    function EndProperties()
    {
        $text = "</table></div>";
        
        return $text;
    }
    
    function StartErrors()
    {
        $text = "<h3>Error code and description:</h3><div class=\"wrap\"><table class=\"properties-table\">";
        
        return $text;
    }
    
    function GetError($code, $statusCode, $descr)
    {
        $text = "<tr class=\"row error\"><td class=\"name\"><b>$code</b></td><td class=\"scode\"><b>$statusCode</b></td><td class=\"description\">$descr</td></tr>";
        
        return $text;
    }
    
    function EndErrors()
    {
        $text = "</table></div>";
        
        return $text;
    }

    function GetRequestText($arr)
    {
        $text = "<h3>Request example:<br />HTTP GET</h3>";
        
        $req = '<span class="url">' . API_URL . $arr["link"] . '</span>';
        
        $params = array();
        
        foreach($arr["params"] as $name => $val)
        {
            $params[] = "<span class=\"url_param\">$name</span><span class=\"url_eq\">=</span><span class=\"url_value\">$val</span>";
        }
        
        $req .= '<span class="url_sep">?</span>'.join('<span class="url_amp">&</span>', $params);
        
        $text .=  "<div class=\"request\"><code>$req</code></div>";
        
        return $text;
    }

    function GetRequestPostText($arr)
    {
        $text = "<h3>Request example:<br />HTTP POST</h3>";
        
        $req = '<span class="url">' . API_URL . $arr["link"] . '</span>';
        
        $text .=  "<div class=\"request\"><code>$req</code></div>";
        
        $text .= "<pre><code class=\"json\">".$arr["params"]."</code></pre>";
        
        if(isset($arr["test_file"]))
        {
            $test_file = $arr["test_file"];
            $text .= "<div class=\"request\"><a href=\"/".API_VERSION."/docs/test/$test_file\" target=\"_blank\">TRY TEST REQUEST</a></div>";
        }
        
        return $text;
    }
    
    function GetResponseText($json)
    {
        $text = "<h3>Response example (json):</h3>";
        
        $text .= "<pre><code class=\"json\">$json</code></pre>";
        
        return $text;
    }

    
}

?>