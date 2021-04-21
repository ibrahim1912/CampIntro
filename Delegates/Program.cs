using System;

namespace Delegates
{
    //elçilik
    public delegate void MyDelegate(); //void döndüren ve parametre almayan operasyonlara delegelik yapıyor
    public delegate void MyDelegate2(string text);

    public delegate int MyDelegate3(int number1, int number2);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            //delege kullanımı //özel bir elçi
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;  //ikinci operasyonu bu şekilde ekliyoruz

            myDelegate -= customerManager.SendMessage; // istenilen operasyonu iptal eder

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;

            Matematik matematik = new Matematik();
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;

            var sonuc = myDelegate3(2, 3); //return tiplerde en son operasyonu alır yani çarpma sonucunu alır
            Console.WriteLine(sonuc);
            myDelegate2("Hi");  //iki operasyonda aynı mesajı gönderdi
            myDelegate(); //bunu yapıca consolda yazar


            Console.ReadLine();
        }
    }

    public class CustomerManager
    {

        public void SendMessage()
        {

            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {

            Console.WriteLine("Be carefull!");
        }
        public void SendMessage2(string message)
        {

            Console.WriteLine(message);
        }

        public void ShowAlert2(string alert)
        {

            Console.WriteLine(alert);
        }
    }

    public class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

    }
}
