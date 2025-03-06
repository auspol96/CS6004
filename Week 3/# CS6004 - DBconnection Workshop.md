# **Setting up ASP.NET Core with Oracle Database**

## **1. Prerequisites**
Before starting, ensure you have installed:

- **.NET SDK** (Download from [dotnet.microsoft.com](https://dotnet.microsoft.com/))
- **Oracle Database** (21c Express Edition recommended)
- **Oracle Data Provider for .NET (ODP.NET)**
- **Oracle SQL Developer** (For managing the database)
- **Visual Studio 2022** (Community Edition is fine)
- **Git** (for version control if required)

---

## **2. Create a New ASP.NET Core MVC Project**

Open **Visual Studio** and follow these steps:

1. **Create a new project** → Select **ASP.NET Core Web App (Model-View-Controller)**.
2. **Name the project** (e.g., `LibraryManagement`).
3. Choose **.NET 7.0** or later.
4. Click **Create**.

---

## **3. Install Required Packages for Database Connection**

### **For Oracle Database**
Open the **Package Manager Console** (**Tools** > **NuGet Package Manager** > **Package Manager Console**) and run:

```powershell
Install-Package Oracle.EntityFrameworkCore
```

This package allows Entity Framework Core to interact with Oracle Database.

---

## **4. Set Up Database Connection in `appsettings.json`**

Locate and update `appsettings.json` with your **Oracle connection string**:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "OracleDbContext": "User Id=system;Password=Pong6871;Data Source=localhost:1521/xepdb1;"
  }
}
```

This connection string should be adjusted based on your Oracle **username, password, and database instance name**.

---

## **5. Create the Database Context Class**

Inside your project, navigate to `Data` folder and create `LibraryContext.cs`:

```csharp
using Microsoft.EntityFrameworkCore;
using LibraryManagement.Models;

namespace LibraryManagement.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
```

### **Register Database Context in `Program.cs`**
Modify `Program.cs` to use **Entity Framework Core with Oracle**:

```csharp
using LibraryManagement.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Register DbContext with Oracle Connection
builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDbContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
```

---

## **6. Create the Model (Book.cs)**
Inside the `Models` folder, create a `Book.cs` file:

```csharp
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
```

---

## **7. Apply Database Migrations**
In **Package Manager Console**, run:

```powershell
Add-Migration InitialCreate
Update-Database
```

This will create the **Books table** in Oracle DB.

---

## **8. Verify the Table in Oracle SQL Developer**

- Open **Oracle SQL Developer** and connect to your database.
- Run:
  ```sql
  SELECT * FROM USER_TABLES;
  ```
- You should see `BOOKS` table created.

---

## **9. Create a Controller for Book Management**
Run the following command in **Terminal** to generate a controller:

```powershell
dotnet aspnet-codegenerator controller -name BooksController -m Book -dc LibraryContext --relativeFolderPath Controllers --useDefaultLayout
```

This will create `BooksController.cs` under the **Controllers** folder.

---

## **10. Add Views for Book Management**
Inside `Views` folder, create a new folder **Books**, and add:

1. **Index.cshtml** (Displays all books)
2. **Create.cshtml** (Form to add a new book)
3. **Edit.cshtml** (Form to edit a book)
4. **Details.cshtml** (Displays book details)
5. **Delete.cshtml** (Confirmation page to delete a book)

You can use the default **Scaffolded Views** in Visual Studio.

---

## **11. Run the Application**

Start the application in **Visual Studio** by pressing `F5` or running:

```powershell
dotnet run
```

Open your browser and go to:

```
http://localhost:5000/Books
```

You should now see the **CRUD operations working with Oracle Database**.

---

## **12. Upload to GitHub**

1. **Initialize Git**
   ```sh
   git init
   git add .
   git commit -m "Initial commit - ASP.NET with Oracle"
   ```

2. **Connect to GitHub Repository**
   ```sh
   git remote add origin https://github.com/yourusername/yourrepository.git
   git branch -M main
   git push -u origin main
   ```

Now, students can **clone the repository** and follow the guide. 🚀

---

## **Conclusion**
This guide covers setting up **ASP.NET Core MVC** with **Oracle Database**, including:

✅ Project setup in **Visual Studio**
✅ **Entity Framework Core** with **Oracle**
✅ Database **migrations and verification**
✅ **CRUD operations** for managing books
✅ Uploading project to **GitHub**

Would you like any further modifications before uploading? 😊

