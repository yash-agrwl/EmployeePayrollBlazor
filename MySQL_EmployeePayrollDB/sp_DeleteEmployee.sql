USE `employeepayroll`;
DROP procedure IF EXISTS `sp_DeleteEmployee`;

DELIMITER $$
USE `employeepayroll`$$
CREATE PROCEDURE `sp_DeleteEmployee` (in empId int)
BEGIN
	Delete from employees where EmployeeID=empId;
END$$

DELIMITER ;