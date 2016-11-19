<?

include("mail_sender/mail_sender.php");

define("DEF_PER_PAGE",      30);
define("MAX_PER_PAGE",      50);

define("LOG_REQUESTS",      true);

define("AUTH_TABLE",        "tadmin");

class SmartFoodApi
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
        $this->config = GetConfigArray();
    }
    
    private function ConvertRequest($json)
    {
        $data = json_decode($json, true);
        
        return $data;
    }
    
    private function CheckUserAccessData($request)
    {
        if(!isset($request["user_id"]) || !isset($request["user_type"]) || !isset($request["user_sid"]))
            $this->ShowError("user");
        
        $userId = intval($request["user_id"]);
        $userType = intval($request["user_type"]);
        $sid = $this->MySqlScreening($request["user_sid"]);
        
        if($userId <= 0 || $userType <= 0 || $sid == "")
            $this->ShowError("user");
            
        $userId = $this->GetValueByQuery("SELECT id FROM ".AUTH_TABLE." WHERE id='$userId' AND id_type='$userType' AND sid='$sid' LIMIT 1", "id");
        $userId = intval($userId);
        
        if($userId <= 0)
            $this->ShowError("sid");
            
        return $userType;
    }
    
    public function AnalyzeRequest($request)
    {
        //Conver json string to array
        //$request = $this->ConvertRequest($requestJson);
        
        //Check user data and sid
        $userType = $this->CheckUserAccessData($request);
        
        if(!isset($request["method"]))
        {
            //No method in request
            $this->ShowError("request");
        }

        $method = $request["method"];

        if(!isset($this->config[$method]))
        {
            //Unknown method (not exist in config file)
            $this->ShowError("method");
        }
        
        //Analyse action
        if(!isset($request["action"]))
        {
            $this->ShowError("action");
        }
        
        $action = $request["action"];
        
        switch($action)
        {
            case "view":
            {
                //Check user permissions
                if(isset($this->config[$method]["permission"]))
                {
                    if(!isset($this->config[$method]["permission"][$userType]) 
                    || !isset($this->config[$method]["permission"][$userType][0])
                    || !$this->config[$method]["permission"][$userType][0])
                        $this->ShowError("perm"); 
                }
                
                $response = $this->GetResponseData($method, $request);
                
                //Single object in response
                if($response["type"] == "single")
                    $this->ShowResponseSingle($response["data"]);
                //List of objects in response
                else if($response["type"] == "list")
                    $this->ShowResponseList($response["data"]);
                //Error in response generating
                else
                    $this->ShowError("resp");
                
                break;
            }
            case "edit":
            {
                break;
            }
            case "add":
            {
                break;
            }
            case "remove":
            {
                break;
            }
            default:
            {
                $this->ShowError("action");
                break;
            }
        }
        
        
    }
    
    public function GetResponseData($method, $request, $relKey = "", $relIds = "")
    {
        //Array of all objects id in response 
        $respIds = array();
        
        if(!isset($this->config[$method]))
        {
            //Unknown method (not exist in config file)
            $this->ShowError("method");
        }

        $methodConfig = $this->config[$method];

        $table = $methodConfig["table"];
        
        if(isset($methodConfig["auth"]))
        {
            foreach($methodConfig["auth"] as $name => $item)
            {
                if($item["required"] && !isset($request[$name]))
                    $this->ShowError("user");
            }
            
            $userData = $this->GetUserData($request);
        }
        
        $distinct = "";

        //Generate array of patr in request
        $part = array();
        
        if(isset($request["part"]))
        {
            $partArr = explode(",", $request["part"]);
            
            foreach($partArr as $item)
                $part[trim($item)] = 1;
        }

        $fields = array();
        
        $join = array();

        //Generate array of fields to select and generate array tables to join
        foreach($methodConfig["part"] as $key => $data)
        {
            if($data["required"] || isset($part[$key]))
            {
                $field = $data["field"];
                
                if($data["type"] == "table")
                {
                    $joinData = $data["join"];
                    
                    $jTable = $joinData[0];
                    $jField = $joinData[1];
                    $jKey   = $joinData[2];
                    
                    $join[$jTable] = " LEFT JOIN $jTable ON $jTable.$jKey = $table.$field";
                    
                    $fields[] = "$jTable.$jField as $key";
                }
                else if($data["type"] == "price")
                {
                    $fields[] = "CAST($table.$field * 100 AS UNSIGNED) as $key";
                }
                else if($data["type"] == "concat")
                {
                    $fields[] = "$field as $key";
                }
                else
                {
                    $fields[] = "$table.$field as $key";
                }
            }
        }
        
        //Flag shown if this responce data is child (related of parent data, subrequest)
        $isRel = false;
        if($relKey != "")
            $isRel = true;
        
        if($isRel)
            $fields[] = "$table.$relKey as rel_key";
        
        //flags of visible elements
        $showOnly = "";
        if(isset($methodConfig["show_only"]))
        {
            foreach($methodConfig["show_only"] as $item)
            {
                $showOnly .= " AND $table.$item";
            }
        }
        
        $response = array();
        
        $isSingle = false;
        
        //Single object request
        if(isset($request["id"]))
        {
            $isSingle = true;
            
            $where = "";
            
            //If related request, add to query relation field
            if($relKey != "")
            {
                if($relIds == "")
                    $relIds = 0;
                    
                $where = " AND $table.$relKey IN ($relIds)";
            }
            
            //Compose query string
            $query = "SELECT ".join(",", $fields)." FROM ".$table.join(" ", $join)." WHERE ".$table.".id = ".intval($request["id"]).$where.$showOnly;
            
            $rows = $this->GetRowsByQuery($query);
            
            $singleData = array();
            
            if(count($rows) > 0)
            {
                //If we have query result, get first row and remove from response relation field 
                $singleData = $rows[0];
                if(isset($singleData["rel_key"]))
                    unset($singleData["rel_key"]);
            } 
            
            //Fill array of all objects id
            $respIds[] = $request["id"];
            
            //Compose response
            $response = array("type" => "single", "data" => $singleData);
        }
        //List of objects request
        else
        {
            $where = "1";
            
            //Generate where string for query
            if(isset($request["filters"]) && is_array($request["filters"]))
            {
                foreach($request["filters"] as $key => $val)
                {
                    if(!isset($methodConfig["filters"][$key]))
                        continue;
                        
                    $filterData = $methodConfig["filters"][$key];
                    
                    if(isset($filterData["related"]))
                    {
                        $relData = $filterData["related"];
                        
                        $relTable = $relData[0];
                        $relField = $relData[1];
                        $relKey   = $relData[2];
                        
                        $relWhere = $this->GetFilterWhere($filterData["field"], $filterData["type"], $val, $relTable);
                        
                        if(isset($relData[3]))
                            $relWhere .= $relData[3];
                        
                        $relQuery = "SELECT $relField as id FROM $relTable WHERE 1 $relWhere";
                        
                        $relRows = $this->GetRowsByQuery($relQuery);
                        
                        $relIds = array();
                        foreach($relRows as $relItem)
                        {
                            $relIds[$relItem["id"]] = $relItem["id"];
                        }
                        
                        $relStr = "0";
                        if(count($relIds) > 0)
                            $relStr = join(",", $relIds);
                        
                        $where .= $this->GetFilterWhere("id", "in_array", $relStr, $table);
                    }
                    else
                    {
                        $where .= $this->GetFilterWhere($filterData["field"], $filterData["type"], $val, $table);
                    }
                }
            }
            
            //If related request, add to query relation field
            if($isRel)
            {
                if($relIds == "")
                    $relIds = 0;
                    
                $where .= " AND $table.$relKey IN ($relIds)";
            }
            
            $where .= $showOnly;
            
            //Generate order by string for query
            $orderBy = "";

            if(isset($request["order"]))
            {
                $orderVal = $request["order"];
                
                if(isset($methodConfig["order"]) && isset($methodConfig["order"][$orderVal]))
                {
                    if(is_array($methodConfig["order"][$orderVal]))
                    {
                        $paramOrderBy       = $methodConfig["order"][$orderVal]["by"];
                        $paramOrderTable    = $methodConfig["order"][$orderVal]["table"];
                        
                        if(isset($methodConfig["order"][$orderVal]["distinct"]) && $methodConfig["order"][$orderVal]["distinct"] == true)
                            $distinct = " distinct ";
                        
                        if(isset($methodConfig["order"][$orderVal]["where"]))
                            $where .= $methodConfig["order"][$orderVal]["where"];
                        
                        if(isset($methodConfig["order"][$orderVal]["join"]))
                            $join[$paramOrderTable] = $methodConfig["order"][$orderVal]["join"];
                        
                        $orderBy = " ORDER BY ".$paramOrderBy;
                    }
                    else
                    {
                        $orderBy = " ORDER BY ".$methodConfig["order"][$orderVal];
                    }
                }
            }
            
            //Generate limit string for query
            $count = DEF_PER_PAGE;
            
            //Count per page
            if(isset($request["count"]))
                $count = intval($request["count"]);
                
            if($count <= 0 || $count > MAX_PER_PAGE)
                $this->ShowError("count");
            
            //Get items from offset position
            $offset = 0;
            if(isset($request["offset"]))
            {
                //Offset in request
                $offset = intval($request["offset"]);
                if($offset < 0)
                    $this->ShowError("offset");
            }
            else if(isset($request["page"]))
            {
                //Page in request, convert to offset
                $page = intval($request["page"]);
                if($page < 0)
                    $this->ShowError("page");
                    
                $offset = $page * $count;
            }
            
            $limit = " LIMIT $count";
            if($offset > 0)
                $limit = " LIMIT $offset, $count";
            
            //Compose query string
            $query = "SELECT $distinct ".join(",", $fields)." FROM ".$table.join(" ", $join)." WHERE ".$where.$orderBy.$limit;
            
            $rows = $this->GetRowsByQuery($query);
            
            //If it is not related request
            if(!$isRel)
            {
                //Fill array of all objects id
                foreach($rows as $row)
                    $respIds[] = $row["id"];
                
                //Compose response
                $response = array("type" => "list", "data" => $rows);
            }
            //Else if related request
            else
            {
                //Generate response array, [relation key] => array of response items
                $listData = array();
                
                foreach($rows as $row)
                {
                    $rel = $row["rel_key"];
                    
                    if(!isset($listData[$rel]))
                        $listData[$rel] = array();
                    
                    //Remove from response relation field 
                    $itemData = $row;
                    unset($itemData["rel_key"]);
                    
                    //data [relation key] => array of response items
                    $listData[$rel][] = $itemData;
                    
                    //Fill array of all objects id
                    $respIds[] = $row["id"];
                }
                
                //Compose response
                $response = array("type" => "rel_list", "data" => $listData);
            }
        }
        
        //If configuration of this method has child relations
        if(isset($methodConfig["relations"]))
        {
            //Check all child relations
            foreach($methodConfig["relations"] as $relName => $relData)
            {
                //Ignore, if relation is not exists in request
                if(!isset($request[$relName]))
                    continue;
                
                //Get response data for child relation
                $relResponse = $this->GetResponseData($relData["method"], $request[$relName], $relData["key"], join(",", $respIds));
                
                //Current response is single object data
                if($isSingle)
                {
                    //Add to current response child relation response
                    $responseId = $response["data"]["id"];
                    
                    if(isset($relResponse["data"][$responseId]))
                        $response["data"][$relName] = $relResponse["data"][$responseId];
                }
                
                //Child relation response is list with relation ( [relation key] => array of response items )
                //And current response is root (not related child)
                else if($relResponse["type"] == "rel_list" && !$isRel)
                {
                    $newData = array();
                    
                    foreach($response["data"] as $respItem)
                    {
                        //Add subresponse items to each of current response item
                        $itemId = $respItem["id"];
                        
                        if(isset($relResponse["data"][$itemId]))
                            $respItem[$relName] = $relResponse["data"][$itemId];
                        
                        $newData[] = $respItem;
                    }
                    
                    $response["data"] = $newData;
                }
                //Child relation response is list with relation ( [relation key] => array of response items )
                //And current response is child (subresponse)
                else if($relResponse["type"] == "rel_list" && $isRel)
                {
                    $newData = array();
                    
                    //For each response item ( [relation key] => array of response items )
                    foreach($response["data"] as $respItemId => $respItem)
                    {
                        $newData[$respItemId] = array();
                        
                        foreach($respItem as $item)
                        {
                            //Add subresponse items to each of current response item
                            $itemId = $item["id"];
                            
                            if(isset($relResponse["data"][$itemId]))
                                $item[$relName] = $relResponse["data"][$itemId];
                            
                            $newData[$respItemId][] = $item;
                        }
                    }
                    
                    $response["data"] = $newData;
                }
            }
        }
        
        return $response;
    }
    
    public function AnalyseAction($action, $params)
    {
        if(!isset($this->config[$action]))
        {
            //Unknown method (not exist in config file)
            $this->ShowError("method");
        }

        $actionConfig = $this->config[$action];
        
        foreach($actionConfig["part"] as $name => $item)
        {
            if($item["required"] && !isset($params[$name]))
                $this->ShowError("request");
        }
        
        /*
        switch($action)
        {
            case "booking_price":
            {
                $bookingData = $this->CalculateBookingPrice($params);
                $this->ShowBookingPrice($bookingData);
                break;
            }
            case "booking_order":
            {
                $userData       = $this->GetUserData($params);
                $bookingData    = $this->CalculateBookingPrice($params);
                $orderData      = $this->MakeOrder($params, $userData, $bookingData);
                
                $this->ShowJson($orderData);
                break;
            }
        }
        */
    }
    
    private function CurlPost($url, $accessSecret, $key, $data)
    {
        $ch = curl_init($url);  

        curl_setopt($ch, CURLOPT_SSL_VERIFYPEER, false);
        curl_setopt($ch, CURLOPT_USERPWD, "$key:$accessSecret");
        curl_setopt($ch, CURLOPT_CUSTOMREQUEST, "POST");                                                                     
        curl_setopt($ch, CURLOPT_POSTFIELDS, $data);                                                                  
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);                                                                      
        curl_setopt($ch, CURLOPT_HTTPHEADER, array(                                                                          
            'Content-Type: application/json',                                                                                
            'Content-Length: ' . strlen($data))                                                                       
        );

        $result = curl_exec($ch);
        
        //$info = curl_getinfo($ch);
        //$error = curl_error($ch);

        //print_r($info);
        //print_r($error);

        curl_close($ch);
        
        return $result;
    }
    
    private function MakeOrder($params, $userData, $bookingData)
    {
        /*
        $userNotes = isset($params["user_notes"]) ? $params["user_notes"] : "";
        
        $idManager = intval($bookingData["deal"]["id_manager"]);
        $managerName = $this->GetIdByQuery("SELECT name as id FROM tadmin WHERE id = $idManager");
        
        $id_hotel       = intval($params["hotel"]);
        $id_roomdeal    = intval($params["deal"]);
        $id_user        = intval($params["user_id"]);
        $id_manager     = $idManager;
        $id_status      = 1;
        $id_duration    = intval($bookingData["deal"]["id_duration"]);
        $id_checkout    = intval($bookingData["deal"]["id_checkout"]);
        $user_name      = $this->MySqlScreening($userData["name"]);
        $manager_name   = $this->MySqlScreening($managerName);
        $room_name      = $this->MySqlScreening($bookingData["deal"]["name"]);
        $user_phone     = $this->MySqlScreening($userData["phone"]);
        $user_email     = $this->MySqlScreening($userData["email"]);
        $price          = $this->MySqlScreening($bookingData["deal"]["price"]);
        $tonight_price  = $this->MySqlScreening($bookingData["deal"]["tonight_price"]);
        $tax            = $bookingData["tax"];
        $tax_price      = $bookingData["tax_price"] / 100;
        $subtotal_price = $bookingData["subtotal_price"] / 100;
        $total_price    = $bookingData["total_price"] / 100;
        $notes_user     = $this->MySqlScreening($userNotes);
        $visible        = 1;
        
        // Check deal
        $dealId = $this->GetValueByQuery("SELECT id FROM troomdeal WHERE id='$id_roomdeal' and visible > 0 and date_finish > NOW()", "id");
        
        if($dealId <= 0)
            $this->ShowError(ERROR_CODE_REQUEST, ERROR_TEXT_REQUEST);
        
        // Check total price
        $totalPriceCalc = $bookingData["total_price"];
        $totalPriceIn   = isset($params["total_price"]) ? $params["total_price"] : 0;
        
        if(intval($totalPriceCalc) != intval($totalPriceIn))
        {
            $this->ShowError(ERROR_CODE_PRICE, ERROR_TEXT_PRICE);
        }
        
        // Payment token and other from POST (and save to DB if retain = true) or get from DB
        $payment_method_token   = isset($params["payment_method_token"]) ? $params["payment_method_token"] : "";
        $last_4_numbers         = isset($params["last_4_numbers"]) ? $params["last_4_numbers"] : "";
        $fist_name              = isset($params["fist_name"]) ? $params["fist_name"] : "";
        $last_name              = isset($params["last_name"]) ? $params["last_name"] : "";
        $hotel_member_id        = isset($params["hotel_member_id"]) ? $params["hotel_member_id"] : "";
        $guest_full_name        = isset($params["guest_full_name"]) ? $params["guest_full_name"] : "";
        
        $retain                 = isset($params["retain"]) ? $params["retain"] : 0;
        $retainText             = $retain > 0 ? "true" : "false";
        
        // if data is empty, get from DB by user id
        if($payment_method_token == "")
        {
            $payment_method_token = $userData["payment_method_token"];
            $retainText = "true";
        }
            
        if($last_4_numbers == "")
            $last_4_numbers = $userData["last_4_numbers"];
            
        if($payment_method_token == "" || $last_4_numbers == "" || $fist_name == "" || $last_name == "" || $guest_full_name == "")
            $this->ShowError(ERROR_CODE_REQUEST, ERROR_TEXT_REQUEST);
        
        $payment_method_token   = $this->MySqlScreening($payment_method_token);
        $last_4_numbers         = $this->MySqlScreening($last_4_numbers);
        $fist_name              = $this->MySqlScreening($fist_name);
        $last_name              = $this->MySqlScreening($last_name);
        $hotel_member_id        = $this->MySqlScreening($hotel_member_id);
        $guest_full_name        = $this->MySqlScreening($guest_full_name);
        
        // if retain > 0 and data not empty, save to DB
        if($retain > 0)
        {
            $query = "UPDATE tuser SET payment_method_token = '$payment_method_token', last_4_numbers = '$last_4_numbers' WHERE id = '$id_user'";
            
            $this->ExecuteNonQuery($query);
        }
        
        // Insert order into DB
        
        $query = "INSERT INTO torder (id_hotel, id_roomdeal, id_user, id_manager, id_status, id_duration, id_checkout, user_name, manager_name, room_name, user_phone, user_email, price, tonight_price, total_price, tax, tax_price, subtotal_price, notes_user, visible, payment_method_token, last_4_numbers, fist_name, last_name, hotel_member_id, guest_full_name, date_insert) VALUES ('$id_hotel', '$id_roomdeal', '$id_user', '$id_manager', '$id_status', '$id_duration', '$id_checkout', '$user_name', '$manager_name', '$room_name', '$user_phone', '$user_email', '$price', '$tonight_price', '$total_price', '$tax', '$tax_price', '$subtotal_price', '$notes_user', '$visible', '$payment_method_token', '$last_4_numbers', '$fist_name', '$last_name', '$hotel_member_id', '$guest_full_name', NOW())";
        
        $this->ExecuteNonQuery($query);
        
        $orderId = mysql_insert_id();
        
        if($orderId <= 0)
            $this->ShowError(ERROR_CODE_ORDER, ERROR_TEXT_ORDER);
        
        foreach($bookingData["services"] as $item)
        {
            $itemId     = intval($item["id"]);
            $itemIdSer  = intval($item["id_service"]);
            $itemPrice  = $this->MySqlScreening($item["price"]);
            $itemTPrice = $this->MySqlScreening($item["tonight_price"]);
            $itemDescr  = $this->MySqlScreening($item["description"]);
            $itemVis    = 1;
            
            $query = "INSERT INTO torderservice (id_order, id_service, id_dealservise, price, tonight_price, description, visible, date_insert) VALUES ('$orderId', '$itemIdSer', '$itemId', '$itemPrice', '$itemTPrice', '$itemDescr', '$itemVis', NOW())";
            
            $this->ExecuteNonQuery($query);
        }
        
        // Generate description
        $description = "Order: $orderId; Fist Name: $fist_name; Last Name: $last_name; Hotel Member ID: $hotel_member_id; Guest Full Name: $guest_full_name";
        $description = str_replace("\"", "", $description);
        
        // Get gateway from hotel by id
        $gateway = $this->GetValueByQuery("SELECT gateway_token FROM thotel WHERE id = '$id_hotel'", "gateway_token");
        
        if($gateway == "")
            $this->ShowError(ERROR_CODE_GATEWAY, ERROR_TEXT_GATEWAY);
        
        // Try to Make a Purchase
        $purchaseData = '
        {
            "transaction": {
              "payment_method_token": "'.$payment_method_token.'",
              "amount": '.intval($totalPriceCalc).',
              "currency_code": "USD",
              "retain_on_success": '.$retainText.',
              "order_id": "'.$orderId.'",
              "ip": "'.$_SERVER['REMOTE_ADDR'].'",
              "email": "'.$user_email.'",
              "name": "'.$user_name.'",
              "phone": "'.$user_phone.'",
              "description": "'.$description.'"
            }
        }';
        
        $purchaseUrl = "https://core.spreedly.com/v1/gateways/$gateway/purchase.json";
        
        $purchaseResult = $this->CurlPost($purchaseUrl, ACCESS_SECRET, KEY, $purchaseData);
        
        $query = "UPDATE torder SET purchase_request = '$purchaseData', purchase_response = '".$this->MySqlScreening($purchaseResult)."' WHERE id = '$orderId'";
        
        $this->ExecuteNonQuery($query);
        
        $purchaseResultData = json_decode($purchaseResult, true);
        
        $resMessage = "";
        
        // Update result in DB
        if(isset($purchaseResultData["transaction"]) && isset($purchaseResultData["transaction"]["succeeded"]))
        {
            $succeeded  = $purchaseResultData["transaction"]["succeeded"];
            $resMessage = $this->MySqlScreening($purchaseResultData["transaction"]["message"]);
            
            if($succeeded == "1" || $succeeded == "true" || $succeeded == true)
            {
                $query = "UPDATE torder SET date_pay = NOW(), purchase_result = '$resMessage' WHERE id = '$orderId'";
                
                $this->ExecuteNonQuery($query);
            }
            else
            {
                $query = "UPDATE torder SET purchase_result = '$resMessage' WHERE id = '$orderId'";
                
                $this->ExecuteNonQuery($query);
                
                $this->ShowError(ERROR_CODE_PURCHASE, $resMessage);
            }
        }
        else
        {
            $resMessage = "Invalid purchase!";
            
            $query = "UPDATE torder SET purchase_result = '$resMessage' WHERE id = '$orderId'";
                
            $this->ExecuteNonQuery($query);
            
            $this->ShowError(ERROR_CODE_PURCHASE, $resMessage);
        }
        */
        
        // Send Mail Example
        /*
        $subject = "Subject";
        
        $values = array(
                "name"      => $_POST["name"],
                "email"     => $_POST["email"],
                "subject"   => $subject,
                "msg"       => $_POST["msg"],
            );
        
        //                          mailtype      values   send_to      subject   from_name     from_email
        $res = MailSender::SendMail("contact-us", $values, ADMIN_EMAIL, $subject, DISPLAY_NAME, DISPLAY_EMAIL);
        $res = MailSender::SendMail("contact-us", $values, ADMIN_EMAIL2, $subject, DISPLAY_NAME, DISPLAY_EMAIL);
        */
        
        /*
        $orderData = array(
            "id" => $orderId,
            "total_price" => $totalPriceCalc,
            "submit_date" => date("Y-m-d H:i:s"),
            "message" => $resMessage
        );
        
        return $orderData;
        */
    }
    
    private function ShowResponseList($data)
    {
        $count = count($data);
        
        $response = array();
        
        //$response["total"]
        $response["count"] = $count;
        
        $response["items"] = array();
        
        if($count > 0)
            $response["items"] = $data;
        
        $this->ShowJson($response);
    }
    
    private function ShowResponseSingle($data)
    {
        if(count($data) <= 0)
            $this->ShowError("not_found");
        
        $this->ShowJson($data);
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
    
    function GetFilterWhere($field, $type, $value, $table)
    {
        $where = "";
        
        $val = $this->MySqlScreening($value);
        
        switch($type)
        {
            case "text_contains":
            {
                $where = " AND $table.$field LIKE('%$val%')";
                
                break;
            }
            case "text_start":
            {
                $where = " AND $table.$field LIKE('$val%')";
                
                break;
            }
            case "text_end":
            {
                $where = " AND $table.$field LIKE('%$val')";
                
                break;
            }
            case "text_equals":
            {
                $where = " AND $table.$field = '$val'";
                
                break;
            }
            case "int_equals":
            {
                $val = intval($val);
                $where = " AND $table.$field = $val";
                
                break;
            }
            case "in_array":
            {
                $where = " AND $table.$field IN ($val)";
                
                break;
            }
        }
        
        return $where;
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
        
        $error = array("error" => array("code" => $errors[$key]["code"], "message" => $errors[$key]["message"]));
        
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
    
    function GetValuesByQuery($query)
    {
        $this->db->sql_query($query);
        $row = $this->db->sql_fetchrow();
        $this->db->sql_freeresult();

        if(!$row)
            $row = array();
        
        return $row;
    }
    
    function GetValueByQuery($query, $field)
    {
        $this->db->sql_query($query);
        $row = $this->db->sql_fetchrow();
        $this->db->sql_freeresult();

        $value = "";
        
        if($row && isset($row[$field]))
            $value = $row[$field];
        
        return $value;
    }
    
    private function GetIdByQuery($query)
    {
        $this->db->sql_query($query);
        
        $row = $this->db->sql_fetchrow();
        
        $value = "";
        if($this->db->sql_numrows() > 0)
            $value = $row["id"];
        
        $this->db->sql_freeresult();

        return $value;
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