USE WindowsFormsDB;
GO

CREATE TABLE Students (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Age INT NOT NULL,
    Email NVARCHAR(100) NOT NULL
);
