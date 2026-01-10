# Structure of a C# Program (Real-Life Analogy)

This document explains the structure of a basic C# program using a **TV, Remote, and Power Button** analogy.  
It is designed for beginners with **no programming background**.

---

## Big Idea (In One Sentence)

> A C# program is like a **TV system** — when you press the **power button**, the TV turns on and shows something on the screen.

---

## The C# Code Example

```csharp
using System;

namespace Lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello, world!");
        }
    }
}
```

---

## Real-Life Analogy Overview

| C# Concept | Real-Life Object |
|-----------|------------------|
| `using System;` | TV brand / electricity provider |
| `namespace` | Your house |
| `class` | The TV |
| `Main()` | Power button |
| `Console.WriteLine()` | The TV screen |
| Program running | Watching TV |

---

## Step-by-Step Explanation

### `using System;` → Electricity  
Provides basic tools needed for the program to run.

### `namespace` → House  
Organizes where the TV (class) lives.

### `class Program` → TV  
The main device that does the work.

### `Main()` → Power Button  
The starting point of the program.

### `Console.WriteLine()` → TV Screen  
Shows output to the user.

---

## One-Line Summary

> A C# program starts from `Main()` and displays output using `Console.WriteLine()`, just like turning on a TV and seeing content on the screen.
