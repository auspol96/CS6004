# CS6004 - Recursion.cs
using System;

namespace CS6004_Looping_Demo
{
    public class Recursion
    {
        public static void Run()
        {
            Console.Clear();
            Console.Write("Enter a number to calculate factorial: ");
            int n;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("Factorial is not defined for negative numbers. Try again.");
                        continue;
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a valid number.");
                }
            }

            Console.WriteLine($"Factorial of {n} is: {Factorial(n)}");
            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }

        public static int Factorial(int n)
        {
            if (n == 0) 
                return 1;
            else 
                return n * Factorial(n - 1);
        }
    }
}
