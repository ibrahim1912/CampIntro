using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteriler eklendi :" + musteri.Adi);

        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Musteriler silindi :" + musteri.Adi);

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Musterilerin sehirleri listelendi :" + musteri.Sehir);

        }

    }

}
