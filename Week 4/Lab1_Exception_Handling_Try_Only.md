# Lab 1: Exception Handling – Using `try` Only (No Error Handling)

## 🎯 Objective
This lab helps students understand **what happens when an error occurs without proper handling**.  
You will learn that using `try` alone does **not** prevent the program from crashing.

---

## 🧱 Prerequisite
- Basic knowledge of C#
- No prior knowledge of exception handling required

---

## Step 1: Create a New ASP.NET Core MVC Project

1. Open **Visual Studio**
2. Click **Create a new project**
3. Select **ASP.NET Core Web App (Model-View-Controller)**
4. Click **Next**
5. Project name: `ExceptionDemo`
6. Location: choose any folder
7. Click **Next**
8. Framework: **.NET 6 or .NET 7**
9. Authentication: **None**
10. Click **Create**

---

## Step 2: Locate the Controller

1. In **Solution Explorer**, open the **Controllers** folder
2. Open the file: `HomeController.cs`

You will see a class like this:

```csharp
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
```

---

## Step 3: Add a `try`-only Example Method

Inside `HomeController`, add the following method **below** the `Index()` method:

```csharp
public IActionResult TryOnlyExample()
{
    try
    {
        int a = 10;
        int b = 0; // This will cause an error
        int result = a / b;
    }

    return Content("This line will not be reached.");
}
```

---

## Step 4: Run the Application

1. Click **Run** ▶️
2. When the browser opens, change the URL to:

```
https://localhost:xxxx/Home/TryOnlyExample
```

(Replace `xxxx` with your port number)

---

## ❌ What Will Happen?

- The application will **crash**
- You will see a **runtime error page**
- The message will indicate **Divide by zero**

---

## 🧠 Key Learning Point

- `try` **alone** does NOT handle errors
- If an exception occurs and there is **no `catch`**, the program stops

> ✅ This lab shows **why error handling is needed**

---

## ✅ Summary

- `try` only = **no protection**
- Errors still crash the program
- Next lab will show how `finally` behaves

➡️ Proceed to **Lab 2: `try` + `finally`**
