# In-Class Challenge: Repetition Structures (Loops & Recursion)

This challenge helps students understand **repetition structures** in C#:
- `while`
- `do-while`
- `for`
- `foreach`
- basic **recursion**

Designed for **beginners**, suitable for a **30–40 minute** class session.

---

## 🎯 Learning Objectives

By completing this challenge, students will be able to:
- Choose the correct loop for a task
- Understand **condition checking vs guaranteed execution**
- Use loops to repeat actions
- Understand the basic idea of recursion

---

## 🧠 Scenario: Smart Fitness Tracker

> You are developing a **Smart Fitness Tracker** application.  
> The tracker repeatedly checks steps, calories, and daily progress.

---

## 🧪 Part 1 — `while` Loop (Unknown Repetition)

### Task
The tracker keeps counting steps **until the goal is reached**.

### Rules
- Step goal = 10,000
- Steps increase by 1,000 each loop
- Stop when goal is reached

### Instructions
- Use a `while` loop
- Print current steps each time

### Key Concept
> `while` checks the condition **before** running.

---

## 🧪 Part 2 — `do-while` Loop (Run At Least Once)

### Task
The tracker must **always display the menu at least once**, even if the user exits.

### Rules
- Print menu options
- Ask user if they want to continue (`y` / `n`)
- Repeat until user enters `n`

### Instructions
- Use a `do-while` loop

### Key Concept
> `do-while` runs **once first**, then checks condition.

---

## 🧪 Part 3 — `for` Loop (Known Repetition)

### Task
Display **step summary for 7 days**.

### Rules
- Loop from day 1 to day 7
- Print: `Day X: Steps recorded`

### Instructions
- Use a `for` loop

### Key Concept
> Use `for` when the number of repetitions is known.

---

## 🧪 Part 4 — `foreach` Loop (Collection Loop)

### Task
The tracker stores calories burned per workout.

### Example Data
```csharp
int[] calories = { 300, 450, 500, 350 };
```

### Instructions
- Use `foreach`
- Print each calorie value

### Key Concept
> `foreach` is used to loop through collections easily.

---

## 🔁 Part 5 — Recursion (Advanced Concept)

### Task
Calculate **total steps for N days** using recursion.

### Rules
- If `n == 1`, return base steps
- Otherwise, return steps + recursive call

### Instructions
- Write a recursive method
- Explain the **base case**

### Key Concept
> Recursion is a function calling itself with a stopping condition.

---

## 🧑‍🏫 Teaching Notes

### Emphasize:
- Condition location (`while` vs `do-while`)
- Loop purpose (counting vs collection)
- Recursion must have:
  - Base case
  - Progress toward base case

### Common Mistakes:
- Infinite loops
- Forgetting loop update
- Missing base case in recursion

---

## 📝 One-Line Summary (Exam-Friendly)

> Repetition structures allow a program to execute statements multiple times using loops or recursion.

---

## 🔥 Optional Extension (Fast Learners)

Combine:
- Weekly summary using `for`
- Daily workout list using `foreach`
- Menu loop using `do-while`

---

✅ End of Worksheet
