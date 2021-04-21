using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager  //ürünle ilgili operasyonlar var -silme-güncelleme vs.
    {
        //encapsulation
        public void Add(Product product)   // bunu String ad (biçim olarak) gibi düşün Product product korkutmasın
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product) 
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

    }
}
