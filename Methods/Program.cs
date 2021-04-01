﻿using System.Linq;
using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();

            //var result = Add2(23, 4);

            //int number1=20;
            //int number2 = 100;
            //int result2 = Add3(out number1, number2);
            //Console.WriteLine(result2);
            //Console.WriteLine(number1);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply2(2, 4, 5));

            Console.WriteLine(Add4(1, 2, 2, 3, 5, 2));
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1 = 20, int number2 = 30)
        {
            int result = number1 + number2;
            return result;
        }
        static int Add3(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply2(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number, params int[] numbers)
        {
            return number + numbers.Sum();
        }
    }
}
