<?
include("../../constants.php");
header('Content-Type: text/html; charset=utf-8');
?>
<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
<form action="/<?= API_VERSION ?>/employee/" method="post" target="_blank">
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
            <td>id_type</td>
            <td><input type="text" name="id_type" value=""/></td>
        </tr>
        
        <tr>
            <td>first_name</td>
            <td><input type="text" name="first_name" value=""/></td>
        </tr>
        
        <tr>
            <td>last_name</td>
            <td><input type="text" name="last_name" value=""/></td>
        </tr>
        
        <tr>
            <td>phone</td>
            <td><input type="text" name="phone" value=""/></td>
        </tr>
        
        <tr>
            <td>phone_ex</td>
            <td><input type="text" name="phone_ex" value=""/></td>
        </tr>
        
        <tr>
            <td>skype</td>
            <td><input type="text" name="skype" value=""/></td>
        </tr>
        
        <tr>
            <td>address</td>
            <td><input type="text" name="address" value=""/></td>
        </tr>
        
        <tr>
            <td>email</td>
            <td><input type="text" name="email" value=""/></td>
        </tr>
        
        <tr>
            <td>birthday</td>
            <td><input type="text" name="birthday" value=""/></td>
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