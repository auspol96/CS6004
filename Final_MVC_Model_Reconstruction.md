
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
