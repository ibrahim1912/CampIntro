using System;
using System.Linq;

namespace EntityFrameworkDemo
{
    class Program 
    {
        static void Main(string[] args)
        {
            //E.F =>> ORM object relational mapping

            //GetAll();
            GetProductsByCategory(1);
        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();
            foreach (var product in northwindContext.Products)   //.Products propertimiz 
            {
                Console.WriteLine(product.ProductName);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            var result = northwindContext.Products.Where(p=>p.CategoryId==categoryId);
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
