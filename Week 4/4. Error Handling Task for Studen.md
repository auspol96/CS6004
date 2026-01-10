# 🚀 Error Handling Task for Students

## **📌 Overview**
In this task, you will **enhance the C# Console Application** by adding **error handling** using `try-catch` blocks. The goal is to prevent the program from crashing when users enter invalid input.

---

## **✅ Task 1: Add Error Handling to `IfElseStatement.cs`**
### **📝 Instructions**
1. Open **`IfElseStatement.cs`**.
2. Wrap `int.Parse(Console.ReadLine())` inside a **try-catch** block.
3. If the input is invalid, display `"Invalid input! Please enter a number."` and **prompt again**.

### **✅ Expected Solution**
```csharp
public class IfElseStatement
{
    public static void Run()
    {
        Console.Clear();
        int n;
        while (true) // Loop until a valid number is entered
        {
            Console.Write("Enter a number: ");
            try
            {
                n = int.Parse(Console.ReadLine());
                break; // Exit loop if successful
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        if (n < 10)
        {
            Console.WriteLine("n is less than 10");
        }
        else if (n < 20)
        {
            Console.WriteLine("n is less than 20");
        }
        else
        {
            Console.WriteLine("n is greater than or equal to 20");
        }
        
        Console.WriteLine("\nPress any key to return to the menu.");
        Console.ReadKey();
    }
}
```

---

## **✅ Task 2: Add Error Handling to `SwitchStatement.cs`**
### **📝 Instructions**
1. Modify `SwitchStatement.cs` to **validate** both number inputs.
2. Prevent crashes when users enter **non-numeric values**.
3. Ensure that users can **only enter** `+` or `-` as an operator.

### **✅ Expected Solution**
```csharp
public class SwitchStatement
{
    public static void Run()
    {
        Console.Clear();
        int op1, op2;
        
        // Validate first number
        while (true)
        {
            Console.Write("Enter first number: ");
            try
            {
                op1 = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }
        
        // Validate second number
        while (true)
        {
            Console.Write("Enter second number: ");
            try
            {
                op2 = int.Parse(Console.ReadLine());
                break;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
            }
        }

        // Validate operator
        char opr;
        while (true)
        {
            Console.Write("Enter operator (+ or -): ");
            opr = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (opr == '+' || opr == '-')
                break;
            else
                Console.WriteLine("Invalid operator! Please enter either + or -.");
        }

        int result;
        switch (opr)
        {
            case '+':
                result = op1 + op2;
                break;
            case '-':
                result = op1 - op2;
                break;
            default:
                Console.WriteLine("Unexpected error.");
                return;
        }

        Console.WriteLine($"Result: {result}");
        Console.WriteLine("\nPress any key to return to the menu.");
        Console.ReadKey();
    }
}
```

---

## **🔹 Task Submission Instructions**
1. **Modify `IfElseStatement.cs` and `SwitchStatement.cs`** to include the `try-catch` blocks as explained.
2. **Test the application** by entering:
   - Letters (`abc`)
   - Special characters (`!@#`)
   - Invalid operators (`*`, `/`)
3. Ensure that the **program does not crash** and displays friendly messages.
4. **Upload your modified files** to GitHub.

---

## **🎯 Bonus Challenge**
- Extend **`SwitchStatement.cs`** to support **multiplication (`*`) and division (`/`)** while still ensuring valid input.
- Handle **division by zero** with an error message instead of crashing.

---

## **🎉 Well Done!**
By completing this task, you will **understand the importance of error handling** and **how to prevent unexpected crashes** in real-world applications! 🚀
