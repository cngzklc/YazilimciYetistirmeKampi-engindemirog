using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerService : ILogerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Loglandı");
        }
    }
}
