using System;

namespace OOP2
{
    class Program   //inheritance
        
    {
        static void Main(string[] args)
        {
           

            //İbrahim Kaplan
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12346";
            musteri1.Adi = "İbrahim";
            musteri1.Soyadi = "Kaplan";
            musteri1.TcNo = "1245454";

            //Website Xpace
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "44548";
            musteri2.SirketAdi = "Xpace";
            musteri2.VergiNo = "1121212";

            //Asıl olay bunlarmış
            Musteri musteri3 = new GercekMusteri();  // ref.Nosu
            Musteri musteri4 = new TuzelMusteri(); // ref.Nosu childreni için tutabilir
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);   //burda tüm musteri1234 ü görüyor.Parametremiz Musteri class ı idi.
            musteriManager.Ekle(musteri4);


        }
    }
}
