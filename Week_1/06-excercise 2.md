# Exercise 2: Display Your Favourite Quote Using ViewBag

## Objective
Create an ASP.NET Core MVC application that displays your favourite quote using ViewBag. This exercise helps you practice passing data from a controller to a view.

---

## Step-by-Step Instructions

### 1. Create a New ASP.NET Core MVC Project
```bash
File > New > Project > ASP.NET Core Web App (Model-View-Controller)
Name the project: QuoteApp
```

---

### 2. Add a New Controller
1. Right-click on the **Controllers** folder > Add > Controller.
2. Select **MVC Controller - Empty** and name it `QuoteController.cs`

```csharp
using Microsoft.AspNetCore.Mvc;

namespace QuoteApp.Controllers
{
    public class QuoteController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.MyQuote = "The only way to do great work is to love what you do. - Steve Jobs";
            return View();
        }
    }
}
```

---

### 3. Add a View for the Quote
1. Right-click on `Index` method > Add View
2. View Name: `Index` (leave everything else default and click Add)

```html
@{
    ViewData["Title"] = "My Favourite Quote";
}

<h2>@ViewData["Title"]</h2>
<p>@ViewBag.MyQuote</p>
```

---

### 4. Update Routing (Optional)
In `launchSettings.json`, change the launch URL to:
```json
"launchUrl": "Quote"
```
Or navigate manually to `/Quote` in your browser.

---

## Expected Output
When the application runs and navigates to `/Quote`, you should see:

```
My Favourite Quote
The only way to do great work is to love what you do. - Steve Jobs
```

---

✅ Done! You have now created an MVC project that uses ViewBag to display a quote.

---

### Next Suggestions
- Let students change the quote to their own
- Add another method to return multiple quotes using ViewData or a model
