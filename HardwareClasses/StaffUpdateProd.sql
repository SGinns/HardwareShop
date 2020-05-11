CREATE PROCEDURE sproc_tblStaff_Update

@employeeNo int,
@firstName varchar (255),
@lastName varchar (255),
@salary int,
@active bit

AS

update dbo.tblstaff
set first_name = @firstName,
	last_name = @lastName,
	salary = @salary,
	active = @active

	where employee_id = @employeeNo
