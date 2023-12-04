# students-manager

## Short Description

Students Manager is a web application that enables you to manage a list of students (create, edit, and delete). This app is developed with .NET Core, React.js, and Entity Framework.

## Requirements

- [.NET 8](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/)
- [npm](https://www.npmjs.com/)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or another compatible database
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (included in the project)
- [Visual Studio](https://visualstudio.microsoft.com/downloads/) or [Visual Studio Code](https://code.visualstudio.com/)

## Local Environment Setup

1. **Clone the repository:**
   ```bash
   git clone https://github.com/likeamike/students-manager.git
   cd students-manager
2. **Open the project in Visual Studio and restore dependencies.**
3. **Init database:**
   ```bash
   cd .\StudentsManager.Server\
   dotnet ef database update
4. **Run project via Visual Studio**
