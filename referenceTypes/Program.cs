using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, bool, float, enum... value types
            //arrays, classes, interfaces... reference types


            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("Sayı1 = " + sayi1);

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;

            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayilar1 [0] = " + sayilar1[0]);

            //Console.WriteLine();

            Person person1 = new Person();
            Person person2 = new Person();

            person2 = person1;     //Burada değer eşitlemesi değil referans eşitlemesi yapılıyor.
            person1.FirstName = "Derin";

            //Console.WriteLine(person2.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "65489632514";
            Employee employee = new Employee();
            employee.FirstName = "Ahmet";
            Person person3 = customer;

            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);


            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    //base class: Person
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        //Burada hem person hem Employee hem de Customer sınıfından parametre gönderebilirsin!!!
        //Ama Employee ya da Customer olsaydı bunu yapamazdın.
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
