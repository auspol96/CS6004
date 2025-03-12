# CS6004 - ForLoop.cs
using System;

namespace CS6004_Looping_Demo
{
    public class ForLoop
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("Demonstrating a For Loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("The value of i = {0}", i);
            }
            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }
    }
}
