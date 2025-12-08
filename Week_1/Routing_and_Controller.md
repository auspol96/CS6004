# 🚦 ASP.NET Core Routing & Controller

## 🔁 What is Routing?

Routing is the process that **maps URLs to actions in your controller**.
It determines how the application responds to a request.

### 🛤️ Default Routing Pattern

```
{controller=Home}/{action=Index}/{id?}
```

- `controller`: Which controller to use (e.g. HomeController)
- `action`: Which method inside the controller (e.g. Index())
- `id`: Optional parameter (e.g. product ID)

## 👨‍✈️ What is a Controller?

A **controller** is a C# class that:
- Inherits from `Controller`
- Contains **action methods** (public methods)
- Handles incoming HTTP requests

```csharp
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
```

## 🔗 Example URL Mapping

| URL                          | Controller      | Action   | id  |
|-----------------------------|------------------|----------|-----|
| `/`                         | HomeController   | Index()  | —   |
| `/home/privacy`             | HomeController   | Privacy()| —   |
| `/products/details/5`       | ProductsController | Details(int id) | 5 |

## 🔍 How Routing Works

1. User types `/products/details/5`
2. ASP.NET Core routes to `ProductsController`, calls `Details(5)`
3. Controller returns a **View** with data (e.g. product info)
4. Browser shows the View as HTML

## 💡 Tip

Make sure your action method names match the routes, or use `[Route]` attribute for custom routes:

```csharp
[Route("hello")]
public IActionResult HelloWorld()
{
    return View();
}
```
