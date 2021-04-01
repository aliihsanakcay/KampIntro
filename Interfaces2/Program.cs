using System;

namespace Interfaces2
{
    class Program
    {
        //interface new'lenemez.
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());



            Console.ReadLine();
        }
    }

    interface IPersonManager
    {
        //Unimplemented operation
        void Add();
        void Update();
    }

    //inherits - class ---------------- implements interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri ekleme metotları
            Console.WriteLine("Müşteri eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel ekleme metodları
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajer eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Stajer güncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager person)
        {
            person.Add();
        }

        public void Update(IPersonManager person)
        {
            person.Update();
        }
    }
}
