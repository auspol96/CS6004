# CS6004 - C# Conditional Statements Workshop

## 📌 Overview
This project demonstrates **fundamental C# concepts** including:
- ✅ **Understanding the Structure of a C# Program**
- ✅ **If Statements**
- ✅ **If-Else Statements**
- ✅ **Switch Statements**

Students can interact with different **conditional statements** using a simple **menu-driven console application**.

---

## 🛠 Project Structure
```plaintext
CS6004_CSharp_ConditionalStatements/
│── README.md                # Project description
│── Program.cs               # Main menu to call different modules
│── CSharpStructure.cs       # Understanding C# program structure
│── IfStatement.cs           # Demonstrates if statements
│── IfElseStatement.cs       # Demonstrates if-else statements
│── SwitchStatement.cs       # Demonstrates switch case statements
│── .gitignore               # Excludes unnecessary files (bin, obj, etc.)
```

---

## 📖 Understanding the Structure of a C# Program
### **Code Breakdown**
```csharp
using System;
namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
        }
    }
}
```
✅ **`using System;`** - Imports built-in functionality.  
✅ **`namespace Lesson01`** - Groups related classes together.  
✅ **`class Program`** - Defines the program.  
✅ **`static void Main(string[] args)`** - The **entry point** of the program.  
✅ **`Console.WriteLine("Hello, world!");`** - Prints text to the console.

---

## 🚀 Running the Project
1. **Clone the Repository**
   ```sh
   git clone https://github.com/YOUR_USERNAME/CS6004_CSharp_ConditionalStatements.git
   cd CS6004_CSharp_ConditionalStatements
   ```

2. **Open in Visual Studio**
   - Open **Visual Studio 2022**
   - Select **File > Open > Project/Solution**
   - Choose `CS6004_CSharp_ConditionalStatements.sln`

3. **Run the Program**
   - Press `Ctrl + F5` or click **Start** in Visual Studio.
   - Select an option from the menu to explore different C# concepts.

---

## 📤 Uploading Your Work
To push changes to GitHub:
```sh
git add .
git commit -m "Completed C# Conditional Statements Workshop"
git push origin main
```

---

## 🎯 Next Steps
- Modify the **switch-case** to include more operations.
- Extend **if-else logic** with new conditions.
- Implement a **do-while loop** for continuous menu selection.

---

## 🎉 Congratulations!
You've successfully completed the **C# Conditional Statements Workshop**! 🚀
