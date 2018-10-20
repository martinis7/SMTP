using System;
using System.IO;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace SMTP
{
    class SmtpProtocol
    {
        public static TcpClient Client { get; set; }
        public static SslStream SslStream { get; set; }

        // The following method is invoked by the RemoteCertificateValidationDelegate.
        public static bool ValidateServerCertificate(
              object sender,
              X509Certificate certificate,
              X509Chain chain,
              SslPolicyErrors sslPolicyErrors)
        {
            if (sslPolicyErrors == SslPolicyErrors.None)
                return true;

            Console.WriteLine(@"Certificate error: {0}", sslPolicyErrors);

            // Do not allow this client to communicate with unauthenticated servers.
            return false;
        }

        public static void ConnectClientAndAuthorize(string serverName, int port, string username, string password)
        {
            // Create a TCP/IP client socket.
            Client = new TcpClient(serverName, port);

            // Create an SSL stream that will close the client's stream.
            SslStream = new SslStream(
                Client.GetStream(),
                false,
                ValidateServerCertificate,
                null
                );
            //The server name must match the name on the server certificate.
            try
            {
                SslStream.AuthenticateAsClient(serverName);
            }
            catch (AuthenticationException e)
            {
                Console.WriteLine(@"Exception: {0}", e.Message);
                if (e.InnerException != null)
                {
                    Console.WriteLine(@"Inner exception: {0}", e.InnerException.Message);
                }
                Console.WriteLine(@"Authentication failed - closing the connection.");
                Client.Close();
                return;
            }

            // Perskaitome zinute po prisijungimo, jei grazinama ne 220 metame exception
            CheckResponse(Read(), "220");

            // Siunciame pasisveikinima
            string[] split = username.Split('@');
            Write("EHLO " + split[1] + "\r\n");

            CheckResponse(Read(), "250");

            // Prisijungimas naudojantis AUTH LOGIN
            Write("AUTH LOGIN\r\n");
            CheckResponse(Read(), "334");

            // Siunciame prisijungimo varda ir slaptazodi uzkoduota base64

            string msg = Base64Encode(username);
            StreamWriter writer = new StreamWriter(SslStream);
            writer.Write(msg);
            writer.Flush();

            writer.Write("\r\n");
            writer.Flush();

            CheckResponse(Read(), "334");

            msg = Base64Encode(password);
            writer.Write(msg);
            writer.Flush();

            writer.Write("\r\n");
            writer.Flush();

            CheckResponse(Read(), "235");

            Write("MAIL FROM: <" + username +">\r\n");
            CheckResponse(Read(), "250");
        }

        public static void SendMail(string recipient, string subject, string message)
        {
            Write("RCPT TO: <" + recipient + ">\r\n");
            CheckResponse(Read(), "250");

            Write("DATA\r\n");
            CheckResponse(Read(), "354");

            Write("Subject: " + subject + "\r\n" + message);

            SslStream.Write(Encoding.ASCII.GetBytes("\r\n.\r\n"));
            SslStream.Flush();

            CheckResponse(Read(), "250");
            Close();
        }

        public static void Close()
        {
            Client.Close();
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.ASCII.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static void Write(string message)
        {
            byte[] writeBuffer = Encoding.ASCII.GetBytes(message);
            SslStream.Write(writeBuffer);
            SslStream.Flush();
        }

        public static string Read()
        {
            byte[] readBuffer = new byte[1024];
            int count = SslStream.Read(readBuffer, 0, 1024);
            return Encoding.ASCII.GetString(readBuffer, 0, count);
        }

        public static void CheckResponse(string message, string code)
        {
            if (message.Substring(0, 3) != code)
            {
                throw new SmtpException(message);
            }
        }
    }
}
