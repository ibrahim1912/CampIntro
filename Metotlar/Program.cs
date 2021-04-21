using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 7;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyat = 18;
            urun2.Aciklama = "İzmir Çileği";

            Urun[] urunler = new Urun[] 
            { 
                urun1, urun2 
            };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------");
              
            }

            Console.WriteLine("--------------Metotlar--------------");

            //instance - class örneği oluşturduk
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); 
            sepetManager.Ekle(urun2); //burda hata yok *encapsulation
            //sepetManager.Ekle(); //beş farklı sayfa olarak düşünürsek kullanışlı oldu.Bir değişiklik olursa sayfa sayfa uğraşmıcaz
            //sepetManager.Ekle(); // direk ekle metoduna gidip kod ekleyip çıkartcaz.
            sepetManager.Ekle2("Armut", "Yemyeşil", 17);   // bunların hepsi farklı sayfada olsun
            sepetManager.Ekle2("Muz", "Antalya", 18);      //ektra stok adeti ekleme istiyoruz
            sepetManager.Ekle2("Portakal", "Washington", 8);  // ekrta bilgi eklenince kırmızı oldular yani her sayfada tek tek sonradan eklemek gerekti
        }
    }
}
