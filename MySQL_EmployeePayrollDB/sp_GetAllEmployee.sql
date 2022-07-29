USE `employeepayroll`;
DROP procedure IF EXISTS `sp_GetAllEmployee`;

DELIMITER $$
USE `employeepayroll`$$
CREATE PROCEDURE `sp_GetAllEmployee` ()
BEGIN
	SELECT * FROM Employees;
END$$

DELIMITER ;