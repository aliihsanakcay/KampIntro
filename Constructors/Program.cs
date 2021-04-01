using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Customer customer1 = new Customer { Id=1, FirstName="Ali", LastName="Akcay", City="Ankara"};
             * bu yukarıdaki ile aşağıdaki yazdığım aynı şeydir.
             * Customer customer1 = new Customer();
             * customer1.Id = 1;
             * customer1.FirstName = "Ali";
             * customer1.LastName = "Akcay";
             * customer1.City = "Ankara";
            */
            Customer customer1 = new Customer { Id = 1, FirstName = "Ali", LastName = "Akcay", City = "Ankara" };
            Customer customer2 = new Customer(2, "Ahmet", "Akcay", "Ankara");

            Console.WriteLine(customer2.LastName);



            Console.ReadLine();
        }
    }


    class Customer
    {
        //Default Constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı.");
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
