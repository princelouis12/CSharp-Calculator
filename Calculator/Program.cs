// See https://aka.ms/new-console-template for more information
/*
 * Console Application that handle Arthmetic Operations
 */
using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2, result;
            char option;
            bool continueCalculations = true;

            while (continueCalculations)
            {
                Console.Write("Enter the First Number: ");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the Second Number: ");
                Num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Main Menu");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("0. Exit");
                Console.Write("Enter the Operation you want to perform: ");
                option = Convert.ToChar(Console.ReadLine());

                switch (option)
                {
                    case '1':
                        result = Num1 + Num2;
                        Console.WriteLine("The result of Addition is: {0}", result);
                        break;
                    case '2':
                        result = Num1 - Num2;
                        Console.WriteLine("The result of Subtraction is: {0}", result);
                        break;
                    case '3':
                        result = Num1 * Num2;
                        Console.WriteLine("The result of Multiplication is: {0}", result);
                        break;
                    case '4':
                        if (Num2 != 0)
                        {
                            result = Num1 / Num2;
                            Console.WriteLine("The result of Division is: {0}", result);
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero.");
                        }
                        break;
                    case '0':
                        continueCalculations = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

                if (continueCalculations)
                {
                    Console.Write("Enter 1 to continue using the calculator, 0 to exit: ");
                    continueCalculations = (Console.ReadLine() == "1");
                }
            }

            Console.WriteLine("Calculator exited. Press Enter to close the application.");
            Console.ReadLine();
        }
    }
}
