using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "İbrahim", "Efe", "Elif" };  // stack -- heap --values
            Console.WriteLine(isimler[0]);
            /*isimler[3] = "can";  // outside bound of array yani out of range hatası
            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }*/

            //böyle bir çözüm düşünsek
            isimler = new string[4];  //new ile adresi değiştirdik
            isimler[3] = "can";
            Console.WriteLine(isimler[3]);
            foreach (var item in isimler) //burda 0,1,2 olan indexleri boş basar çünkü new yeni bir heap değeri oluşturduk
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------");
            //dizilerdeki problem: dizileri genişletemiyoruz.Genişletince var olanlar boş null oluyor.
            //bu problemden kurtulmak için listeler kullanılır

            List<string> isimler2 = new List<string> { "Ali", "Veli", "Deli" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            isimler2.Add("Hassan");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            

        }
    }
}
