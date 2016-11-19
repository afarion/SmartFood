<?php
include("mail.php");

class MailSender
{
    function __construct()
    {
        //...
    }
    
    static public function GetMessage($mail_type, $values)
    {
        $message = "";
        
        if($mail_type == "contact-us")
        {
            $message = self::GetMailContactUs($values);
        }
        
        return $message;
    }
    
    static public function SendMail($mail_type, $values, $sendTo, $subject, $fromName, $fromEmail)
    {
        $message = self::GetMessage($mail_type, $values);
        
        $mail = new Mail($sendTo, $subject, $message, $fromName, $fromEmail);
        
        //Mail
        //self::LogMessage($sendTo, $subject, $message, $fromName, $fromEmail);
        //////
        
        $answer = $mail->Send(true);
        if($answer == 'ok')
        {
            return true;
        }
            
        return false;
    }
    
    static public function SendReadyMail($sendTo, $subject, $message, $fromName, $fromEmail)
    {
        $mail = new Mail($sendTo, $subject, $message, $fromName, $fromEmail);
        
        //Mail
        //self::LogMessage($sendTo, $subject, $message, $fromName, $fromEmail);
        //////
        
        $answer = $mail->Send(true);
        if($answer == 'ok')
        {
            return true;
        }
            
        return false;
    }
    
    static function LogMessage($email_to, $title, $text, $name_from, $email_from)
    {
        $log_file = fopen('message_logger.html', 'a');
        
        fwrite($log_file, '<div class="mail">');
        fwrite($log_file, "<h1>Получатель: $email_to</h1>");
        fwrite($log_file, "<h1>Письмо от: $email_from ($name_from)</h1>");
        fwrite($log_file, "<h1>Тема: $title</h1><br />");
        fwrite($log_file, "$text");
        fwrite($log_file, "<br /><br /><br />");
        
        fclose($log_file);
    }
    
    static function GetMailContactUs($values)
    {
        $text = '<style type="text/css">.content { font: normal 12px Verdana; }</style>
<div class="content">
Full Name: '.$values["name"].'
<br />
E-mail (Tel): '.$values["email"].'
<br /> 
Subject: '.$values["subject"].'
<br />
Message: '.$values["msg"].'
</div>';
        
        return $text;
    }

}
?>