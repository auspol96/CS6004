# CS6004 - C# Fundamentals Workshop

## 📌 Introduction
This workshop builds on the previous **"Hello World"** project and introduces key **C# programming fundamentals**, including:
✅ **Decision Structures** (`if`, `if-else`, `switch`)
✅ **Repetition Structures** (`while`, `do-while`, `for`, `foreach`)
✅ **Exception Handling** (`try-catch-finally`)

## 🛠️ Prerequisites
Before starting, ensure you have the following installed:
- **Visual Studio 2022** (Community, Professional, or Enterprise)
- **.NET SDK (Latest LTS Version, e.g., .NET 8.0)**
- **Git (Optional, for version control)**

## 📂 Project Structure
```plaintext
CS6004_CSharpFundamentals/
│── README.md                # Instructions for students
│── CSharpFundamentals/       # Project source code
│   ├── CSharpFundamentals.sln # Visual Studio solution file
│   ├── Program.cs            # C# source code
│   ├── CSharpFundamentals.csproj  # Project configuration file
│── .gitignore                # To exclude unnecessary files (bin, obj, etc.)
```

## 🚀 Step 1: Create a New C# Console Application
1. **Open Visual Studio**.
2. Click **"Create a new project"**.
3. Select **"Console App (.NET Core/.NET 8)"** and click **Next**.
4. Set **Project Name** to `CSharpFundamentals`.
5. Choose a location to save the project and click **Create**.

## 📝 Step 2: Write the Code
Open **Program.cs** and replace its contents with the following:

```csharp
using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to C# Fundamentals Explorer!");
            
            try
            {
                // User Input Example
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                // Decision Structure: if-else
                if (num % 2 == 0)
                {
                    Console.WriteLine($"{num} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{num} is an odd number.");
                }

                // Decision Structure: switch-case
                Console.Write("Enter a grade (A, B, C, D, F): ");
                char grade = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                switch (grade)
                {
                    case 'A':
                        Console.WriteLine("Excellent!");
                        break;
                    case 'B':
                        Console.WriteLine("Good job!");
                        break;
                    case 'C':
                        Console.WriteLine("You passed.");
                        break;
                    case 'D':
                        Console.WriteLine("You should work harder.");
                        break;
                    case 'F':
                        Console.WriteLine("You failed.");
                        break;
                    default:
                        Console.WriteLine("Invalid grade input.");
                        break;
                }

                // Loop: for loop
                Console.WriteLine("\nCounting from 1 to 5 using for loop:");
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Number: {i}");
                }

                // Loop: while loop
                Console.WriteLine("\nUsing while loop to decrement from 5 to 1:");
                int count = 5;
                while (count > 0)
                {
                    Console.WriteLine($"Countdown: {count}");
                    count--;
                }

                // Loop: foreach loop with array
                string[] colors = { "Red", "Green", "Blue" };
                Console.WriteLine("\nColors using foreach loop:");
                foreach (string color in colors)
                {
                    Console.WriteLine($"- {color}");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: Invalid input. {ex.Message}");
            }
            finally
            {
                Console.WriteLine("\nEnd of program. Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
```

## ▶️ Step 3: Run the Project
1. Click **"Start"** (`Ctrl + F5`).
2. **Test different inputs** to see how the program reacts.

## 📤 Step 4: Upload to GitHub
To upload this project to GitHub:
```sh
git init
git add .
git commit -m "Added CSharpFundamentals project"
git branch -M main
git remote add origin https://github.com/YOUR_USERNAME/CS6004_CSharpFundamentals.git
git push -u origin main
```

## 🎯 Additional Exercises
- Modify the `switch-case` structure to **add more grade levels**.
- Change the `for loop` to count **from 1 to 10**.
- Add an **additional loop** (e.g., `do-while`).

## 🎉 Congratulations!
You've successfully set up your first **C# Console Application** with decision structures, loops, and exception handling. Happy coding! 🚀
