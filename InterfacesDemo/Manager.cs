using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yönetici yemek yedi.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Yönetici maaşını aldı.");
        }

        public void Work()
        {
            Console.WriteLine("Yönetici çalıştı.");
        }
    }
}
