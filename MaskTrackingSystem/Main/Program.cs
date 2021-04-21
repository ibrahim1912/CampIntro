using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            //arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "İbraihm";
            ogrenciler[2] = "Efe";

            foreach (var item in ogrenciler)
            {
                Console.WriteLine(item);
            }

            Mylist<int> sasa = new Mylist<int> { };
            Console.WriteLine(sasa.Length);

            List<string> yeniIsimler = new List<string>
            {"Elif","Açelya","Sevgi"};
            yeniIsimler.Add("Osman");
            foreach (var item in yeniIsimler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------------");
            Person person1 = new Person()
            { FirstName="İbrahim",
              LastName= "Kaplan",
              DateOfBirthYear=1991,
              NationalIdentity=44917432622
            };
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            //sistem ptt den eczaneye döndü

        }

        
    }

    class Mylist<T>
    {

        T[] items;
        


       public Mylist()
        {
            items = new T[0];
        }
        public void Ekle(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
        public T[] Items
        {
            get { return items; }
        }
        public int Length
        {
            get { return items.Length; }
        }
    }
}
