using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //hazır collection hazır liste 
            List<string> liste = new List<string>();  //new lemek bir referans oluştur.Adres ver bana
            Console.WriteLine(liste.Count); //çıktısı sıfır elemanlı. arka planda bir array yönetiyor
            liste.Add("Ahmet"); //
            liste.Add("Salih"); //iki tane eleman ekledik
            foreach (var item in liste)
            {
                Console.WriteLine(item);  
            }
            Console.WriteLine(liste.Count); //iki yazdı

            Console.WriteLine("-------------------------");

            //burda MyList ile kendimiz collection oluşturduk
            Mylist<string> isimler = new Mylist<string>();
            Console.WriteLine(isimler.Length);
            isimler.Add("İbrahim");
            isimler.Add("Efe");
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(isimler.Length);

            Console.WriteLine("------------------------------------");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(25,"İbrahim");
            dictionary.Add(30,"Efe");
            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(dictionary.Count);

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(25, "Ali");
            myDictionary.Add(20, "Veli");
            foreach (var item in myDictionary.Keys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myDictionary.Length);

        }
    }
}
