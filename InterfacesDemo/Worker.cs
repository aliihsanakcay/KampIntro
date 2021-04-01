using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("İşçi yemek yedi.");
        }

        public void GetSalary()
        {
            Console.WriteLine("İşçi maaşını aldı.");
        }

        public void Work()
        {
            Console.WriteLine("İşçi çalıştı.");
        }
    }
}
