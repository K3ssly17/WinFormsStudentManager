# WinForms Student Manager

A simple **C# WinForms application** to manage students using **SQL Server**.

## Features

- Add new students
- Display students in a DataGridView
- Validates input (Age must be a number)
- Fully functional on Windows with .NET 8

## Setup

1. Clone the repository:
2. Open the solution in **Visual Studio 2022+**.
3. Run the `CreateDatabase.sql` script in SQL Server to create the database and `Students` table.
4. Open the solution and **run the app**.
5. The DataGridView will display students from the database, and you can add new ones.

## Notes

- The connection string is **hardcoded** in `StudentRepository.cs`:

```csharp
private readonly string cs = 
"Server=DESKTOP-7RRRC97;Database=WindowsFormsDB;Trusted_Connection=True;TrustServerCertificate=True;";
