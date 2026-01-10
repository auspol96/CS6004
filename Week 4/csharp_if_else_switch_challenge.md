# In-Class Challenge: Smart Vending Machine (if / else / switch)

This activity helps students practice **if**, **if-else**, and **switch** statements in C#  
using a **real-life vending machine scenario**.

Designed for **beginners** and suitable for a **20–30 minute class activity**.

---

## 🎯 Learning Objectives

By the end of this challenge, students will be able to:
- Use `if` to check simple conditions
- Use `if – else if – else` for multiple conditions
- Use `switch` for multi-way decision making
- Apply logical thinking to real-world problems

---

## 🧩 Scenario Overview

> You are building a **Smart Vending Machine**.  
> The machine makes decisions based on **user input** such as age, money, and product choice.

---

## 🧪 Part 1 — Simple IF Statement (Warm-up)

### Task
The vending machine checks **age** before selling an energy drink.

### Rules
- If age is **18 or above** → Allow purchase
- Otherwise → Deny purchase

### Instructions
1. Create a variable `age`
2. Use an `if` statement to check the age
3. Print the result

### Expected Output
```
Purchase allowed
```
or
```
Purchase denied
```

---

## 🧪 Part 2 — IF–ELSE IF–ELSE Statement (Core)

### Task
The vending machine gives products based on **money inserted**.

### Rules

| Money Inserted | Output Message |
|---------------|--------------|
| Less than 10 | Not enough money |
| 10 – 19 | You get a snack |
| 20 or more | You get a snack + drink |

### Instructions
- Store money in a variable
- Use `if – else if – else`
- Print **only one message**

---

## 🧪 Part 3 — SWITCH Statement (Product Selection)

### Task
The user selects a product using a **product code**.

### Product Codes

| Code | Product |
|----|--------|
| A | Chips |
| B | Chocolate |
| C | Soda |
| Other | Invalid selection |

### Instructions
- Use a `switch` statement
- Print the selected product
- Handle invalid input

---

## 🔥 Optional Advanced Challenge (Fast Learners)

Combine all parts:
1. Select product (switch)
2. Insert money (if–else)
3. Decide whether purchase is successful

This simulates a **real vending machine logic**.

---

## 🧑‍🏫 Teaching Notes

- Explain logic **before coding**
- Emphasize **decision-making**, not syntax
- Ask students to explain their logic verbally

### Common Mistakes to Watch For
- Using multiple `if` instead of `else if`
- Forgetting `break` in `switch`
- Incorrect condition order

---

## 📝 One-Line Summary (Exam-Friendly)

> This program uses `if`, `if-else`, and `switch` statements to make decisions based on user input.

---

✅ End of Worksheet
