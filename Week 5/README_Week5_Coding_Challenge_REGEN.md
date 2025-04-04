
# 🧪 CS6004 - Week 5 Coding Challenge: OOP Concepts in C#

## 🎯 Objective
Practice **constructors**, **properties**, **inheritance**, **abstract classes**, and **interfaces** in a single mini-project.

---

## 📦 Scenario

Create a simple **Shape Drawing Application** using OOP principles.

---

## 🛠️ Requirements

### 🔹 Step 1: Create an Abstract Class

```csharp
abstract class Shape
{
    public abstract void Draw();
}
```

### 🔹 Step 2: Create Two Child Classes

```csharp
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Square");
    }
}
```

### 🔹 Step 3: Add an Interface

```csharp
interface IColorable
{
    void SetColor(string color);
}
```

### 🔹 Step 4: Implement the Interface

```csharp
class ColoredCircle : Circle, IColorable
{
    public void SetColor(string color)
    {
        Console.WriteLine($"Color set to {color}");
    }
}
```

### 🔹 Step 5: Main Program

```csharp
class Program
{
    static void Main(string[] args)
    {
        Shape shape1 = new Circle();
        Shape shape2 = new Square();
        shape1.Draw(); // Output: Drawing a Circle
        shape2.Draw(); // Output: Drawing a Square

        ColoredCircle cc = new ColoredCircle();
        cc.Draw();          // Inherited from Circle
        cc.SetColor("Red"); // Output: Color set to Red
    }
}
```

---

## ✅ What You Will Learn
- Use of **abstract class** and **override**
- **Polymorphism** via base class references
- Creating and using an **interface**
- **Code reuse** and **extension**

---

## 📌 Bonus Task (Optional)
- Add a static property to count how many shapes were created.
- Use `is` or `as` to check object type before casting.

---

## 🚀 Submission
- Submit the `.cs` file or push to your GitHub repository.
- Share your console output screenshot if requested by your lecturer.

Happy coding! 💻
