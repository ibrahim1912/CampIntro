using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection  //süslü parantezin içi --> soyut halleri var ben somut hallerini enjecte ediyorum Bilmiyoruz hangi kredi hangi log 
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices)  //parametrede yazan tüm referansları tutabiliyor
        {
            //basvuran bilgilerini değerlendirme
            krediManager.Hesapla();  //burda hangi krediyi istersek onu yazar(mainde yani) çalıştırırz
            //kredi türünü bağımsız yaptık

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        //Birden fazla kredinin hesabını yapmak istiyoruz
        public void KrediOnBİlgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
