using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            // new DatabaseLoggerService() olarak parametre verilebilir. yukarıdaki mantıkla aynıdır.

            //basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService(), new DatabaseLoggerService()});

            List<ILoggerService> loggers = new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService() };
            basvuruManager.BasvuruYap(konutKrediManager, loggers);

            //basvuruManager.BasvuruYap(tasitKrediManager, new SmsLoggerService(), new DatabaseLoggerService());

            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);



            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager, konutKrediManager, tasitKrediManager
            };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);




            Console.ReadLine();
        }
    }
}
