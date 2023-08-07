-- Active: 1690462383770@@localhost@1433
create database [CompanyDB];

CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT,
    Salary DECIMAL(10, 2),
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);



INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (1, 'HR');

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (2, 'Finance');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary)
VALUES (1, 'John', 'Doe', 1, 50000.00);

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary)
VALUES (2, 'Jane', 'Smith', 2, 60000.00);


ALTER TABLE Employees
ADD DateOfBirth DATE;


ALTER TABLE Employees
ALTER COLUMN Salary DECIMAL(10, 2);
