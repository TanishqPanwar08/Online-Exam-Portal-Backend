
# Online-Exam-Portal-Backend

This project was built using **ASP.NET MVC Web API** and **Entity Framework Core**.  
It serves as the backend for the Online Exam Portal and uses **SQL Server (SSMS)** for data persistence.

## 🚀 Getting Started

To set up and run the backend project locally, follow these steps:

### 1. Clone the Repository

git clone https://github.com/TanishqPanwar08/Online-Exam-Portal-Backend.git
cd Online-Exam-Portal-Backend

### 2. Update the Connection String

Open the `appsettings.json` file and update the `DefaultConnection` string:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=YOUR_DATABASE_NAME;Trusted_Connection=True;MultipleActiveResultSets=true"
}

Replace `YOUR_SERVER_NAME` with your local SQL Server name, and `YOUR_DATABASE_NAME` with a name of your choice.

### 3. Create the Database in SSMS

- Open **SQL Server Management Studio (SSMS)**.
- Create a **new database** using the same name as provided in your connection string.

### 4. Run Migrations

Open **Package Manager Console** in Visual Studio and run:

Add-Migration InitialCreate
Update-Database

### 5. Run the Project

You can run the project using:

- Press `F5` in Visual Studio  
OR  
- Use the command:

dotnet run

The API will be hosted locally at:

https://localhost:{PORT}/api/{controller}

Use tools like **Postman**, **Swagger**, or **Thunder Client** (VS Code) to test the API endpoints.

## 📁 Project Structure

- **Controllers/** – API controllers to handle incoming HTTP requests  
- **Models/** – Entity classes used by EF Core  
- **Data/** – Contains `ApplicationDbContext` and EF configurations  
- **Migrations/** – EF Core migration files  
- **appsettings.json** – Configuration file for connection strings and environment setup  

## 🌟 Features

- RESTful API architecture  
- Built with ASP.NET Core Web API  
- Entity Framework Core integration for ORM  
- Role-based architecture (Admin, Student)  
- Secure database operations  
- Seamless integration with Angular frontend  
- Scalable and modular backend design  

## ✅ Prerequisites

Ensure the following tools are installed on your machine:

- .NET SDK  
- Visual Studio 2022+ (with ASP.NET and web development workload)  
- SQL Server Management Studio (SSMS)

## 🔁 Updating the Database

After modifying the models, update the schema:

Add-Migration YourMigrationName
Update-Database

## ⚠️ Notes

- Ensure SQL Server is running before starting the project.  
- Configure CORS in `Startup.cs` if accessing the API from a different frontend domain.  
- If using Swagger, visit:

https://localhost:{PORT}/swagger
