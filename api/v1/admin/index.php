<?

session_start();
session_set_cookie_params(3600);

define("BASE_DIR", dirname(__FILE__));

include BASE_DIR."/../constants.php";
include BASE_DIR."/../mysql.php";
include BASE_DIR."/../config.php";
include BASE_DIR."/../sfapi.php";

$api = new SmartFoodApi();

$request = $_POST;
$request["method"] = "admin";

$api->AnalyzeRequest($request);

$api->Close();

?>