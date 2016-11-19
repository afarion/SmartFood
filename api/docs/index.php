<?

include "docGen.php";

$dg = new DocumentationGenerator();

if(isset($_GET["page"]))
{
    echo $dg->GetPage($_GET["page"]);
}
else
{
    //echo $dg->GetPage("main");
    echo $dg->GetPage("countries");
}


?>