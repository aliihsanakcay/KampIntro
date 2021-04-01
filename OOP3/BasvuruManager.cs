using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method Injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices  /*params ILoggerService [] loggerServices bu da mümkün*/)
        {
            //Başvuran bilgilerini değerlendirme 
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();    =>   YANLIŞ
            //Çünkü bunu yaparsan bütün başvuruları konut kredi başvurusuna bağımlı hale getirirsin!!!
            //Bu da design pattern lara uymuyor.


            krediManager.Hesapla();   //Burada ise kredi bağımsız hale getirmiş olduk.
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
