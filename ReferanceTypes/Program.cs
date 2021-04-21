using System;

namespace ReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int,double,decimal,boolen,enum value types
            //değer tipin bulunduğu yer bellekte stack 
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine("sayi1: " + sayi1);

            Console.WriteLine("-------------------------------");

            //array,class,interface  reference types heapte tutuluyor
            int[] sayilar1 = new int[] { 1, 2, 3, 4 };
            int[] sayilar2 = new int[] { 9, 8, 7, 6 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;
            Console.WriteLine(sayilar1[0]);

            Console.WriteLine("-------------------------------");

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "İbrahim";
            person2 = person1;
            person1.FirstName = "Efe";
            Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            Person person3 = customer;
            Console.WriteLine(person3.FirstName);
            customer.CreditCardNumber = "123456789";
            //Console.WriteLine(person3.credit);//CreditCardNumber çıkmıyor
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            Employee employee = new Employee();
            Console.WriteLine("-------------------------------");

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);  //aynı kodu farklı nesneler için çalıştırabiliyorum. //Buraya customer,person123 hepsi gelir
                                                

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //base class:Person
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
