<?

class Mail
{
	var $sendTo;
	var $subject;
	var $message;
	var $fromName;
	var $fromEmail;
	
	function Mail($sendTo, $subject, $message, $fromName, $fromEmail)
	{
		$this->sendTo		= $sendTo;
		$this->subject		= $subject;
		$this->message		= $message;
		$this->fromName 	= $fromName;
		$this->fromEmail    = $fromEmail;
	}
	
	function Send($asHtml = false)
	{
		$headers = "";
		
		if($asHtml)
			$headers = 'Content-type: text/html; charset=UTF-8' . "\r\n";
        else
            $headers = 'Content-type: text/plain; charset=UTF-8' . "\r\n";
        //$this->message = convert_cyr_string ($this->message,i,k);
            
		$headers .= "From: " . $this->fromName . "<" . $this->fromEmail .">\r\n";
		$headers .= "Reply-To: " . $this->fromEmail . "\r\n";
		$headers .= "Return-path: " . $this->fromEmail;
		
		if(@mail($this->sendTo, $this->subject, $this->message, $headers))
			$answer='ok';
		else 
			$answer='error';

		return $answer;
	}
	

}

?>