# 📝 Web Application: Academic Assignment and Recording Application
**This project is a role-based academic assignment and recording application management system developed using the MVC (Model-View-Controller) architecture. It supports multiple user roles including Teachers, Administrators, and Students.**

> ℹ️ This project is not open source and does not grant any usage rights.
> For usage terms and legal information, see [Code Ownership & Usage Terms](#-code-ownership--usage-terms).

## 🌐 Features
### 🔐 Authentication
-	Secure login system for Students, Administrators, and Teachers
-	Role-based access control with dynamic navigation
### 🎓 Student Functionality
-	See all the student’s registered courses
-	For each course, see all subjects
-	For each subject, see all tasks
-	Add an application for a task
### ⚙️ Administrator Functionality
-	See all the teacher and student profiles
-	Ban or un-ban any teacher or student profile.
### 💼 Teacher Functionality
-	See all courses
-	For each course, see all subjects.
-	For each subject, see all tasks.
-	For the teacher’s registered courses, add new or delete existed personal or team subjects.
-	For the teacher’s registered courses, add new or delete existed tasks.

## 🎯 Purpose
The purpose of this project is to develop a functional web application that allows teachers to upload assignments with a specific deadline, students to submit an application and specify if it is individual or group work. **It is developed solely for academic and research purposes**.


## 🛠️ Technologies Used

- ASP.NET MVC Framework
- C# for Business Logic
- HTML5
- PostgreSQL for data persistence
- Bootstrap for responsive UI

## 📦 Installation

To set up the project locally:

1. **Clone the repository**
   ```bash
   git clone https://github.com/theofanistzoumakas/academic_assignment_and_recording_app.git
   cd academic_assignment_and_recording_app
2. **Open the project in Visual Studio 2022** using the `.sln` file
3. **Confirm that the following NuGet packages are installed:**
    - Microsoft.EntityFrameworkCore.SqlServer (version **9.0.9**)
    - Microsoft.EntityFrameworkCore.Tools (version **9.0.9**)
    - Microsoft.VisualStudio.Web.CodeGeneration.Design (version **9.0.0**)
    - X.PagedList.Mvc.Core (version **10.5.x**)
4. **Verify Target Framework**
     In your `.csproj` file, ensure the framework is set correctly:
   
     ```xml
     <TargetFramework>net8.0</TargetFramework>

5. **Install** PgAdmin.
    - Update the connection string in appsettings.json and LabDBContext.cs (Models folder) to match PgAdmin
    - Run the provided SQL script database_schema.sql to initialize the schema and seed data.
    - In database, manually increament the id value as required and save the changes.

7. **Run** the web application from  Visual Studio

# 🔒 Code Ownership & Usage Terms

This project was created and maintained by:

- Theofanis Tzoumakas (@theofanistzoumakas)
- Konstantinos Pavlis (@kpavlis)
- Michael-Panagiotis Kapetanios (@KapetaniosMP)

🚫 **Unauthorized use is strictly prohibited.**  
No part of this codebase may be copied, reproduced, modified, distributed, or used in any form without **explicit written permission** from the owners.

Any attempt to use, republish, or incorporate this code into other projects—whether commercial or non-commercial—without prior consent may result in legal action.

For licensing inquiries or collaboration requests, please contact via email: theftzoumi _at_ gmail _dot_ com .

© 2025 Theofanis Tzoumakas, Konstantinos Pavlis, Michael-Panagiotis Kapetanios. All rights reserved.
