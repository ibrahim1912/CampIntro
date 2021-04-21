using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        //dependency injecton
        private ICustomerCheckService _customerCheckService;
        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {

            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer); //vritabanına kaydeden kod
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }


    }
}
