# CS6004 - Hello World Workshop

## 📌 Introduction
Welcome to the **Hello World Workshop** for **CS6004 Application Development**! In this workshop, students will create their first **C# Console Application** using **Visual Studio** and **.NET 8.0**.

## 🛠️ Prerequisites
Before starting, ensure you have the following installed:
- **Visual Studio 2022** (Community, Professional, or Enterprise)
- **.NET SDK (Latest LTS Version, e.g., .NET 8.0)**
- **Git (Optional, for version control)**

## 📂 Project Structure
```plaintext
CS6004_HelloWorld_Workshop/
│── README.md                # Instructions for students
│── HelloWorldApp/            # Project source code
│   ├── HelloWorldApp.sln     # Visual Studio solution file
│   ├── Program.cs            # C# source code
│   ├── HelloWorldApp.csproj  # Project configuration file
│── .gitignore                # To exclude unnecessary files (bin, obj, etc.)
```

## 🚀 Step 1: Create a New C# Console Application
1. **Open Visual Studio**.
2. Click **"Create a new project"**.
3. Select **"Console App (.NET Core/.NET 8)"** and click **Next**.
4. Set **Project Name** to `HelloWorldApp`.
5. Choose a location to save the project and click **Create**.

## 📝 Step 2: Write the "Hello World" Code
Open **Program.cs** and replace its contents with the following:

```csharp
using System;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Wait for user input before closing
        }
    }
}
```

## ▶️ Step 3: Run the Project
1. Click **"Start"** or press `Ctrl + F5` to run the application.
2. You should see:
   ```plaintext
   Hello, World!
   Press any key to exit...
   ```
3. Press any key to close the console window.

## 📤 Step 4: Upload to GitHub
To upload this project to GitHub:
1. **Initialize Git** (Only if not done before):
   ```sh
   git init
   git add .
   git commit -m "Initial commit - Hello World Project"
   git branch -M main
   git remote add origin https://github.com/YOUR_USERNAME/CS6004_HelloWorld_Workshop.git
   git push -u origin main
   ```
2. **Now, share the GitHub repository link with students.**

## 🎯 Additional Exercises
- Modify the program to ask for the user's name and greet them.
- Add a loop to allow multiple greetings before exiting.

## 🎉 Congratulations!
You've successfully set up your first **C# Console Application**. Happy coding! 🚀
