using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            //veri tabanına yazma kodu burada olcaktı
            Console.WriteLine("Saved to DB : " + customer.FirstName);
        }
    }
}
