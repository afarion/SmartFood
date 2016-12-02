<?

session_start();
session_set_cookie_params(3600);

define("BASE_DIR", dirname(__FILE__));

include BASE_DIR."/../constants.php";
include BASE_DIR."/../mysql.php";
include BASE_DIR."/../config.php";
include BASE_DIR."/../auth.php";

$auth = new Auth();

$params = $auth->GetParams("login", "post");

$auth->LogIn($params);

$auth->Close();

?>