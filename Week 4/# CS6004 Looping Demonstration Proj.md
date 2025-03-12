# CS6004 Looping Demonstration Project

## 📖 Project Overview
This project demonstrates different **looping structures** in C#, including:
- **For Loop** → Iterates a fixed number of times.
- **Foreach Loop** → Iterates over collections like arrays or lists.
- **Recursion (Factorial Calculation)** → A function that calls itself.

---

## 🛠️ Setup Instructions
### **1️⃣ Create a New C# Console Application**
1. Open **Visual Studio**.
2. Click **"Create a new project"**.
3. Select **"Console App (.NET 8)"**.
4. **Name it:** `CS6004_Looping_Demo`.
5. Click **Create**.

### **2️⃣ Add Code Files**
Create the following files inside your project:
- `Program.cs` → Handles the **main menu**.
- `ForLoop.cs` → Demonstrates the **for loop**.
- `ForeachLoop.cs` → Demonstrates the **foreach loop**.
- `Recursion.cs` → Demonstrates **recursion (factorial calculation)**.

---

## **📂 Code Files**

### **📄 Program.cs (Main Menu)**
```csharp
using System;

namespace CS6004_Looping_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to C# Looping Demonstration");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. For Loop");
                Console.WriteLine("2. Foreach Loop");
                Console.WriteLine("3. Recursion (Factorial Calculation)");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ForLoop.Run();
                        break;
                    case "2":
                        ForeachLoop.Run();
                        break;
                    case "3":
                        Recursion.Run();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

```

## 🚀 Steps to Run the Program
Save all files inside your Visual Studio project.
Press Ctrl + F5 to run the application.
Select an option from the menu:
1 → Runs the For Loop.
2 → Runs the Foreach Loop.
3 → Calculates Factorial using Recursion.
4 → Exits the program.

## 📖 Project Overview
This project demonstrates different **looping structures** in C#, including:
- **For Loop** → Iterates a fixed number of times.
- **Foreach Loop** → Iterates over collections like arrays or lists.
- **Recursion (Factorial Calculation)** → A function that calls itself.
