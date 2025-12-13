
# ASP.NET Core MVC Exercise 3: Display Multiple Quotes Using a List

## 🎯 Objective
Learn how to pass a list of values from a Controller to a View using ViewBag or a strongly-typed model.

---

## 🧱 Project Setup

1. Create a new ASP.NET Core MVC project in Visual Studio (if not already done):
   - File > New > Project > ASP.NET Core Web App (Model-View-Controller)

2. Add a new Controller:
   - Right-click on `Controllers` folder → Add → Controller → Empty → Name it `QuoteController.cs`

3. Add a new View:
   - Right-click on `Views` folder → Add → New Folder → Name it `Quote`
   - Right-click on `Quote` folder → Add → Razor View → Name it `Index.cshtml`

---

## 🧑‍💻 Controller Code (QuoteController.cs)

```
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAppHelloWorld.Controllers
{
    public class QuoteController : Controller
    {
        public IActionResult Index()
        {
            List<string> quotes = new List<string>
            {
                "The journey of a thousand miles begins with one step.",
                "Success is not final, failure is not fatal: it is the courage to continue that counts.",
                "In the middle of difficulty lies opportunity."
            };

            ViewBag.Quotes = quotes;

            return View();
        }
    }
}
```

---

## 🖥 View Code (Index.cshtml)

```
@{
    ViewData["Title"] = "Quote List";
}

<h2>@ViewData["Title"]</h2>

<ul>
    @foreach (var quote in ViewBag.Quotes)
    {
        <li>@quote</li>
    }
</ul>
```

---

## ✅ Expected Output

When visiting `https://localhost:xxxx/Quote`, you should see:

```
Quote List

• The journey of a thousand miles begins with one step.
• Success is not final, failure is not fatal: it is the courage to continue that counts.
• In the middle of difficulty lies opportunity.
```

---

## 🧠 Summary

In this exercise, you’ve learned:
- How to store a list in a controller
- How to pass a list to a view using `ViewBag`
- How to iterate and display items with `foreach` in Razor syntax

---

✅ You’re now ready for Exercise 4: Using a strongly-typed model to bind and display more complex data.
