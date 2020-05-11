CREATE PROCEDURE sproc_tblStaff_Delete

@EmployeeNo int

AS

delete from dbo.tblstaff where employee_id = @EmployeeNo;