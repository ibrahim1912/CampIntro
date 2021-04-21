using System;
using System.Reflection;

namespace Reflection //ihtiyaç dogdunda çalışma anında yapılır
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());  //2,3 ctordan gelir
            //Console.WriteLine(dortIslem.Topla(3, 4)); //kendimiz verririz

            var tip = typeof(DortIslem); //tipi belirttik

            // Activator.CreateInstance(tip);// obje döndürür // bunu yaptık aslımda DortIslem dortIslem = new DortIslem

            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(tip, 6, 7); // çalışma anında dinamik instance üretiyoruz//cast yaptık
            //Console.WriteLine(dortIslem.Topla(4, 5));
            //Console.WriteLine(dortIslem.Topla2());

            var instance = Activator.CreateInstance(tip, 7, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2"); //tipi belirle.metota ulaş
            Console.WriteLine(methodInfo.Invoke(instance, null)); //invoke ile instance ı çalıştır null=parametresiz
            
            Console.WriteLine("----------------------------------");
           
            var metodlar = tip.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("Metot adı : {0}",info.Name);  // DortIslemin sahip oldugu methodların hepsinin isimleri
                foreach (var parametreinfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}",parametreinfo.Name); //paremetre isimlerine ulaştık
                }
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}",attribute.GetType().Name);
                }
            
            }
            
            Console.ReadLine();
        }
    }

    class DortIslem
    {
        private int _sayi1;
        private int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public DortIslem()
        {

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public int Topla2()
        {
            return _sayi1 + _sayi2;
        }

        [MetodName("Çarpma")]
        public int Carp2()
        {
            return _sayi1 * _sayi2;
        }
    }

    class MetodNameAttribute : Attribute
    {
        

        public MetodNameAttribute(string name)
        {
            
        }
    }
}
