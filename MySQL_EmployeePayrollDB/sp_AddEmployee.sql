USE `employeepayroll`;
DROP procedure IF EXISTS `sp_AddEmployee`;

DELIMITER $$
USE `employeepayroll`$$
CREATE PROCEDURE `sp_AddEmployee` (
	in Name varchar(20),   
	in ProfileImage varchar(255),   
	in Gender varchar(20),   
	in Department varchar(20),
    in Salary int,
    in StartDate datetime,
    in Notes varchar(200)
)
BEGIN
	Insert into employees
    ( Name, ProfileImage, Gender, Department, Salary, StartDate, Notes )
    Values ( Name, ProfileImage, Gender, Department, Salary, StartDate, Notes );
END$$

DELIMITER ;