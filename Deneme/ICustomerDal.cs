using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal  //veritabanı işlemleri bu dal isminde olur
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added.");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated.");
        }
    }

    class OracleServerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }

}
