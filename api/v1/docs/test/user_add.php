<?
include("../../constants.php");
header('Content-Type: text/html; charset=utf-8');
?>
<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
<form action="/<?= API_VERSION ?>/user/" method="post" target="_blank">
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
            <td>name</td>
            <td><input type="text" name="name" value=""/></td>
        </tr>
        
        <tr>
            <td>phone</td>
            <td><input type="text" name="phone" value=""/></td>
        </tr>
        
        <tr>
            <td>email</td>
            <td><input type="text" name="email" value=""/></td>
        </tr>
        
        <tr>
            <td>discount_fixed</td>
            <td><input type="text" name="discount_fixed" value=""/></td>
        </tr>
        
        <tr>
            <td>comment</td>
            <td><input type="text" name="comment" value=""/></td>
        </tr>
        
        <tr>
            <td></td>
            <td><input type="submit" value="Send POST"/></td>
        </tr>
    </table>
</form>