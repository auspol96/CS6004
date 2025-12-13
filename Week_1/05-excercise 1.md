# Asp.Net Core MVC: Hello World Project using ViewBag

This exercise creates a simple ASP.NET Core MVC project that:
- Uses a controller to pass data via `ViewBag`
- Displays the message on a Razor view

---

## ✅ Goal
Display "Hello ASP.NET Core MVC!" on the browser using MVC pattern.

---

## Step-by-Step Instructions

### 1. Create a New Project
- Open **Visual Studio**
- Select: `Create a new project`
- Choose: **ASP.NET Core Web App (Model-View-Controller)**
- Click **Next**
- Name it: `HelloMvcApp`
- Choose `.NET 7` or `.NET 6`
- Click **Create**

---

### 2. Add a Controller

**Location:** `Controllers/InfoController.cs`

```csharp
using Microsoft.AspNetCore.Mvc;

namespace HelloMvcApp.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Hello ASP.NET Core MVC!";
            return View();
        }
    }
}
```

---

### 3. Add a View

**Location:** `Views/Info/Index.cshtml`

> If the folder `Views/Info` doesn’t exist, right-click `Views`, choose `Add > New Folder`, and name it `Info`. Then add a new `Razor View` file called `Index.cshtml`.

```html
@{
    ViewData["Title"] = "Index";
}

<h2>@ViewBag.Message</h2>
```

---

### 4. Update Routing (Optional for .NET 6 or earlier)

In `.NET 6`, your `Startup.cs` or `Program.cs` might already be configured.

If not, make sure `Program.cs` has:

```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Info}/{action=Index}/{id?}");
```

---

### 5. Run the Project
- Press `F5` or click the green **Run** button
- If it doesn't open the `Info/Index` page by default, go to:

```
https://localhost:{port}/Info
```

You should see:

> **Hello ASP.NET Core MVC!**

---

## ✅ Summary
This project helps you:
- Understand MVC structure
- Pass data from controller to view using `ViewBag`
- Create your first custom controller and Razor View
