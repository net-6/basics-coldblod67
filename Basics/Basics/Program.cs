using System;
using System.Runtime.InteropServices.ComTypes;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Pb1();
        }

        /// <summary>
        /// 1. Write a method that reads from the console three numbers of type int and prints their sum.
        /// </summary>
        static void Pb1()
        {
            Console.WriteLine("Please enter a number: ");
            string number1 = Console.ReadLine();

            Console.WriteLine("Please enter another number: ");
            string number2 = Console.ReadLine();

            Console.WriteLine("Please enter one more number: ");
            string number3 = Console.ReadLine();

            Console.WriteLine("The numbers you entered are: " +number1 + ", " + number2 + ", " + number3+".");
            Console.WriteLine($"The numbers you entered are: {number1}, {number2}, {number3}.");

        }

        
    }
}
