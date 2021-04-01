using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //SOLID => Interface Segregation

            IWorker[] workers = new IWorker[]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };


            foreach (var worker in workers)
            {
                worker.Work();
            }


            IEat[] eats = new IEat[]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }


            ISalary[] salaries = new ISalary[]
            {
                new Manager(),
                new Worker()
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
        }
    }
}
