using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ExceptionIntro();
            //KlasikTryCatch();
            //ActionDemo();  //burda invoke ile çalıştır diyoruz sadece func da extra bir de değer döndürür
            // Console.WriteLine(Topla(2, 3));

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(8,3));  // add delege

            Func<int> getRandomNumber = delegate ()  //parametresiz delege
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());

        }

        static int Topla(int x, int y)
        {
            return x + y;
        }

        private static void ActionDemo()
        {

            //metot  //parametre olarak metot göndermek istiyoruz c# da kullanımı çok güzel
            //delege ile gönderebiliyoruz
            HandleException(() =>   //parametresiz bir kod bloğu göndericem bunun karşılığı süslü parantez
            {
                Find();
            });
        }

        private static void KlasikTryCatch()
        {
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void HandleException(Action action)  // action >> void operasyonları için no parametre
        {
            //merkezi try catch gbi oldu
            try
            {
                action.Invoke();  // invoke demek Find() ı burda try ın içinde çalıştır demek
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<String> students = new List<String> { "İbrahim", "ALtan", "Efe" };
            if (!students.Contains("Ahmet"))// yoksa
            {
                throw new RecordNotFoundException("Record not found"); //burayı çalıştır //hata fırlat demek

            }
            else
            {
                Console.WriteLine("Record found"); //varsa ekrana burayı yazdır
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] isimler = new string[] { "İbrahim", "ALtan", "Efe" };
                isimler[3] = "Ahmet";
                Console.WriteLine(isimler[3]);
            }
            catch (IndexOutOfRangeException exception)  // bu hatayı yakalarsa sadce burayı çalıştır 
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception) //hata biligisi expension a aktarılır
            {
                Console.WriteLine("Exception!!");
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.InnerException); //daha detaylı varsa gösterir
            }
        }
    }
}
