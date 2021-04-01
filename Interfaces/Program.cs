using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro1();
            //Intro2();

            ICustomerDal[] customerDals = new ICustomerDal[] { new SqlServerCustomerDal(), new OracleCustomerDal(), new MysqlCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Update();
            }

            Console.ReadLine();
        }

        private static void Intro2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void Intro1()
        {
            PersonManager personManager = new PersonManager();
            Student student1 = new Student { Id = 1, FirstName = "Ahmet", LastName = "Akçay", Department = "Bilgisayar Mühendisliği" };

            personManager.Add(new Customer { Id = 1, FirstName = "Ali", LastName = "Akçay", Address = "Ankara" });
            personManager.Add(student1);
        }
    }
}
