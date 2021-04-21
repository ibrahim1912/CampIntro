using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();  //interfacede aynı referans nosu alabilir.çalışır
            //ihtiyacKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
           // basvuruManager.BasvuruYap(ihtiyacKrediManager);

            Console.WriteLine("-----------------------------------");

            //süslü parantez içi ekran olarak düşün.istenen krediyi seçtik
            //istediğin kadar kredi secebilirsin çünkü parametre olarak list gönderdik
            List<IKrediManager> krediler = new List<IKrediManager>() {tasitKrediManager,ihtiyacKrediManager}; 
            basvuruManager.KrediOnBİlgilendirmesiYap(krediler);

            Console.WriteLine("-----------------------------------");

            basvuruManager.BasvuruYap(konutKrediManager,new List<ILoggerService> {new DatabaseLoggerService(),new FileLoggerService()});

            //yeni bir kredi oluşturma yada log oluşturmak için sadece class açmamız yeterli
            //solid in o hrfi olur open cross prinsible
            //yani yeni bir sey eklediğimiz zaman diğer kodları değiştirmemize gerek yok
            //ya da sisteme yeni bir özellik eklendiğinde mevcut kodlar bozulmaz
        }
    }
}
