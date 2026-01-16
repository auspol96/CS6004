# Lab 3: Exception Handling – try + catch + finally

## 🎯 Lab Objective
This lab demonstrates **proper exception handling** using `try + catch + finally` so that:

- Errors are handled safely
- The application does NOT crash
- Output is visible in the browser
- `finally` STILL executes

This lab completes what you learned in **Lab 2**.

---

## 🧠 Key Concept (Read First)

> **`catch` handles the error, `finally` always runs.**

Because the exception is handled:
- The request continues
- The browser can show output
- Logs and messages are visible

---

## Step 1: Open the Existing Project

1. Open the **ExceptionDemo** project (from Lab 2)
2. Ensure the project runs correctly

---

## Step 2: Open `HomeController.cs`

Path:
```
Controllers/HomeController.cs
```

---

## Step 3: Add the Try + Catch + Finally Example

Add this method **inside `HomeController`**:

```csharp
public IActionResult TryCatchFinallyExample()
{
    string message = "";

    try
    {
        int a = 10;
        int b = 0;
        int result = a / b; // Exception occurs
        message = "Calculation successful";
    }
    catch (DivideByZeroException)
    {
        message = "Error: Cannot divide by zero";
    }
    finally
    {
        message += " | FINALLY executed";
    }

    return Content(message);
}
```

---

## Step 4: Run the Application

1. Press **F5** to run the app
2. Open the browser and go to:

```
https://localhost:xxxx/Home/TryCatchFinallyExample
```

---

## ✅ Expected Browser Output

```
Error: Cannot divide by zero | FINALLY executed
```

This confirms:
- `catch` handled the error
- `finally` executed
- The app continued running

---

## Step 5: (Optional) Verify with Debugger

1. Place a breakpoint inside `finally`
2. Refresh the page
3. Visual Studio will pause inside `finally`

This is **additional proof**, not required.

---

## 🔍 Why This Works (Compared to Lab 2)

| Lab | Exception Handled? | Browser Output | finally |
|----|------------------|---------------|---------|
| Lab 2 | ❌ No | ❌ No | ✅ Yes (debug only) |
| Lab 3 | ✅ Yes | ✅ Yes | ✅ Yes |

---

## ✅ Lab Conclusion

✔ `catch` prevents application crash  
✔ `finally` ALWAYS executes  
✔ Output is visible because error is handled  
✔ This is the **correct real-world pattern**  

---

## 📌 Key Sentence to Remember

> **Use `catch` to handle errors, use `finally` to clean up.**
