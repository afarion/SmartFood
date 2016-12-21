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
                $this->CheckUserPermissions($method, $userType, 0);
                
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
                $this->CheckUserPermissions($method, $userType, 1);
                
                $this->UpdateObject($method, $request);
                
                break;
            }
            case "add":
            {
                $this->CheckUserPermissions($method, $userType, 2);
                
                $this->InsertObject($method, $request);
                
                break;
            }
            case "remove":
            {
                $this->CheckUserPermissions($method, $userType, 3);
                
                $this->DeleteObject($method, $request);
                
                break;
            }
            default:
            {
                $this->ShowError("action");
                break;
            }
        }
    }
    
    private function TryToExecuteLog($method, $request, $idObject, $actionType, $oldValuesData = array())
    {
        //$actionType = 1 Insert
        //$actionType = 2 Update
        //$actionType = 3 Purchase
        //$actionType = 4 Outlay
        
        $methodConfig = $this->config[$method];
        
        if(!isset($methodConfig["log_table"]))
            return false;
        
        $logTable = $methodConfig["log_table"];
        
        $idAdmin = $request["user_id"];
        
        $fieldsConfig = $methodConfig["fields"];
        
        foreach($fieldsConfig as $fieldName => $fieldData)
        {
            if(!isset($request[$fieldName]))
                continue;
                
            $fieldType = $fieldData["type"];
            
            $valueOld = "";
            if(isset($oldValuesData[$fieldName]))
                $valueOld = $oldValuesData[$fieldName];
            
            $valueNew = $request[$fieldName];
            
            if($valueOld == $valueNew)
                continue;
                
            $this->InsertIntoLog($logTable, $idAdmin, $idObject, $actionType, $fieldName, $fieldType, $valueOld, $valueNew);
        }
    }
    
    private function InsertIntoLog($logTable, $idAdmin, $idObject, $actionType, $fieldName, $fieldType, $valueOld, $valueNew)
    {
        $idAdmin    = intval($idAdmin);
        $idObject   = intval($idObject);
        $actionType = intval($actionType);
        
        $fieldName  = $this->MySqlScreening($fieldName);
        $fieldType  = $this->MySqlScreening($fieldType);
        $valueOld   = $this->MySqlScreening($valueOld);
        $valueNew   = $this->MySqlScreening($valueNew);
        
        $query = "INSERT INTO $logTable (id_admin, id_object, action_type, field_name, field_type, value_old, value_new) VALUES ($idAdmin, $idObject, $actionType, '$fieldName', '$fieldType', '$valueOld', '$valueNew')";
        
        $res = $this->ExecuteNonQuery($query);
        
        return $res;
    }
    
    private function ExecuteCallBack($name, $method, $request)
    {
        switch($name)
        {
            case "update_purchase":
                $this->UpdatePurchase($method, $request);
                break;
                
            case "update_outlay":
                $this->UpdateOutlay($method, $request);
                break;
            
            case "add_order":
                $this->OnOrderAdd($method, $request);
                break;
                
            case "edit_order":
                $this->OnOrderEdit($method, $request);
                break;
                
            case "add_orderdish":
                $this->OnOrderDishAdd($method, $request);
                break;
                
            case "edit_orderdish":
                $this->OnOrderDishEdit($method, $request);
                break;
        }
    }
    
    private function OnOrderAdd($method, $request)
    {
        //Update user address
        
        //Update discount
        
        
    }
    
    private function OnOrderEdit($method, $request)
    {
        
    }
    
    private function OnOrderDishAdd($method, $request)
    {
        //Check in warehouse
    }
    
    private function OnOrderDishEdit($method, $request)
    {
        
    }
    
    private function UpdatePurchase($method, $request)
    {
        if(!isset($request["id_item"]) || !isset($request["amount"]) || !isset($request["price"]))
            $this->ShowError("request");
            
        $id_item    = $this->FormatField($request["id_item"], "int");
        $amount     = $this->FormatField($request["amount"], "float");
        $price      = $this->FormatField($request["price"], "float");
        
        $priceSingle = $price / $amount;
        
        $itemTable = $this->config["item"]["table"];
        
        $currentData    = $this->GetValuesByQuery("SELECT amount, price FROM $itemTable WHERE id = $id_item");
        $currentAmount  = $this->FormatField($currentData["amount"], "float");
        $currentPrice   = $this->FormatField($currentData["price"], "float");
        
        $resultAmount = $currentAmount + $amount;
        
        $query = "UPDATE $itemTable SET amount = $resultAmount, price = '$priceSingle' WHERE id = $id_item";
        
        $this->ExecuteNonQuery($query);
        
        $this->TryToExecuteLog("item", array("amount" => $resultAmount, "price" => $priceSingle), $id_item, 3, array("amount" => $currentAmount, "price" => $currentPrice));
    }
    
    private function UpdateOutlay($method, $request)
    {
        if(!isset($request["id_item"]) || !isset($request["amount"]))
            $this->ShowError("request");
            
        $id_item    = $this->FormatField($request["id_item"], "int");
        $amount     = $this->FormatField($request["amount"], "float");
        
        $itemTable = $this->config["item"]["table"];
        
        $currentAmount = $this->GetValueByQuery("SELECT amount FROM $itemTable WHERE id = $id_item", "amount");
        $currentAmount = $this->FormatField($currentAmount, "float");
        
        $resultAmount = $currentAmount - $amount;
        
        if($resultAmount < 0)
            $this->ShowError("amount");
        
        $query = "UPDATE $itemTable SET amount = $resultAmount WHERE id = $id_item";
        
        $this->ExecuteNonQuery($query);
        
        $this->TryToExecuteLog("item", array("amount" => $resultAmount), $id_item, 4, array("amount" => $currentAmount));
    }
    
    private function CheckUserPermissions($method, $userType, $key)
    {
        if(isset($this->config[$method]["permission"]))
        {
            if(!isset($this->config[$method]["permission"][$userType]) 
            || !isset($this->config[$method]["permission"][$userType][$key])
            || !$this->config[$method]["permission"][$userType][$key])
                $this->ShowError("perm"); 
        }
    }
    
    private function InsertObject($method, $request)
    {
        //Unknown method (not exist in config file)
        if(!isset($this->config[$method]))
            $this->ShowError("method");
        
        $methodConfig = $this->config[$method];
        
        if(!isset($methodConfig["fields"]))
            $this->ShowError("request");
        
        $insertFields = array();
        $insertValues = array();
        
        foreach($methodConfig["fields"] as $fieldName => $fieldConfig)
        {
            $fieldType  = $fieldConfig["type"];
            $fieldDef   = $fieldConfig["default"];
            
            if(!isset($request[$fieldName]) && $fieldDef === false)
                $this->ShowError("request");
            
            $fieldValue = $fieldDef;
            if(isset($request[$fieldName]))
                $fieldValue = $request[$fieldName];
            
            $insertFields[] = $fieldName;
            $insertValues[] = $this->FormatField($fieldValue, $fieldType);
        }
        
        if(count($insertFields) <= 0)
            $this->ShowError("request");
        
        if(isset($methodConfig["add_callback"]))
            $this->ExecuteCallBack($methodConfig["add_callback"], $method, $request);
        
        $table = $methodConfig["table"];
        
        $query = "INSERT INTO $table (".join(",", $insertFields).") VALUES (".join(",", $insertValues).")";
        
        $this->ExecuteNonQuery($query);
        
        $newId = mysql_insert_id();
        
        if(intval($newId) <= 0)
            $this->ShowError("insert");
        
        $this->TryToExecuteLog($method, $request, $newId, 1);
        
        $response = array("success" => $newId);
        
        $this->ShowJson($response);
    }
    
    private function DeleteObject($method, $request)
    {
        //Unknown method (not exist in config file)
        if(!isset($this->config[$method]))
            $this->ShowError("method");
        
        $methodConfig = $this->config[$method];
        
        if(!isset($methodConfig["fields"]))
            $this->ShowError("request");
        
        if(!isset($request["id"]))
            $this->ShowError("request");
            
        $id = intval($request["id"]);
        
        $table = $methodConfig["table"];
        
        $query = "DELETE FROM $table WHERE id = $id";
        
        $res = $this->ExecuteNonQuery($query);
        
        if(!$res)
            $this->ShowError("request");
        
        $response = array("success" => $id);
        
        $this->ShowJson($response);
    }
    
    private function UpdateObject($method, $request)
    {
        //Unknown method (not exist in config file)
        if(!isset($this->config[$method]))
            $this->ShowError("method");
        
        $methodConfig = $this->config[$method];
        
        if(!isset($methodConfig["fields"]))
            $this->ShowError("request");
        
        if(!isset($_POST["id"]))
            $this->ShowError("request");
        
        $id = intval($_POST["id"]);
        
        if($id <= 0)
            $this->ShowError("request");
        
        $table = $methodConfig["table"];
        
        $fields = join(",", array_keys($methodConfig["fields"]));
        
        $oldValuesData = $this->GetValuesByQuery("SELECT $fields FROM $table WHERE id = $id");
        
        $updateValues = array();
        
        foreach($methodConfig["fields"] as $fieldName => $fieldConfig)
        {
            $fieldType  = $fieldConfig["type"];
            $fieldEdit  = $fieldConfig["editable"];
            
            if(!isset($request[$fieldName]))
                continue;
                
            if(!$fieldEdit)
                $this->ShowError("request");
                
            $fieldValue = $this->FormatField($request[$fieldName], $fieldType);
            
            $updateValues[] = "$fieldName = $fieldValue";
        }
        
        if(count($updateValues) <= 0)
            $this->ShowError("request");
        
        if(isset($methodConfig["edit_callback"]))
            $this->ExecuteCallBack($methodConfig["edit_callback"], $method, $request);
        
        $query = "UPDATE $table SET ".join(",", $updateValues)." WHERE id = $id";
        
        $res = $this->ExecuteNonQuery($query);
        
        if(!$res)
            $this->ShowError("request");
            
        $this->TryToExecuteLog($method, $request, $id, 2, $oldValuesData);
        
        $response = array("success" => $id);
        
        $this->ShowJson($response);
    }
    
    private function FormatField($value, $type)
    {
        switch($type)
        {
            case "int":
            {
                if($value != "NULL")
                    $value = intval($value);
                
                break;
            }
            case "flag":
            {
                if($value != "NULL")
                {
                    $value = intval($value);
                    if($value > 0)
                        $value = 1;
                    else
                        $value = 0;
                }
                
                break;
            }
            case "float":
            {
                if($value != "NULL")
                {
                    $value = str_replace(",", ".", $value);
                    $value = floatval($value);
                }
                
                break;
            }
            case "date":
            {
                if($value != "NOW()" && $value != "NULL")
                    $value = "'$value'";
                
                break;
            }
            case "text":
            {
                if($value != "NULL")
                {
                    $value = $this->MySqlScreening($value);
                    $value = "'$value'";
                }
                
                break;
            }
            case "pass":
            {
                $value = md5($value);
                $value = "'$value'";
            
                break;
            }
            default:
            {
                $value = $this->MySqlScreening($value);
                $value = "'$value'";
            }
        }
        
        return $value;
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
                /*
                else if($data["type"] == "price")
                {
                    $fields[] = "CAST($table.$field * 100 AS UNSIGNED) as $key";
                }
                */
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
            /*
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
            */
            
            if(isset($methodConfig["filters"]))
            {
                foreach($methodConfig["filters"] as $key => $filterData)
                {
                    if(!isset($request[$key]))
                    {
                        if(isset($filterData["required"]) && $filterData["required"] == true)
                            $this->ShowError("request");
                        
                        continue;
                    }
                        
                    $val = $request[$key];
                        
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
            
            if(isset($methodConfig["sort"]) && is_array($methodConfig["sort"]) && count($methodConfig["sort"]) > 0)
            {
                // By default first
                $orderParam = array_values($methodConfig["sort"])[0];
                
                // Custom order
                if(isset($request["sort"]))
                {
                    $orderVal = $request["sort"];
                    
                    if(isset($methodConfig["sort"][$orderVal]))
                        $orderParam = $methodConfig["sort"][$orderVal];
                }
                
                if(is_array($orderParam))
                {
                    $paramOrderBy       = $orderParam["by"];
                    $paramOrderTable    = $orderParam["table"];
                    
                    if(isset($orderParam["distinct"]) && $orderParam["distinct"] == true)
                        $distinct = " distinct ";
                    
                    if(isset($orderParam["where"]))
                        $where .= $orderParam["where"];
                    
                    if(isset($orderParam["join"]))
                        $join[$paramOrderTable] = $orderParam["join"];
                    
                    $orderBy = " ORDER BY ".$paramOrderBy;
                }
                else
                {
                    $orderBy = " ORDER BY ".$orderParam;
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
        //$key = session_id();
        
        $date = date("Y-m-d");
        
        $dir = dirname(__FILE__)."/logs/".$date;
        
        if(!file_exists($dir))
            mkdir($dir);
            
        //$dir .= "/".$key;
        
        //if(!file_exists($dir))
        //    mkdir($dir);
            
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
    
    function ShowError($key, $message = false)
    {
        $errors = $this->config["errors"];
        
        if(!isset($errors[$key]))
            $key = "undefined";
        
        $statusCode = $errors[$key]["status_code"];
        
        if($message === false)
            $message = $errors[$key]["message"];
        
        $error = array("code" => $errors[$key]["code"], "message" => $message);
        
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
        $error = $this->db->sql_error(); 
        $this->db->sql_freeresult();
        
        if($error["code"] > 0)
            return false;
            
        return true;
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