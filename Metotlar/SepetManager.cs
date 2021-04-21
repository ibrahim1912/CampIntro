using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager  //manager demek operasyon tutuo demektir
    {
        //naming convention E büyük 

        public void Ekle(Urun herhangi) //parantez içi parametre Urun tipini belirlemek için like int,string
        {
            Console.WriteLine("Sepete eklendi : " + herhangi.Adi);  //+ string birleştirmesi
        }

        public void Ekle2(string urunAdi, string urunAciklama, int urunFiyat,int urunStokAdet)  //ektra stok adeti ekledik burdan koda ekleme yaptk
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
