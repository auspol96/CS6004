# Lab 2: Exception Handling – Using `try` + `finally`

## 🎯 Objective
This lab helps students understand that the **`finally` block always executes**, even when an error occurs.

In this lab:
- An error will still happen
- The program will still fail
- But `finally` will **always run**

---

## 🧱 Prerequisite
- Completion of **Lab 1: No Exception Handling**
- Basic understanding of Controllers and Actions

---

## Step 1: Open the Existing Project

1. Open **Visual Studio**
2. Open the project: `ExceptionDemo`
3. Make sure the project runs correctly

---

## Step 2: Open `HomeController.cs`

1. In **Solution Explorer**, open **Controllers**
2. Open the file: `HomeController.cs`

---

## Step 3: Add `try + finally` Example Method

Add the following method **below** `NoHandlingExample()`:

```csharp
public IActionResult TryFinallyExample()
{
    try
    {
        int a = 10;
        int b = 0; // will cause an error
        int result = a / b;
    }
    finally
    {
        // This code ALWAYS runs
        Console.WriteLine("Finally block executed");
    }

    return Content("This line will not be reached.");
}
```

---

## Step 4: Run the Application

1. Click **Run** ▶️
2. Open the browser and go to:

```
https://localhost:xxxx/Home/TryFinallyExample
```

(Replace `xxxx` with your port number)

---

## ❌ What Will Happen?

- The page will still show an **error**
- Error: **DivideByZeroException**
- BUT the `finally` block **still runs**

You can confirm this by checking the **Visual Studio Output / Console window**.

---

## 🧠 Key Learning Points

- `finally` always executes
- `finally` runs even when an exception occurs
- `finally` does NOT handle the error
- The program still crashes

---

## ❓ Common Student Question

**Q: Why does the program still crash?**  
A: Because there is **no `catch` block** to handle the exception.

---

## ✅ Summary

- `try` → code that may fail
- `finally` → always runs
- Error is **not handled yet**

➡️ Proceed to **Lab 3: `try + catch + finally`**
