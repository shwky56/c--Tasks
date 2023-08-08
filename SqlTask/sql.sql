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


-- SQL Task2

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (1, 'Human Resources');

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (2, 'Finance');

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (3, 'IT');

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (4, 'Marketing');

INSERT INTO Departments (DepartmentID, DepartmentName)
VALUES (5, 'Operations');

-- 


INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (1, 'John', 'Doe', 1, 50000.00, '1990-05-15');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (2, 'Jane', 'Smith', 2, 60000.00, '1988-09-22');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (3, 'Michael', 'Johnson', 1, 55000.00, '1992-02-10');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (4, 'Emily', 'Williams', 3, 65000.00, '1985-11-30');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (5, 'David', 'Brown', 4, 52000.00, '1991-07-18');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (6, 'Jessica', 'Miller', 2, 70000.00, '1987-04-05');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (7, 'Christopher', 'Taylor', 3, 58000.00, '1993-08-27');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (8, 'Amanda', 'Martinez', 5, 54000.00, '1989-12-12');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (9, 'Kevin', 'Anderson', 1, 62000.00, '1994-01-25');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, DateOfBirth)
VALUES (10, 'Sarah', 'Jackson', 4, 56000.00, '1990-06-08');


-- 

UPDATE Employees
SET Salary = Salary * 1.10
WHERE DepartmentID = (SELECT DepartmentID FROM Departments WHERE DepartmentName = 'Sales');


-- 

UPDATE Employees
SET Salary = Salary * 1.10
WHERE DepartmentID = 4;


-- 

DELETE FROM Employees
WHERE Salary < 40000.00;


-- 

-- Step 1: Delete the employees in the specified department
DELETE FROM Employees
WHERE DepartmentID = 3;

-- Step 2: Delete the department itself
DELETE FROM Departments
WHERE DepartmentID = 3;
