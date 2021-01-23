using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() };

            BasvuruManager basvuruManager = new BasvuruManager();
            //Depencancy injection
            basvuruManager.BasvuruYap(ihtiyacKrediManager, loggers);
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { databaseLoggerService });
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { fileLoggerService });
            basvuruManager.BasvuruYap(esnafKrediManager, new List<ILoggerService> { smsLoggerService });

            /*                                              */
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            //SOLID Open closed - Sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz
        }
    }
}
