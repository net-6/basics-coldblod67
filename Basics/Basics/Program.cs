using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
                Console.WriteLine(
                    "I can print back the perimeter and the area of a circle if you tell me what it's radius is \n");
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
                Console.WriteLine(
                    "I can tell you how many numbers divisible with 5 are between the two numbers that you'll give me. \n ");

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

        /// <summary>
        /// Write a method that prints on the console the numbers from 1 to N. The number N should be read from the standard input.
        /// </summary>
        static void Problem7()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can count from 1 to a number you give me\n\nPlease imput a number: ");

                int countLimit = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                for (int i = 1; i <= countLimit; i++)
                {
                    Console.WriteLine(i);
                }

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();

            } while (response.ToLower() != "yes");
        }

        /// <summary>
        /// Write a method that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
        /// The number N should be read from the standard input.
        /// </summary>
        static void Problem8()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine(
                    "I can print the numbers that are not divisible by 3 nor by 7 in the range 1 to N.\n\nPlease provide the N value:\n ");

                int countLimit = int.Parse(Console.ReadLine());

                for (var i = 1; i <= countLimit; i++)
                {
                    if (i % 3 != 0 && i % 7 != 0)
                    {
                        Console.WriteLine(i);
                    }

                }

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();

            } while (response.ToLower() != "yes");
        }

        /// <summary>
        /// Write a method that reads from the console a series of 5 integers and prints the smallest and largest of them.
        /// </summary>
        static void Problem9()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can choose the largest and the smallest number out of the numbers you give me.\n");

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
                int smallestNumber = numbers.Min();

                Console.WriteLine("\nThe largest number you've have entered is " + greatestNumber +
                                  ", and the smallest is " + smallestNumber + ".");

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();

            } while (response.ToLower() != "yes");
        }

        /// <summary>
        /// Write method that outputs a triangle made of stars with variable size, depending on an input parameter.
        /// Look at the examples to get an idea.The input comes as a string number, which needs to be parsed to a number.
        /// The output is a series of lines printed on the console, forming a triangle of variable size.
        /// </summary>
        static void Problem10()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine(
                    "I can output a triangle made of stars with variable size, depending on your input.\n\n" +
                    "Please input the size you want the triangle to be:");

                int triangleSize = int.Parse(Console.ReadLine());

                int numberOfRows = triangleSize * 2 - 1;
                int starCount = 1;

                for (int rowNumber = 1; numberOfRows >= rowNumber; rowNumber++)
                {
                    Console.WriteLine();

                    while (starCount <= rowNumber && rowNumber <= triangleSize)
                    {
                        Console.Write(new string('*', starCount));
                        starCount++;
                    }

                    if (starCount == triangleSize + 1)
                    {
                        starCount--;
                    }

                    while (rowNumber > triangleSize && starCount > 0)
                    {
                        starCount--;
                        Console.Write(new string('*', starCount));
                        Console.WriteLine();
                    }
                    //Puteam sa folosesc "new string()" si sa fie mai simplificat dar l-am descoperit la final...
                }

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();

            } while (response.ToLower() != "yes");
        }

        /// <summary>
        /// Write a method that converts a given number from decimal to binary notation (numeral system).
        /// </summary>

        static void Problem11()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine(
                    "I can convert a decimal number you give me into a binary number.\n\n" +
                    "Please input the the decimal number:");

                int decimalNumber = int.Parse(Console.ReadLine());
                string binaryNumber = Convert.ToString(decimalNumber, 2);

                Console.WriteLine($"\n\nAfter complex calculations and hard work, I have converted {decimalNumber} into {binaryNumber}. ");

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();

            } while (response.ToLower() != "yes");
        }

        /// <summary>
        ///  Write a method that by a given integer N prints the numbers from 1 to N in random order
        /// </summary>
        static void Problem12()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine(
                    "I can print randomly the numbers from 1 to N.\n\n" +
                    "Please input the value of N:");

                int N = int.Parse(Console.ReadLine());

                IEnumerable<int> UniqueRandom(int minInclusive, int maxInclusive)
                {
                    List<int> numbers = new List<int>();
                    for (int i = minInclusive; i <= maxInclusive; i++)
                    {
                        numbers.Add(i);
                    }

                    Random rng = new Random();
                    while (numbers.Count > 0)
                    {
                        int index = rng.Next(numbers.Count);
                        yield return numbers[index];
                        numbers.RemoveAt(index);
                    }
                }

                Console.WriteLine($"\n\nThese are all the numbers between 0 and {N} in a random order:");
                foreach (int i in UniqueRandom(0, N))
                {
                    Console.WriteLine(i);
                }

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();
            } while (response.ToLower() != "yes");
        }

        /// <summary>
        /// A method which iterates the integers from 1 to 50
        /// For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz".
        /// For numbers which are multiples of both three and five print "FizzBuzz".
        /// </summary>
        static void Problem13()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("I can print the numbers from 1 to 50. \nFor multiples of three I will print "+"Fizz"+" instead of the number and for the multiples of five I will print "+"Buzz"+"." +
                    " \nFor numbers which are multiples of both three and five I will print "+"FizzBuzz"+"\n\n");

                for (var i = 1; i <= 50; i++)
                {
                    
                    if (i % 3 != 0 && i % 5 != 0)
                    {
                        Console.WriteLine(i);
                    }

                    if (i % 3 == 0)
                    {
                        if ( i % 5 == 0)
                        {
                            Console.WriteLine("FizzBuzz");
                        }
                        else
                        {
                            Console.WriteLine("Fizz");
                        }
                    }

                    if (i % 5 == 0 && i % 3 != 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                }

                Console.Write("\n\n\nDo you want to exit? Yes/No: ");
                response = Console.ReadLine();

            } while (response.ToLower() != "yes");
        }

        /// <summary>
        /// A given company has name, address, phone number, fax number, web site and manager.
        /// The manager has name, surname and phone number. Write a program that reads information about the company and its manager
        /// and then prints it on the console.
        /// </summary>
        static void Problem14()
        {
            string response = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Please fill this form in order to register a company:\n\n");
                Console.WriteLine("Name:");
                string companyName = Console.ReadLine();
                Console.WriteLine("Address:");
                string companyAddress = Console.ReadLine();
                Console.WriteLine("Phone number:");
                string companyPhoneNumber = Console.ReadLine();
                Console.WriteLine("Fax number:");
                string companyFaxNumber = Console.ReadLine();
                Console.WriteLine("Web site:");
                string companyWebSite = Console.ReadLine();
                Console.WriteLine("Manager:");
                string companyManager = Console.ReadLine();

                Console.Clear();
                Console.WriteLine("Please fill this form in order to register the company's manager:\n\n");
                Console.WriteLine("Name:");
                string managerName = Console.ReadLine();
                Console.WriteLine("Surnamename:");
                string managerSurname = Console.ReadLine();
                Console.WriteLine("Phone number:");
                string managerPhoneNumber = Console.ReadLine();

                Console.Clear();
                Console.WriteLine($"You have just registered a new company named {companyName}. \nThe address for this company is {companyAddress}." +
                                  $" \nFor contact you can call at {companyPhoneNumber}, or send a fax at {companyFaxNumber}. \nFeel free to acces the company's website at {companyWebSite}." +
                                  $"\n\nThe manager of this company is {managerName} {managerSurname}. \nYou can call the manager at {managerPhoneNumber}");

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
                    "\n\n\n\t\t1\tProblem1\n\t\t2\tProblem2\n\t\t3\tProblem3\n\t\t4\tProblem4\n\t\t5\tProblem5\n\t\t6\tProblem6\n\t\t7\tProblem7\n\t\t8\tProblem8\n\t\t" +
                    "9\tProblem9\n\t\t10\tProblem10\n\t\t11\tProblem11\n\t\t12\tProblem12\n\t\t13\tProblem13\n\t\t14\tProblem14\n\n\t\tQ\t Quit\n\n\n");

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
                    case "7":
                        Problem7();
                        break;
                    case "8":
                        Problem8();
                        break;
                    case "9":
                        Problem9();
                        break;
                    case "11":
                        Problem11();
                        break;
                    case "12":
                        Problem12();
                        break;
                    case "13":
                        Problem13();
                        break;
                    case "14":
                        Problem14();
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