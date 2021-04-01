using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] //stack new ile heap adresi aldı. Her new ile yeni bir adres alır.
            //{
            //    "Engin", "Murat", "Kerem", "Halil"
            //};

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "asf";
            //Console.WriteLine();
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[2]);


            List<string> names2 = new List<string>
            {
                "Engin", "Murat", "Kerem", "Halil"
            };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Ali");
            Console.WriteLine();
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);



            Console.ReadLine();
        }
    }
}
