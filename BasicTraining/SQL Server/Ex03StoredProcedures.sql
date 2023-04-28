---Stored Procedures are predefined statements that are parsed so that U can use the statements without a need to reparse it. If you have a set of statements that are repeatedly executed in SQL server, we can make them as Stored Procedure and use it in the Application. 
-- Stored procs are created once and used many times.
Use FaiTraining
Create Procedure InsertEmployee
(
	@empName varchar(50), 
	@empSalary money, 
	@empPhone bigint, 
	@deptId int, 
	@cityId int, 
	@empId int OUTPUT
)
AS
INSERT INTO tblEmployee Values(@empName, @empPhone, @empSalary, @deptId, @cityId)
SET @empId = @@IDENTITY
GO

DECLARE @id int
EXEC InsertEmployee @empName = 'Sachin', @empSalary = 56000, @empPhone = 7744566558, @deptId = 4, @cityId = 5, @empId = @id OUTPUT
PRINT @id

Select @id as 'GeneratedID'
--Stored proc for updating the Employee and call it in the program. 

-- Use Alter if U want to make any changes to the existing stored proc.
Create Proc DeleteEmployee 
@empId int
AS
DELETE FROM tblEmployee WHERE EmpId = @empId
--TODO: Create Procs for Updating and Finding Employee based on Id. 

Alter Proc AlterEmployee
@empId int, @empName varchar(50), @empPhone bigint, @empSalary int, @deptId int, @cityId int
AS
Update tblEmployee
Set EmpName = @empName, EmpSalary = @empSalary, EmpPhone = @empPhone, DeptId = @deptId, CityId = @cityId WHERE EmpId = @empId

EXEC AlterEmployee @empId = 1002, @empName = 'Phaniraj', @empPhone = 9945205684, @empSalary = 67000, @deptId = 1, @cityId = 1

Select * from tblEmployee WHERE EmpId = 1002

 


-------------FUNCTIONS----------------------
--Functions are similar to Stored Procs in execution but they can be used as a part of expression. With Stored Procs, U cant. 
-- Functions are of 2 types: SVF(Scalar Value Function) and TVF(Table Value Function). SVF return one single value and TVF returns a table. 
Create Function GetDeptName(@id int)
RETURNS VARCHAR(50)
AS
BEGIN
 DECLARE @deptName varchar(50)
 Set @deptName = (SELECT deptName from tblDept Where deptId = @id)
 RETURN @deptName
END

PRINT dbo.GetDeptName(1)
PRINT dbo.GetDeptName(2)
PRINT dbo.GetDeptName(3)
PRINT dbo.GetDeptName(4)

Create Function GetEmpName(@id int)
RETURNS VARCHAR(50)
AS
BEGIN
 DECLARE @empName varchar(50)
 Set @empName = (SELECT empName from tblEmployee Where EmpId = @id)
 RETURN @empName
END

Create Function GetCity(@id int)
RETURNS VARCHAR(50)
AS
BEGIN
 DECLARE @city varchar(50)
 Set @city = (SELECT CityName from tblCity Where CityId = @id)
 RETURN @city
END

Select dbo.GetDeptName(1) as Dept, dbo.GetEmpName(1002) as Employee, dbo.GetCity(1) as City
--------------------------Date based Functions---------
PRINT getDate()

Select Format(getDate(), 'dd/MM/yyyy') as Date
Select Format(getDate(), 'dd-MMM-yyyy') as Date
Select Format(getDate(), 'dddd MMMM yyyy') as Date
Select Format(getDate(), 'hh:mm:ss tt') as Time


----Create a function to return a string representation when date is passed as arg...
Create Function CreateDate(@date date)
RETURNS varchar(30)
AS
BEGIN
DECLARE @result varchar(30)
Set @result = '' + DATENAME(day, @date) + ' ' + DATENAME(MONTH, @date) + ' ' + DATENAME(year, @date)
RETURN @result
END
--DateName is a function used to get a part of a valid DateTime object. 
PRINT dbo.CreateDate(getDate());

--Create a Function which returns the age for a given Date. Use DATEDIFF Function....
Create Function GetAge(@dob date)
RETURNS INT
AS
BEGIN
DECLARE @age int = 0
Set @age = DATEDIFF(year, @dob, getDate())
RETURN @age
END

PRINT dbo.GetAge('01/12/1976')
