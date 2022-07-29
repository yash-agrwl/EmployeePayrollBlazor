USE `employeepayroll`;
DROP procedure IF EXISTS `sp_UpdateEmployee`;

DELIMITER $$
USE `employeepayroll`$$
CREATE PROCEDURE `sp_UpdateEmployee` (
	in empId int,
    in name varchar(20),   
	in img varchar(255),   
	in gender varchar(20),   
	in department varchar(20),
    in salary int,
    in startDate datetime,
    in notes varchar(200)
)
BEGIN
	Update employees
    set Name=name, ProfileImage=img, Gender=gender, Department=department,
		Salary=salary, StartDate=startDate, Notes=notes
	where EmployeeID=empId;
END$$

DELIMITER ;