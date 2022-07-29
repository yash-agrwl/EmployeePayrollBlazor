create database EmployeePayroll;
use EmployeePayroll;
Create table Employees(   
	EmployeeID int NOT NULL auto_increment,   
	Name varchar(20) NOT NULL,   
	ProfileImage varchar(20) NOT NULL,   
	Gender varchar(20) NOT NULL,   
	Department varchar(20) NOT NULL,
    Salary int NOT NULL,
    StartDate datetime NOT NULL,
    Notes varchar(200) NOT NULL,
    Primary Key (EmployeeID)
);
use employeePayroll;
ALTER TABLE Employees
MODIFY COLUMN ProfileImage varchar(255);
