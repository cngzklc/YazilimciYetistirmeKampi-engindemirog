using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediMenager ihtiyacKredMenager = new IhtiyacKredMenager();
            IKrediMenager tasitKredMenager = new TasitKrediManager();
            IKrediMenager konutKredMenager = new IhtiyacKredMenager();
            IKrediMenager esnafKrediManager = new EsnafKrediManager();

            ILogerService databaseLoggerService = new DatabaseLoggerService();
            ILogerService fileLoggerService = new FileLoggerService();
            ILogerService smsLoggerService = new SmsLoggerService();

            List<ILogerService> logerServices = new List<ILogerService> { databaseLoggerService, fileLoggerService, smsLoggerService };
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, logerServices/*new DatabaseLoggerService()*/);
            List<IKrediMenager> krediler = new List<IKrediMenager> { ihtiyacKredMenager,tasitKredMenager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
