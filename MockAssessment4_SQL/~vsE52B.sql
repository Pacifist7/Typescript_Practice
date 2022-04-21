CREATE TABLE Department(
ID int NOT NULL Identity PRIMARY KEY,
Name NVARCHAR(25) NOT NULL,
Hiring bit,
Location NVARCHAR(50)
)

INSERT INTO dbo.Department(Name, Hiring, Location)
VALUES ('Technology', 1, '1570 Woodward Ave.'), ('Shipping & Receiving', 0, 'Southfield')

CREATE TABLE Employee(
SSN NCHAR(9) NOT NULL PRIMARY KEY,
DOB DATE,
Phone NCHAR(10),
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
DepartmentId int FOREIGN KEY REFERENCES Department(Id)
)


INSERT INTO dbo.Employee(SSN, DOB, Phone, FirstName, LastName, DepartmentId)
VALUES ('123456789', '1/5/1975', '3135555505', 'Charles', 'Charleston', 2), ('987654321', '5/2/1990', '2489995555', 'Jimmy', 'Scrambles', 1), ('456789123', '8/6/2001', '7895555525', 'Vince', 'Jabowski', 1), ('654854632', '4/6/1988', '3139721400', 'John', 'Johnston', 2)


UPDATE Employee
SET LastName = 'Spiderman'
WHERE DOB = (SELECT MAX(DOB) FROM Employee)


SELECT * FROM Employee
WHERE LastName LIKE 'J%'


DELETE FROM Employee
WHERE DOB = (SELECT MIN(DOB) FROM Employee)


select * FROM Employee
WHERE Phone LIKE '313%' 


SELECT * FROM Employee
WHERE DOB < '9/9/1999'


UPDATE Employee
SET Phone = NULL
WHERE DOB > '1/1/2000'


SELECT * FROM Employee
WHERE Phone IS NULL


SELECT d.ID, d.Name, d.Location, e.* FROM Department d
JOIN Employee e ON d.ID=e.DepartmentId


DROP Table Employee

DROP Table Department

