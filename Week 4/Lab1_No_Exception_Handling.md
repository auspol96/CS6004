# Lab 1: What Happens Without Exception Handling (No `try-catch`)

## 🎯 Objective
This lab helps students see what happens when an error occurs **without exception handling**.

> Important: In C#, a `try` block **must** be followed by at least one `catch` or a `finally`.

So for the “no handling” case, we **do not use `try` at all**.

---

## Step 1: Create a New ASP.NET Core MVC Project

1. Open **Visual Studio**
2. Click **Create a new project**
3. Select **ASP.NET Core Web App (Model-View-Controller)**
4. Click **Next**
5. Project name: `ExceptionDemo`
6. Click **Next**
7. **Framework: choose .NET 8.0 (LTS)** (recommended)
8. Authentication: **None**
9. Click **Create**

---

## Step 2: Open `HomeController.cs`

1. In **Solution Explorer**, open **Controllers**
2. Open `HomeController.cs`

---

## Step 3: Add an Action That Will Crash (No Handling)

Inside `HomeController`, add this method **below** `Index()`:

```csharp
public IActionResult NoHandlingExample()
{
    int a = 10;
    int b = 0; // will cause an error
    int result = a / b; // DivideByZeroException happens here

    return Content($"Result = {result}");
}
```

---

## Step 4: Run the Application

1. Click **Run** ▶️
2. In the browser, go to:

```
https://localhost:xxxx/Home/NoHandlingExample
```

(Replace `xxxx` with your port number)

---

## ❌ What Will Happen?

- The program will show an **error page**
- The error is: **DivideByZeroException**
- This is because we did not handle the exception

---

## 🧠 Key Learning Point

- Without `try-catch`, an exception can **crash** your request/page.
- Next lab will show how `finally` runs even when there is an error.

➡️ Proceed to **Lab 2: `try` + `finally`**
