using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[]
            {
                new Customer{ FirstName = "Ali"},
                new Student{ FirstName  ="Ahmet" },
                new Person{FirstName="Abdullah"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }


            Console.ReadLine();
        }
    }
}
