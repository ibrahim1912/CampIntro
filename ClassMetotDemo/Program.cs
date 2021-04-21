using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ozan Yılmaz";
            musteri1.Yasi = 27;
            musteri1.Sehir = "Aydın";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Serhat Kalem";
            musteri2.Yasi = 15;
            musteri2.Sehir = "Sivas";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Hayrettin Bakıcı";
            musteri3.Yasi =40;
            musteri3.Sehir = "Rize";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Silme(musteri3);
            musteriManager.Silme(musteri1);
            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            Console.ReadLine();

        }
    }
}
