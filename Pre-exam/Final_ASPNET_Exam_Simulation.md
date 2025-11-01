
# ASP.NET Core MVC Programming Final Test (Simulation)

## 🧪 Overview
This simulation test aims to strengthen your practical skills in ASP.NET Core MVC before the final exam. You are required to demonstrate your understanding of Models, Controllers, Views, and how to work with Entity Framework Core in a real-world scenario.

---

## Part A: Multiple Choice (30 marks)

**Answer all 15 questions. Each question is worth 2 marks. Circle the correct answer.**

1. What does the `Model` represent in ASP.NET Core MVC?
   - A) The user interface layout
   - B) The URL routing configuration
   - C) The application's data and business logic
   - D) The controller logic

2. Which of the following is used to fetch data from a database table in EF Core?
   - A) `HttpClient`
   - B) `DbContext`
   - C) `IConfiguration`
   - D) `ViewData`

3. What is the purpose of the `[Key]` attribute?
   - A) Encrypts the value of the field
   - B) Specifies a foreign key
   - C) Sets the field as the primary key
   - D) Makes the field optional

4. Which command creates a new controller using scaffolding in ASP.NET Core?
   - A) `dotnet add controller`
   - B) `dotnet asp-controller`
   - C) `dotnet controller add`
   - D) `dotnet aspnet-codegenerator controller`

5. What file typically defines database connection strings?
   - A) `Startup.cs`
   - B) `Program.cs`
   - C) `appsettings.json`
   - D) `launchSettings.json`

(…continue until question 15)

---

## Part B: Programming (70 marks)

### ✍️ Exercise 1: Write Model Classes (30 marks)

You are provided with the code of `ApplicationDbContext.cs` (see below).

### Task:
Based on this context, write the `Book.cs` and `Category.cs` model classes in the `Models` folder.
- Include necessary data annotations such as `[Key]`, `[Required]`, etc.
- `Book` should include a foreign key to `Category`.
- `Category` can contain a navigation property of a list of books.

### Expectation:
Students are expected to demonstrate:
- Entity relationships (one-to-many)
- Correct use of annotations
- Data types and naming conventions

---

### 📄 ApplicationDbContext.cs (Given)

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
        }
    }
}
```

---

### ✍️ Exercise 2: Routing & Display (20 marks)

- Create a controller and view to list all books from the database.
- The view should display: Book Title, Author, and Category Name.

### Expectation:
- Use of route: `/Books`
- View correctly lists data from both Book and Category via EF Core

---

### ✍️ Exercise 3: Form Creation (20 marks)

Create a form to add a new Book.
- Fields: Title, Author, Price, and Category (Dropdown)
- Validate required fields

### Expectation:
- HTML form with validation
- POST method in controller
- Redirect to Index page after successful create

---

## ✏️ Submission
Please write all code and answers clearly on your answer sheets.

---

Good luck! 💻📚
