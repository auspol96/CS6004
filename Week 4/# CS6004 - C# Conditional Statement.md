# CS6004 - C# Conditional Statements Project

## 📌 Overview
This project is a **C# console application** that demonstrates fundamental **conditional statements**:
- ✅ **Understanding the Structure of a C# Program**
- ✅ **If Statements**
- ✅ **If-Else Statements**
- ✅ **Switch Statements**

### **1️⃣ Create a New Project in Visual Studio**
1. Open **Visual Studio 2022**.
2. Click **"Create a new project"**.
3. Select **"Console App (.NET 8)"** and click **Next**.
4. Name the project `CS6004_CSharp_ConditionalStatements`.
5. Choose a location to save the project and click **Create**.

### **2️⃣ Add Project Files**
1. **Replace `Program.cs`** with the following code:

```csharp

using System;

namespace CS6004_CSharp_ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to C# Conditional Statements Demo");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Structure of a C# Program");
                Console.WriteLine("2. If Statement");
                Console.WriteLine("3. If-Else Statement");
                Console.WriteLine("4. Switch Statement");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CSharpStructure.Run();
                        break;
                    case "2":
                        IfStatement.Run();
                        break;
                    case "3":
                        IfElseStatement.Run();
                        break;
                    case "4":
                        SwitchStatement.Run();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    // Module 1: Structure of a C# Program
    class CSharpStructure
    {
        public static void Run()
        {
            Console.Clear();
            Console.WriteLine("using System;");
            Console.WriteLine("namespace Lesson01");
            Console.WriteLine("{");
            Console.WriteLine("    class Program");
            Console.WriteLine("    {");
            Console.WriteLine("        static void Main(string[] args)");
            Console.WriteLine("        {");
            Console.WriteLine("            Console.WriteLine(\"hello, world!\");");
            Console.WriteLine("        }");
            Console.WriteLine("    }");
            Console.WriteLine("}");
            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }
    }

    // Module 2: If Statement
    class IfStatement
    {
        public static void Run()
        {
            Console.Clear();
            int number1 = 10, number2 = 20;
            if (number2 > number1)
            {
                Console.WriteLine("number2 is greater than number1");
            }
            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }
    }

    // Module 3: If-Else Statement
    class IfElseStatement
    {
        public static void Run()
        {
            Console.Clear();
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 10)
            {
                Console.WriteLine("n is less than 10");
            }
            else if (n < 20)
            {
                Console.WriteLine("n is less than 20");
            }
            else
            {
                Console.WriteLine("n is greater than or equal to 20");
            }
            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }
    }

    // Module 4: Switch Statement
    class SwitchStatement
    {
        public static void Run()
        {
            Console.Clear();
            Console.Write("Enter first number: ");
            int op1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int op2 = int.Parse(Console.ReadLine());
            Console.Write("Enter operator (+ or -): ");
            char opr = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int result;
            switch (opr)
            {
                case '+':
                    result = op1 + op2;
                    break;
                case '-':
                    result = op1 - op2;
                    break;
                default:
                    Console.WriteLine("Unknown Operator");
                    return;
            }
            Console.WriteLine($"Result: {result}");
            Console.WriteLine("\nPress any key to return to the menu.");
            Console.ReadKey();
        }
    }
}

```
## 🎯 Next Steps
✅ Modify the **switch-case** to add more operators (`*`, `/`).
✅ Experiment with **nested if-else** conditions.
✅ Implement **error handling** (e.g., handling invalid user input).

---

## 🎉 Congratulations!
You've successfully set up and run the **C# Conditional Statements Project**! 🚀

