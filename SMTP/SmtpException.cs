using System;

namespace SMTP
{
    class SmtpException :Exception
    {
        private string message;
        public SmtpException(string str)
        {
            message = str;
        }
        public string GetMessage()
        {
            return message;
        }
    }
}
