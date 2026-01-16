# Lab 2: Exception Handling – try + finally (Revised)

## 🎯 Lab Objective
This lab demonstrates that the **`finally` block ALWAYS executes**, even when an exception occurs.

⚠️ **Important:** In ASP.NET Core MVC, you **cannot see output from `finally` in the browser** if an exception is unhandled. Therefore, this lab uses the **debugger** as proof.

---

## 🧠 Key Concept (Read First)

> **`finally` is guaranteed to run, but it is NOT guaranteed to be visible.**

In a web application:
- The browser shows an error page
- The request is aborted
- Output/logs may not appear
- **Only the debugger can prove execution**

---

## Step 1: Create a New ASP.NET Core MVC Project

1. Open **Visual Studio**
2. Click **Create a new project**
3. Select **ASP.NET Core Web App (Model-View-Controller)**
4. Name the project: `ExceptionDemo`
5. Framework: **.NET 7.0**
6. Authentication: **None**

---

## Step 2: Open `HomeController.cs`

Path:
```
Controllers/HomeController.cs
```

---

## Step 3: Add the Try + Finally Example

Add this method **inside `HomeController`**:

```csharp
public IActionResult TryFinallyExample()
{
    string message = "";

    try
    {
        int a = 10;
        int b = 0;
        int result = a / b; // DivideByZeroException
    }
    finally
    {
        message = "FINALLY executed (always runs)";
    }

    return Content(message); // This line will NOT be reached
}
```

---

## 🚨 Important Explanation

- The exception occurs inside `try`
- `finally` **DOES execute**
- The exception is re-thrown
- MVC stops the request
- The browser **cannot display the result**

This is **expected behavior**.

---

## Step 4: 🔍 PROVE `finally` Using the Debugger (Required)

### ✅ This is the ONLY correct way to verify `finally`

1. Click on the line inside `finally`:

```csharp
message = "FINALLY executed (always runs)";
```

2. Press **F9** to add a **breakpoint**
3. Run the application (**F5**)
4. Open the browser and go to:

```
https://localhost:xxxx/Home/TryFinallyExample
```

5. Visual Studio will **pause execution inside `finally`**

📌 **This pause is the proof** that `finally` executed.

---

## ❓ Why You Cannot See Any Output

- `finally` is for **cleanup**, not user output
- Unhandled exceptions abort the request
- The response is replaced by the error page

> Execution happens, visibility does not.

---

## ✅ Lab Conclusion

✔ `finally` ALWAYS executes  
✔ `finally` does NOT handle errors  
✔ `finally` output is NOT visible in the browser  
✔ **Debugger breakpoint is required proof**

---

## 🧪 What’s Next (Lab 3 Preview)

In **Lab 3**, you will use:

```csharp
try + catch + finally
```

So that:
- Errors are handled
- Output is visible
- `finally` still executes

---

## 📌 Key Sentence to Remember

> **If `finally` exists, it will be hit — always.**
