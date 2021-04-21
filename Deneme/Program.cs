using System;
using System.Linq;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParamKullanmı();
            Console.WriteLine("-------------------------------------------------");
            //InterfacesIntro();
            Console.WriteLine("-------------------------------------------------");
            //InterfaceDemo();
            Console.WriteLine("-------------------------------------------------");

            ICustomerDal[] customerDals = new ICustomerDal[2]  //yeni bir veritabanı eklemek istersek (MySql) ICustomerDal.cs ine class ekleriz
            {                                                  // sonra buraya gelip 3 yapıp new olarak ekleriz.
                new SqlServerDal(),
                new OracleServerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void InterfaceDemo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerDal());
        }

        private static void ParamKullanmı()
        {
            var result = Topla(7, 8);
            Console.WriteLine("Toplama işleminin sonucu : " + result);
        }

        private static void InterfacesIntro()
        {
            PersonManager person1 = new PersonManager();
            person1.Add(new Customer { Id = 1, FirstName = "İbrahim", LastName = "Kaplan", Address = "İzmir" });
            PersonManager person2 = new PersonManager();
            person1.Add(new Student { Id = 2, FirstName = "Efe", LastName = "Berber", Department = "B.M" });
        }

        static int Topla(params int[] numbers)
        {
            return numbers.Sum();
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }


    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {

        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }



}


