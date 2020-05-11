CREATE PROCEDURE sproc_tblStaff_Insert
	@salary int,
	@first_name varchar (255),
	@last_name varchar (255),
	@active bit

	AS

	INSERT INTO dbo.tblstaff (salary, first_name, last_name, active)
	values (@salary, @first_name, @last_name, @active)

	return @@Identity