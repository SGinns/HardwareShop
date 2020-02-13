CREATE PROCEDURE sproc_tblStaff_FilterByEmployeeNo
	@EmployeeNo int
AS
	select * from tblStaff where employee_id = @EmployeeNo
RETURN 0