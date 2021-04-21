using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{  
    class Mylist<T>
    {
        //(collection)generic)list arkada bir array tutuyor.Bir array yönetiyor.
        
        T[] items; // örnek array oluşturmak isteseydik string[] items;
                   // sıfır elemanlı olsa bile new lemem lazım

        //ctor constructor
        public Mylist() //bir class ı new lersek burası otomatikman çalışıyor.Başlangıçta çalışıyor yani.
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  //öncekiler kaybolmasın diye geçiçi arraya atadık
            items = new T[items.Length+1];  //eleman sayısının 1 fazlasını oluşturduk oraya add ile yeni elemanı eklicez
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  //burda geçiçi arrayın içindekileri tek tek yeni oluşturduğumuz arraya atıyoruz
            }
            items[items.Length - 1] = item; //add ile eklediğimiz elemanı burda en sona sonunda ekliyoruz.Eksi birin sebebi index sıfırdan başlıyor
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}

