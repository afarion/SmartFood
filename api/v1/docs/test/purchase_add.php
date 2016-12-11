<?
include("../../constants.php");
header('Content-Type: text/html; charset=utf-8');
?>
<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
<form action="/<?= API_VERSION ?>/purchase/" method="post" target="_blank">
    <table>
        <tr>
            <td>user_id</td>
            <td><input type="text" name="user_id" value="1"/></td>
        </tr>
        <tr>
            <td>user_type</td>
            <td><input type="text" name="user_type" value="1"/></td>
        </tr>
        <tr>
            <td>user_sid</td>
            <td><input type="text" name="user_sid" value=""/></td>
        </tr>
    
        <tr>
            <td>action</td>
            <td><input type="text" name="action" value="add"/></td>
        </tr>
        
        <tr>
            <td>id_item</td>
            <td><input type="text" name="id_item" value=""/></td>
        </tr>
        <tr>
            <td>id_provider</td>
            <td><input type="text" name="id_provider" value=""/></td>
        </tr>
        <tr>
            <td>id_employee</td>
            <td><input type="text" name="id_employee" value=""/></td>
        </tr>
        <tr>
            <td>amount</td>
            <td><input type="text" name="amount" value=""/></td>
        </tr>
        <tr>
            <td>price</td>
            <td><input type="text" name="price" value=""/></td>
        </tr>
        
        <tr>
            <td></td>
            <td><input type="submit" value="Send POST"/></td>
        </tr>
    </table>
</form>