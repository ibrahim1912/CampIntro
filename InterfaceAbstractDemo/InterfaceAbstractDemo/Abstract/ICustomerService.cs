
using System;
using System.Collections.Generic;
using System.Text;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        //database e kayıt edileceği için save metodu yazdık
        void Save(Customer customer);

    }
}
