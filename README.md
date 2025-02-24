# **StudentManage**
## **Practical Test**

### **How to Run:**
1. Install **.NET Framework 4.8** if not already installed.
2. Set up SQL (**LocalDB**, **SQL Server**, or a cloud-based alternative).
3. Load the project in **Visual Studio** and restore **NuGet packages**.
4. Update the **Web.config** `<connectionStrings>` section with your database credentials.
5. Run the database migration:
   - Open **Package Manager Console**.
   - Select the **Repositories** project.
   - Execute the following command:
     ```powershell
     Update-Database
     ```
6. Run the application in **Debug Mode (F5)** to verify that everything works properly.

---

## **Description**

### **Packages Used:**
- ✅ **Entity Framework 6.5.1** – ORM for database interaction  
- ✅ **AutoMapper 10.1.1** – Object-to-object mapping  
- ✅ **Serilog 4.2.0** – Logging system for user actions and error records  
- ✅ **PagedList.Mvc** – Pagination support for MVC  
- ✅ **Unity.Mvc5** – Dependency injection  

---

## **Project Architecture**
The **Student Management System** follows a **clean layered architecture** with the following structure:

### **Project Breakdown**
- **`StudentManage.Domain` (Core Models & DTOs)**
  - Contains **Entities, DTOs, Enums, Helpers, Profiles**.
  - Defines the **core data models** and **mapping profiles**.

- **`StudentManage.Repositories` (Data Access Layer)**
  - Includes **Data, Interfaces, Migrations**.
  - Implements **GenericRepository.cs** for database interactions.

- **`StudentManage.Services` (Business Logic Layer)**
  - Provides **StudentService.cs** and **SubjectService.cs** for handling business logic.

- **`StudentManage.Web` (Presentation Layer)**
  - Contains **Controllers, Views, Scripts, and Content** for the **MVC-based UI**.
  - Includes **App_Start, Global.asax, and Web.config** for application configuration.

---

## **Technologies & Design Patterns Used**
- ✅ **Entity Framework Code First**
- ✅ **Database Seeding**
- ✅ **Clean Architecture**
- ✅ **Repository Pattern**
- ✅ **Dependency Injection (DI)**
- ✅ **AutoMapper for automatic object mapping**
- ✅ **Extension Methods**
- ✅ **Unit of Work** (Ensuring **data integrity**)
- ✅ **Serilog** (Logging errors and tracking all user actions in the system)

---
Result:
![image](https://github.com/user-attachments/assets/41396bd0-a9bd-468a-a839-1a24df534e1d)
![image](https://github.com/user-attachments/assets/12efc9b4-46bf-4b64-9e46-8709ab66f74a)
![image](https://github.com/user-attachments/assets/f5fa243d-18fc-4db2-b1f0-f80a871964bf)![image](https://github.com/user-attachments/assets/0ac7cd8e-4378-491e-9c06-dde1c2a72d69)![image](https://github.com/user-attachments/assets/baab3d29-6410-479d-90cc-29141e91cbff)
![image](https://github.com/user-attachments/assets/4aa1c10e-9966-4831-9a22-6c7e0b33a45d)![image](https://github.com/user-attachments/assets/9fc13df1-572f-43f3-942d-c5a9a5b6e416)![image](https://github.com/user-attachments/assets/1844dd16-64d0-4bc6-ad96-12f51504609b)








