using System;
using System.Collections.Generic;

namespace interfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eat = new IEat[2]
            {
                new Manager(),
                new Worker()
                //new Robot() tanımlı değil
            };

        }
    }

    interface IWorker
    {
        void Work();

    }

    interface IEat
    {
        void Eat();
    }
    interface IGetSalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, IGetSalary

    {
        public void Eat()
        {

        }

        public void GetSalary()
        {

        }

        public void Work()
        {

        }
    }


    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {

        }

        public void GetSalary()
        {

        }

        public void Work()
        {

        }
    }

    class Robot : IWorker
    {
        public void Work()
        {

        }
    }

}


