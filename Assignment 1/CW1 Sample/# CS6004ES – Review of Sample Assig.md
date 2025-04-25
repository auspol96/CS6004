# CS6004ES – Review of Sample Assignments

This document provides a comparative review of two previous student assignments submitted for the CS6004ES module. It outlines how each sample aligns with or deviates from the **2024/25 coursework brief** and provides guidance for current students.

---

## ✅ Assignment Requirements (2024/25 Brief Summary)

The coursework is to develop a C# Windows Forms application for **e-Shift**, a household goods transport company. It must support:

- Admin and Customer roles
- Login system
- Transport jobs consisting of **multiple loads**
- Transport unit assignment: **driver, assistant, lorry, container**
- Admin functionalities: job approval, product management, report generation
- Data persistence (e.g. SQL Server)
- A reflective essay with architecture, class breakdown, experience, and search algorithm

---

## 📘 Sample 1: **Janarthana Kalaikumar – ABC Car Traders**

### ✅ Strengths:
- Role separation (Admin and Customer) implemented
- Login and dashboards implemented per user role
- Functional CRUD for cars, parts, and orders
- SQL Server database usage
- C# class structure is well-defined
- Linear search algorithm discussed
- Complete reflective essay with technical reflections
- UI screenshots and flow documentation

### ❌ Limitations (vs. 2024/25 brief):
- Domain mismatch: focuses on **car trading**, not **household goods transport**
- No concept of **jobs**, **loads**, or **transport units**
- No **driver/assistant/lorry/container** modeling
- Missing **admin approval workflow** for transport jobs
- Limited report types (only order reports)

### ✅ Usefulness for Current Students:
- Reference for class design, login system, and dashboards
- Strong structure for reflective writing
- Not suitable for domain reuse — **must adjust for e-Shift**

---

## 📘 Sample 2: **S.A.H.M.N. Gunathilaka – ABC Car Traders**

### ✅ Strengths:
- Admin and Customer dashboards
- Button-based UI navigation explained in detail
- Basic CRUD operations (Cars, Parts, Orders)
- Simple structure using C# and SQL
- GitHub link provided for transparency
- Coded button actions for all main functions

### ❌ Limitations (vs. 2024/25 brief):
- Domain mismatch: focuses on **cars/parts**, not **transport jobs**
- No concept of **jobs**, **loads**, or transport resource assignment
- No admin **approval/decline** workflow
- No search algorithm explanation
- No structured reflective essay (only inline comments)
- Missing details on class design or architecture overview

### ✅ Usefulness for Current Students:
- Useful for understanding UI navigation logic
- Simple example for new developers
- Not complete in terms of documentation or reflective content
- Should **not be reused directly** — must adapt to e-Shift’s transport domain

---

## 🧭 Guidance for Current Students

### What to Reuse:
- Dashboard design ideas and UI flow
- Login/logout logic
- CRUD operation structures
- Code organization and database connection examples

### What to Change:
- Domain: Must reflect **e-Shift** (household transport)
- Entities: Implement `Job`, `Load`, and `TransportUnit` classes
- Admin actions: Include **job approval/decline**
- Reports: Expand to include job, customer, transport unit data
- Add a proper **reflective essay** with:
  - Instructions to run the app
  - Class architecture
  - Properties/methods breakdown
  - Personal reflections
  - Search algorithm explanation (e.g., Linear Search)

---

## ✅ Final Tip
Use these samples as **technical references**, not templates. Your work must reflect the new **e-Shift** requirements to comply with the coursework brief and academic integrity policies.

For further help, consult your module leader or technical support.

