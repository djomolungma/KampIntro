using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    
    class BasvuruManager
    {
        //Dependency Injection örneği (Method injection)
        //Başvuru kredi bağımsız hale geldi
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme

            //Hatalı kod
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Olması gereken esnek ve doğru kod
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
