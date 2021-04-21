using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string  kategoriEtiketi = "Kategori";

            string[] kurslar = new string[] { "C#","java","alfa","beta"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string item in kurslar) //dizilere uygulanır
            {
                Console.WriteLine(item);
            }

            string kurs01 = "Yeni bir kamp"; // tipi string

            Kurs kurs1 = new Kurs(); //kurs1 in tipi Kurs       
            kurs1.KursAdi = "CSS";
            kurs1.Egitmen = "Halil İbo";
            kurs1.IzlenmeOranı = 85;

            Kurs kurs2 = new Kurs();   
            kurs2.KursAdi = "JS";
            kurs2.Egitmen = "Peker Bey";
            kurs2.IzlenmeOranı = 25;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "HTML";
            kurs3.Egitmen = "Erol Egemen";
            kurs3.IzlenmeOranı = 55;

            Console.WriteLine(kurs3.KursAdi +  ":" + kurs3.Egitmen);

            Kurs[] kurslar1 = new Kurs[] {kurs1,kurs2,kurs3};
            foreach (var item in kurslar1)
            {
                Console.WriteLine(item.KursAdi + ":" + item.IzlenmeOranı);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }
}
