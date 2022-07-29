USE `employeepayroll`;
DROP procedure IF EXISTS `sp_GetEmployeeById`;

DELIMITER $$
USE `employeepayroll`$$
CREATE PROCEDURE `sp_GetEmployeeById` (in empId int)
BEGIN
	SELECT * FROM Employees WHERE EmployeeID = empId;
END$$

DELIMITER ;