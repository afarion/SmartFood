<?
include("../../constants.php");
header('Content-Type: text/html; charset=utf-8');
?>
<meta http-equiv="Content-type" content="text/html; charset=utf-8" />
<form action="/<?= API_VERSION ?>/provider/" method="post" target="_blank">
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
            <td><input type="text" name="action" value="edit"/></td>
        </tr>
        
        <tr>
            <td>id</td>
            <td><input type="text" name="id" value=""/></td>
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
            <td>skype</td>
            <td><input type="text" name="skype" value=""/></td>
        </tr>
        
        <tr>
            <td>notes</td>
            <td><input type="text" name="notes" value=""/></td>
        </tr>
        
        <tr>
            <td>visible</td>
            <td><input type="text" name="visible" value="1"/></td>
        </tr>
        
        <tr>
            <td></td>
            <td><input type="submit" value="Send POST"/></td>
        </tr>
    </table>
</form>