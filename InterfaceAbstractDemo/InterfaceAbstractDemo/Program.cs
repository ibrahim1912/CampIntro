using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using System;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() 
            {
                FirstName="İbrahim",
                LastName="Kaplan",
                DateOfBirth = 1992,
                NationalityId="44917432622"
            };


            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServerAdapter());
            customerManager.Save(customer1);
            //BaseCustomerManager customerManager1 = new StarbucksCustomerManager(new CustomerCheckManager());
            //customerManager1.Save(customer1);
            Console.ReadLine();
            






        }
    }
}
