# 🧩 ASP.NET Core MVC Starter Exercises

These small exercises help students transition from "Hello World" into practical, hands-on development using ASP.NET Core MVC. No database is required. Students should already have a working MVC project setup.

---

## ✅ Exercise 1: Display Your Name Page
**Objective:** Practice routing and view rendering

### 🔧 Steps:
1. Create a new controller: `InfoController`
2. Add a method:
```csharp
public IActionResult MyName()
{
    ViewBag.MyName = "Your Full Name";
    return View();
}
```
3. Create a view `MyName.cshtml` under `Views/Info/`
```html
<h2>Hello, @ViewBag.MyName!</h2>
<p>Today is @DateTime.Now</p>
```
4. Access the page at `/Info/MyName`

---

## ✅ Exercise 2: Simple About Me Form (GET + POST)
**Objective:** Learn form handling with GET/POST

### 🔧 Steps:
1. Create model `AboutMe.cs`
```csharp
public class AboutMe
{
    public string Name { get; set; }
    public string Hobby { get; set; }
    public string FavoriteFood { get; set; }
}
```
2. Add to `InfoController`:
```csharp
[HttpGet]
public IActionResult AboutMe()
{
    return View();
}

[HttpPost]
public IActionResult AboutMe(AboutMe model)
{
    return View("AboutMeResult", model);
}
```
3. Create `AboutMe.cshtml` in `Views/Info/`
```html
<form asp-action="AboutMe" method="post">
    <input asp-for="Name" placeholder="Your name" /> <br />
    <input asp-for="Hobby" placeholder="Your hobby" /> <br />
    <input asp-for="FavoriteFood" placeholder="Your favorite food" /> <br />
    <button type="submit">Submit</button>
</form>
```
4. Create `AboutMeResult.cshtml`:
```html
<h3>Summary</h3>
<p>Name: @Model.Name</p>
<p>Hobby: @Model.Hobby</p>
<p>Favorite Food: @Model.FavoriteFood</p>
```

---

## ✅ Exercise 3: Temperature Converter
**Objective:** Logic processing with user input

### 🔧 Steps:
1. Add to `InfoController`:
```csharp
[HttpGet]
public IActionResult ConvertTemp()
{
    return View();
}

[HttpPost]
public IActionResult ConvertTemp(string type, double value)
{
    double result = (type == "CtoF") ? (value * 9 / 5 + 32) : ((value - 32) * 5 / 9);
    ViewBag.Result = result;
    return View();
}
```
2. Create `ConvertTemp.cshtml`:
```html
<form asp-action="ConvertTemp" method="post">
    <input type="number" name="value" placeholder="Temperature" />
    <select name="type">
        <option value="CtoF">Celsius to Fahrenheit</option>
        <option value="FtoC">Fahrenheit to Celsius</option>
    </select>
    <button type="submit">Convert</button>
</form>
@if(ViewBag.Result != null)
{
    <p>Result: @ViewBag.Result</p>
}
```

---

## ✅ Exercise 4: Guess My Number
**Objective:** Introduce conditionals and random logic

### 🔧 Steps:
1. Add to `InfoController`:
```csharp
[HttpGet]
public IActionResult GuessGame()
{
    return View();
}

[HttpPost]
public IActionResult GuessGame(int guess)
{
    int number = new Random().Next(1, 11);
    string message = guess == number ? "Correct!" : (guess < number ? "Too low" : "Too high");
    ViewBag.Message = $"Your guess: {guess}, Answer: {number} → {message}";
    return View();
}
```
2. Create `GuessGame.cshtml`:
```html
<form asp-action="GuessGame" method="post">
    <input type="number" name="guess" min="1" max="10" required />
    <button type="submit">Submit</button>
</form>
@if(ViewBag.Message != null)
{
    <p>@ViewBag.Message</p>
}
```

---

## ✅ Exercise 5: Quote Generator
**Objective:** Arrays + Random display

### 🔧 Steps:
1. Add to `InfoController`:
```csharp
public IActionResult Quote()
{
    string[] quotes =
    {
        "Dream big. Start small.",
        "Code is like humor. When you have to explain it, it’s bad.",
        "Simplicity is the soul of efficiency.",
        "First, solve the problem. Then, write the code.",
    };
    Random rnd = new Random();
    ViewBag.RandomQuote = quotes[rnd.Next(quotes.Length)];
    return View();
}
```
2. Create `Quote.cshtml`:
```html
<h2>Motivational Quote</h2>
<p>@ViewBag.RandomQuote</p>
```

---

Let me know if you’d like a **student worksheet version** with empty fields or a version **with Thai translations**.
