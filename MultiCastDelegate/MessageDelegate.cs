using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDegligate_and_Func
{
    internal class MessageDelegate
    {
        public string Message;

        public string SendEmail(string Message)
        {
            this.Message = Message;
            Console.WriteLine("Email Sent : " + Message);
            return Message;
        }

        public string SendSMS(string Message)
        {
            this.Message = Message;
            Console.WriteLine("SMS Sent : " + Message);
            return Message;
        }

        public string Whatsapp(string Message)
        {
            this.Message = Message;
            Console.WriteLine("Whatsapp Sent : " + Message);
            return Message;
        }
    }
}