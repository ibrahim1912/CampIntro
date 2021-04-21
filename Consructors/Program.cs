using System;

namespace Consructors  //Yapıcı Blok. Class ı ilk kez yapılandırdığınızda çalışan bloktur.
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(){ Id=1,FirstName="İbrahim",LastName="Kaplan",City="İzmir" };
            Customer customer2 = new Customer(2,"Efe","Berber","İzmir");
            /*yukarıdaki ikisinin de olması için
             hem default constructor yaptık(customer1 için) hemde constructoru metot gbi parametreli yaptık(customer2)*/
            //customer1deki yapılan parametre değil
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        //default constructor //parametresi olmayan constructor
        public Customer()
        {

        }

        //overloading yaparak parametre ekledik
        public Customer(int id,string firstName,string lastName,string city)
        {
            //ikinci yapıyı kullanmamız için (customer2 olan) alttaki eşitliği yapmamız lazım
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
