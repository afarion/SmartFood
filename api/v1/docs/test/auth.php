<?
include("../../constants.php");
header('Content-Type: text/html; charset=utf-8');
?>
<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
<form action="/<?= API_VERSION ?>/auth/" method="post" target="_blank">
    <table>
        <tr>
            <td>type</td>
            <td><input type="text" name="type" value="1"/></td>
        </tr>
        <tr>
            <td>login</td>
            <td><input type="text" name="login" value=""/></td>
        </tr>
        <tr>
            <td>pass</td>
            <td><input type="text" name="pass" value=""/></td>
        </tr>
        <tr>
            <td></td>
            <td><input type="submit" value="Send POST"/></td>
        </tr>
    </table>
</form>