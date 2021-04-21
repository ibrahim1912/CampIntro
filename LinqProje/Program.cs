using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProje
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>(){
                new Category(){CategoryId=1,CategoryName="Bigisayar"},
                new Category(){CategoryId=2,CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>() {
                new Product(){ProductId=1,CategoryId=1,ProductName="Casper Laptop",UnitInStock=25,UnitPrice=5000},
                new Product(){ProductId=2,CategoryId=1,ProductName="Asus Laptop",UnitInStock=5,UnitPrice=8000},
                new Product(){ProductId=3,CategoryId=2,ProductName="Xiaomi Telefon",UnitInStock=250,UnitPrice=13000}
            };

            //Test(products);

            var result1 = GetProductsLinq(products);
            //result1.ForEach(p => Console.WriteLine(p.ProductName));  //GetProductsLinq şartını yazdırdı
            foreach (var item in result1)
            {
                Console.WriteLine(item.ProductName); //GetProductsLinq şartını yazdırdı
            }
            // products.ForEach(p => Console.Write(p.ProductName + ","));  //tüm listeyi yazdırdı

            var result2 = products.Any(p => p.ProductName == "Casper");
            Console.WriteLine(result2);
            //result2.ForEach çıkmıyor
            //result2 = products.GetProductsLinq // gelmiyor


            // alttaki kısımda gelmiyor
            //var result3 = GetProductsLinq(products);
            //result3.Any(p => p.ProductName == "Asus");
            //Console.WriteLine(result3);

            var result3 = products.Find(p => p.ProductId == 2);
            Console.WriteLine("Id'si 2 olan ürün: " + result3.ProductName);

            var result4 = products.FindAll(p => p.ProductName.Contains("top")).OrderBy(p => p.UnitPrice);
            foreach (var product in result4)
            {
                Console.WriteLine(product.ProductName);
            }
            //single line query
            var result5 = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);   //ThenBy a dan zye sıralar
            foreach (var product in result5)
            {
                Console.WriteLine(product.ProductName);  //FindAll ile aynı sonucu yazdırdı ma farkları where IEnumerable döndürür
            }
            Console.WriteLine("-----------------------");

            //başka bir kullanım şekli

            var result6 = from p in products
                          where p.UnitPrice > 3000
                          orderby p.ProductName descending //çalışmıyor
                          select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, UnitPrice = p.UnitPrice };

            foreach (var item in products)
            {
                Console.WriteLine(item.ProductName);
            }
            Console.WriteLine("-----------------------");

            var result7 = from p in products
                          join c in categories
                          on p.CategoryId equals c.CategoryId
                          where p.UnitPrice>5000
                          orderby p.ProductName descending
                          select new ProductDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitPrice = p.UnitPrice };

            foreach (var item in result7)
            {
                Console.WriteLine(item.ProductName + " / " + item.CategoryName);
            }





            Console.ReadLine();
        }

        private static void Test(List<Product> products)
        {
            Console.WriteLine("Algoritmik Linq bilmeden---------------\n");

            foreach (var product in products)
            {
                if (product.UnitPrice >= 5000 && product.UnitInStock > 20)
                {
                    Console.WriteLine(product.ProductName + "\n");
                }
            }

            Console.WriteLine("Linq--------------------\n");

            var result = products.Where(p => p.UnitInStock > 20 && p.UnitPrice >= 5000);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        static List<Product> GetProductsNoLinq(List<Product> prs)
        {
            List<Product> filteredProduct = new List<Product>(); //linq where komutu ile bunu arka plada kendi oluşturuyor
            foreach (var product in prs)
            {
                if (product.UnitPrice >= 5000 && product.UnitInStock > 20)
                {
                    filteredProduct.Add(product);
                }
            }

            return filteredProduct;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.UnitPrice >= 5000 && p.UnitInStock > 20).ToList();
        }

    }
    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

    }

    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
