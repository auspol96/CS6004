
# Final Programming Exam – MVC Exercise (Model Reconstruction)

## Scenario
You are working on an ASP.NET Core MVC project for a small library system. The project already includes:
- A working `BooksController`
- A `Create.cshtml` view to input book details
- A `DbContext` class named `ApplicationDbContext`

However, the models (`Book` and `Category`) are missing and need to be implemented.

---

## 🎯 Objective

Your task is to:
1. Create the `Book` model.
2. Create the `Category` model.
3. Ensure both models are registered correctly in the DbContext.
4. Run the application and test the Create Book form.

---

## 📁 Provided Files

- `Controllers/BooksController.cs`
- `Views/Books/Create.cshtml`
- `Data/ApplicationDbContext.cs`
- `Program.cs` and `Startup.cs` (or `Program.cs` only for minimal hosting model)

---

## ✅ Requirements

### `Book` model should include:
- Id (int, PK)
- Title (string, required)
- Author (string)
- Price (decimal)
- CategoryId (int, FK)

### `Category` model should include:
- Id (int, PK)
- Name (string, required)

Ensure proper data annotations are applied where appropriate.

---

## 🛠 Steps

1. **Create the Models**:
   - Create `Book.cs` and `Category.cs` in the `Models` folder.
   - Add necessary properties with proper data annotations.

2. **Update DbContext**:
   - Register both models inside `ApplicationDbContext.cs` with `DbSet<Book>` and `DbSet<Category>`.

3. **Migrations**:
   - Run Entity Framework Core migration commands:
     ```bash
     dotnet ef migrations add InitLibraryModels
     dotnet ef database update
     ```

4. **Test**:
   - Run the application.
   - Navigate to `/Books/Create` and verify the form works.

---

## 📷 Expected Output

After successful model creation and migration, the `Create` page should allow you to enter book details and save them to the database. The Index view should show a list of books.

---

## Notes

- Use Visual Studio or VS Code.
- Don’t forget to inject the `ApplicationDbContext` via constructor.
- If there are issues, check Startup/Program for DbContext registration.

Good luck!


---

### 📁 Program.cs

```csharp
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace LibraryApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
```

---

### 📁 Startup.cs

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using LibraryApp.Data;

namespace LibraryApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<LibraryContext>(options =>
                options.UseInMemoryDatabase("LibraryDB"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
```

---

### 📁 Controllers/HomeController.cs

```csharp
using Microsoft.AspNetCore.Mvc;
using LibraryApp.Data;

namespace LibraryApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly LibraryContext _context;

        public HomeController(LibraryContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }
    }
}
```

---

### 📁 Views/Home/Index.cshtml

```html
@model IEnumerable<LibraryApp.Models.Book>

<h2>Book List</h2>

<table class="table">
    <thead>
        <tr>
            <th>Title</th>
            <th>Author</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var book in Model)
        {
            <tr>
                <td>@book.Title</td>
                <td>@book.Author</td>
            </tr>
        }
    </tbody>
</table>
```
### 📁 ApplicationDbContext.cs

```csharp
using Microsoft.EntityFrameworkCore;
using YourNamespace.Models;

namespace YourNamespace.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Optional: Fluent API if needed
            // modelBuilder.Entity<Book>()
            //     .HasOne(b => b.Category)
            //     .WithMany(c => c.Books)
            //     .HasForeignKey(b => b.CategoryId);
        }
    }
}
```

