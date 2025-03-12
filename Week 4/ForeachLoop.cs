# CS6004 - ForeachLoop.cs
using System;

namespace CS6004_Looping_Demo
{
    public class ForeachLoop
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("Demonstrating a Foreach Loop:");
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int i in numbers)
            {
                Console.WriteLine("The value of i = {0}", i);
            }
            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
