using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Basics
{
    class Program
    {
        
        /// <summary>
        /// Write a method that reads from the console three numbers of type int and prints their sum.
        /// </summary>
        static void Problem1()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can add any three whole numbers you give me.\n");

                Console.WriteLine("Please enter the first a number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the third number: ");
                int number3 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nThe sum of the numbers you have just entered is " + (number1 + number2 + number3) +
                                  ".");

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();
            } while (response.ToLower() != "yes");
        }
        /// <summary>
        /// Write a method that reads five numbers from the console and prints the greatest of them.
        /// </summary>
        static void Problem2()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can choose the greatest number out of the numbers you give me.\n");

                Console.WriteLine("Please enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the third number: ");
                int number3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the forth number: ");
                int number4 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the fifth number: ");
                int number5 = int.Parse(Console.ReadLine());

                int[] numbers = new[] {number1, number2, number3, number4, number5};
                int greatestNumber = numbers.Max();
                Console.WriteLine("The greatest number you have entered is " + greatestNumber);

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();
            } while (response.ToLower() != "yes");

        }

        /// <summary>
        /// Write a method that reads from the console the radius "r" of a circle and prints its perimeter and area.
        /// </summary>
        static void Problem3()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can print back the perimeter and the area of a circle if you tell me what it's radius is \n");
                Console.WriteLine("Please enter the radius of the circle: ");
                int radius = int.Parse(Console.ReadLine());

                double perimeter = 2 * Math.PI * radius;
                double area = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine("\nThe perimeter of the circle that has its radius equal to " + radius + " is " +
                                  Math.Round(perimeter, 2) + " and its area is " + Math.Round(area, 2) + ".");

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();
            } while (response.ToLower() != "yes");
        }
        /// <summary>
        /// Write a method that reads from the console two integer numbers (int)
        /// and prints how many numbers between them exist that are divisible with 5.
        /// such that the remainder of their division by 5 is 0.
        /// </summary>
        static void Problem4()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can tell you how many numbers divisible with 5 are between the two numbers that you'll give me. \n ");

                Console.WriteLine("Please enter the first number: ");
                int lowerLimit = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                int upperLimit = int.Parse(Console.ReadLine());


                List<int> numbersDivisibleByFive = new List<int>();
                int numberToCheck = lowerLimit;

                while (numberToCheck >= lowerLimit && numberToCheck <= upperLimit)
                {
                    int remainder;
                    int division = Math.DivRem(numberToCheck, 5, out remainder);


                    if (remainder == 0)
                    {
                        numbersDivisibleByFive.Add(numberToCheck);
                    }

                    numberToCheck++;
                }

                string divisibleNumbers = string.Join(", ", numbersDivisibleByFive.ToArray());
                //I used a list because I did not know what the array size may be, the range of numbers being variable.

                Console.WriteLine("\nIn the range (" + lowerLimit + ", " + upperLimit
                                  + ") there are " + numbersDivisibleByFive.Count
                                  + " numbers that are divisible with 5. "
                                  + "They are the following: " + divisibleNumbers + ".");

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();
            } while (response.ToLower() != "yes");

        }

        /// <summary>
        /// Write a method that reads two numbers from the console and prints the greater of them.
        /// Solve the problem without using conditional statements and with conditional statements.
        /// </summary>

        static void Problem5Selector()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Please input the number corresponding to the method you want to call. " +
                                  "\n\n\n\t1\tProblem5WithoutUsingConditional\n\t1\tProblem5UsingConditional\n\n\tQ\tGo back to Main Menu\n\n\n");
                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Problem5WithoutUsingConditional();
                        break;
                    case "2":
                        Problem5UsingConditional();
                        break;
                    case "q":
                        Console.WriteLine("\n Quitting");
                        break;
                    default:
                        Console.WriteLine("Not a valid method. Please press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            } while (response.ToLower() != "q");
        }
        static void Problem5WithoutUsingConditional()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can tell you which of the two numbers you enter is the greatest.\n");

                Console.WriteLine("Please enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());


                int[] numbers = new[] {number1, number2};
                int greatestNumber = numbers.Max();
                Console.WriteLine("The greatest number you've have entered is " + greatestNumber);

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();
            } while (response.ToLower() != "yes");
        }

        static void Problem5UsingConditional()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can tell you which of the two numbers you enter is the greatest.\n");

                Console.WriteLine("Please enter the first number: ");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the second number: ");
                int number2 = int.Parse(Console.ReadLine());


                if (number1 > number2)
                {
                    Console.WriteLine("\nThe greatest number you've have entered is " + number1);
                }
                else
                {
                    Console.WriteLine("\nThe greatest number you've have entered is " + number2);
                }

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();
            } while (response.ToLower() != "yes");
        }

    

        /// <summary>
        /// Write a method that reads five integer numbers and prints their sum.
        /// If an invalid number is entered the method should prompt the user to enter another number(only once)
        /// </summary>
        static void Problem6()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can add any five whole numbers you give me.\n");
                Console.WriteLine("Please enter the first number: ");

                bool succesfullParse = true; //If any of the five numbers is not parsed successfully after two tries,
                //the console will output an error message.

                int number1;
                bool parsedNumber1 = int.TryParse(Console.ReadLine(), out number1);
                if (!parsedNumber1)
                {
                    Console.WriteLine("Please enter a valid number.");
                    bool parsedSecondTryNumber1 = int.TryParse(Console.ReadLine(), out number1);
                    if (!parsedSecondTryNumber1)
                    {
                        succesfullParse = false;
                    }
                }


                Console.WriteLine("Please enter the second number: ");
                int number2;
                bool parsedNumber2 = int.TryParse(Console.ReadLine(), out number2);
                if (!parsedNumber2)
                {
                    Console.WriteLine("Please enter a valid number.");
                    bool parsedSecondTryNumber2 = int.TryParse(Console.ReadLine(), out number2);
                    if (!parsedSecondTryNumber2)
                    {
                        succesfullParse = false;
                    }
                }

                Console.WriteLine("Please enter the third number: ");
                int number3;
                bool parsedNumber3 = int.TryParse(Console.ReadLine(), out number3);
                if (!parsedNumber3)
                {
                    Console.WriteLine("Please enter a valid number.");
                    bool parsedSecondTryNumber3 = int.TryParse(Console.ReadLine(), out number3);
                    if (!parsedSecondTryNumber3)
                    {
                        succesfullParse = false;
                    }
                }

                Console.WriteLine("Please enter the forth number: ");
                int number4;
                bool parsedNumber4 = int.TryParse(Console.ReadLine(), out number4);
                if (!parsedNumber4)
                {
                    Console.WriteLine("Please enter a valid number.");
                    bool parsedSecondTryNumber4 = int.TryParse(Console.ReadLine(), out number4);
                    if (!parsedSecondTryNumber4)
                    {
                        succesfullParse = false;
                    }
                }

                Console.WriteLine("Please enter the fifth number: ");
                int number5;
                bool parsedNumber5 = int.TryParse(Console.ReadLine(), out number5);
                if (!parsedNumber5)
                {
                    Console.WriteLine("Please enter a valid number.");
                    bool parsedSecondTryNumber5 = int.TryParse(Console.ReadLine(), out number5);
                    if (!parsedSecondTryNumber5)
                    {
                        succesfullParse = false;
                    }
                }

                int sum = number1 + number2 + number3 + number4 + number5;

                if (succesfullParse)
                {
                    Console.WriteLine("\nThe sum of the numbers you've entered is " + sum + ".");
                }
                else
                {
                    Console.WriteLine("\nERROR: One of the numbers you've entered was not a valid number.");
                }

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();
            } while (response.ToLower() != "yes");
        }
        
        static void Main(string[] args)
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\tMAIN MENU\n\nFor the moment there are 6 out of 14 methods available for use. " +
                                  "\nPlease input the number corresponding to the method you want to call.");

                Console.WriteLine(
                    "\n\n\n\t1\tProblem1\n\t2\tProblem2\n\t3\tProblem3\n\t4\tProblem4\n\t5\tProblem5\n\t6\tProblem6\n\n\tQ\t Quit\n\n\n");

                response = Console.ReadLine();
                switch (response)
                {
                    case "1":
                        Problem1();
                        break;
                    case "2":
                        Problem2();
                        break;
                    case "3":
                        Problem3();
                        break;
                    case "4":
                        Problem4();
                        break;
                    case "5":
                        Problem5Selector();
                        break;
                    case "6":
                        Problem6();
                        break;
                    case "q":
                        Console.WriteLine("\n Quitting");
                        break;
                    default:
                        Console.WriteLine("Not a valid method. Please press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            } while (response.ToLower() != "q");

            

        }

    }
}
