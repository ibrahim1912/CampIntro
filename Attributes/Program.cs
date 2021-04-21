using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, LastName = "Kaplan", Age = 29 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();

        }
    }

    [ToTable("Customers")]
    [ToTable("TblCustomers")]
    class Customer
    {
        public int Id { get; set; }

        [RequiredProperty]
        public string FirstName { get; set; }

        [RequiredProperty]
        public string LastName { get; set; }

        [RequiredProperty]
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("dont use Add,instead use AddNew Method")]
        //Hazır attribute diyoruz ki kullanıcıya: yeni add methodu yazdık onu kullanın

        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }


    }
    //hazır // böyle yapsaydık sadece classlar alltaki attribute kullanırdı ama biz propda kullanıyoruz[AttributeUsage(AttributeTargets.Class)] 
    [AttributeUsage(AttributeTargets.Property /* pipe eklemek için| AttributeTargets.Field*/)]
    class RequiredPropertyAttribute : Attribute
    {
        

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]  //multiple birden fazla kullanm demek
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }


}
