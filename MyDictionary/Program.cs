using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> myList = new MyList<int, string>();

            Console.WriteLine(myList.Count);

            myList.Add(1, "Ali");
            myList.Add(10, "Ahmet");
            myList.Add(21, "Ayşe");
            myList.Add(15, "Selim");
            myList.Add(16, "Tayyar");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList.Keys[i] + " " + myList.Values[i]);
            }
            Console.WriteLine(myList.Count);


            Console.ReadLine();
        }
    }
}
