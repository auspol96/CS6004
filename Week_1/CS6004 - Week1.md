# CS6004 - Application Development Setup Guide

## 1. Install Visual Studio
### Download & Install
1. Download Visual Studio from [Visual Studio Official Site](https://visualstudio.microsoft.com/).
2. Choose **Visual Studio 2022 Community Edition** (Free version).
3. During installation, select the following workloads:
   - ✅ **.NET desktop development**
   - ✅ **ASP.NET and web development** (if needed for web apps)
4. Click **Install** and wait for it to complete.

## 2. Install .NET SDK
### Download & Install
1. Download the .NET SDK from [Download .NET SDK](https://dotnet.microsoft.com/en-us/download).
2. Choose the **latest stable version** (e.g., .NET 8 or .NET 6 LTS).
3. Install the SDK.

### Verify Installation
Run the following command in **Command Prompt (Windows) or Terminal (Mac/Linux)**:
```sh
dotnet --version
```
If correctly installed, it should return the installed version number.

## 3. Install SQL Server (Optional, If Required)
### Download & Install
1. Download **SQL Server Express** from [Microsoft SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads).
2. Install **SQL Server Management Studio (SSMS)** from [Download SSMS](https://aka.ms/ssmsfullsetup).
3. Follow default settings for a local development database.

## 4. Install Git (Optional, for Version Control)
### Download & Install
1. Download Git from [Git Official Site](https://git-scm.com/).
2. Install with default settings.
3. Verify installation by running the following command in the terminal:
```sh
git --version
```

## 5. Set Up GitHub Repository (For Documentation)
1. Go to [GitHub](https://github.com/).
2. Create a **new public repository** (e.g., `cs6004-setup-guide`).
3. Clone the repository to your local machine:
```sh
git clone https://github.com/yourusername/cs6004-setup-guide.git
cd cs6004-setup-guide
```
4. Add the `README.md` file to document the setup steps:
```sh
git add README.md
git commit -m "Added setup guide"
git push origin main
```

---
### 🎯 **Next Steps:**
✅ Ensure all tools are installed.
✅ Test running a basic C# program in Visual Studio.
✅ Share the GitHub repository with students for easy access.

🚀 **Happy Coding!**
