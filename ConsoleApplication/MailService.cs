using System;
namespace ConsoleApplication{
    internal class MailService{
        public void SendEmail(string message){
            Connect();
            Authenticate();
            Console.WriteLine($"Send Email : {message}");
            Disconnect();
        }

        private void Connect(){
            Console.WriteLine("CONNECT");
        }

        private void Authenticate(){
            Console.WriteLine("AUTHENTICATE");
        }

        private void Disconnect(){
            Console.WriteLine("DISCONNECT");
        }
    }
}