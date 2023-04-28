-- SQL server is the database used for Applications with high robustness and well trusted security. 
-- Create command is used to create the database. U should be having rights to access the Master database which is the root database of SQL server. The Master database contains previlages and security features that allows a certain User to create/drop or update databases of the server. 

Create Database FaiTraining
Go -- Go Command is used to execute the statements in a batchwise manner. 
Use FaiTraining
Go
-- Drop command is used to delete an SQL object. This might include a database, table, stored Proc, function or any other DB object. U cannot drop an using database, U must leave the database by selecting Master and then drop the database. 

Use master
Drop Database FaiTraining

-- SQL server is a Software that contains multiple databases in it. It has a set of databases to manage the server. 
--Master database contains the tables of security, Data managers and required entities for the Management of the server. 
--Model database contains the common schemas used in the SQL server instance. 
--tempDB database is a temp database available to create Temp Tables for a brief period of time. The tables of the temp db will be deleted automatically if the server is shut down.
--msdb is the database used for stored Db objects used in the SQL server instance.

--For commonly used operations, we have predefined statements called Stored Procedures. Likewise, SQL server has some ready to used Stored proces that can be used for getting info about the tables and databases of the Server instance. 
sp_databases -- Used to get the list of all the databases available in the Server. 

sp_tables -- used to get the list of the tables created in the selected database

sp_columns tblEmployee -- Used to get the list of all colums of the associated table

Create table tblEmployee
(
	EmpId int Primary key, 
	EmpName varchar(50) NOT NULL, 
	EmpAddress varchar(200) NOT NULL, 
	EmpSalary money NOT NULL
)

Drop table tblEmployee --Used to delete the table from the database

Create table tblEmployee
(
	EmpId int primary key identity(1001, 1),
	EmpName varchar(50) NOT NULL,
	EmpAddress varchar(MAX) NOT NULL, 
	EmpPhone bigint NOT NULL,
	EmpSalary money NOT NULL
)--SQL is case insensitive. 

Create table tblDept
(
  DeptId int primary key identity(1, 1),
  DeptName varchar(50) NOT NULL
)

--Alter is used to modify the structure of the db object. 
Alter table tblEmployee
Add DeptId int 
References tblDept(DeptId)

Alter table tblEmployee
--DROP CONSTRAINT FK__tblEmploy__DeptI__33D4B598
Drop column DeptId

sp_columns tblEMployee

-----------Inserting records into the table
Insert into tblDept values('Training')
Insert into tblDept values('Development')
Insert into tblDept values('DevOps')
Insert into tblDept values('QA')
Insert into tblDept values('Human Resources')
Insert into tblDept values('Services')

Insert into tblEmployee values('Vinod Kumar','Shimoga', 9445202145, 67000, 1)
Insert into tblEmployee values('Banu Prakash','Mysore', 2342445667, 45000, 2) --Insert the values in the order of the Columns of the table. 

Insert into tblEmployee(EmpName, EmpAddress, EmpSalary, EmpPhone, DeptId) Values('JoyDip Mondal','Calcutta', 66000, 9845234355, 4)--Inserting the values in different order of columns. However, the constraints are still applicable. 

Insert into tblEmployee values('Ramnath Nishad','Gorakhpur', 9956422345, 67000, 3)

Insert into tblEmployee values('Robin Swarth','Rome', 4544829635, 89000, 4)

--Update the tblEmployee with EmpAddress as new Delhi whose Address now is Gora

Update tblEmployee
Set EmpAddress = 'Bangalore', EmpSalary = 125000 Where EmpAddress = 'New Delhi' 

Delete From tblEmployee Where EmpId = 1001

Select * from tblEmployee

----------------------Assignment-----------------
-- Create a new Table called tblCity with Id and CityName as Columns. Add some 10 Cities to it. 
-- Remove the EmpAddress from the tblEmployee.
--Add a New Column into the tblEmployee that has CityId as FK
--Update the CityId of the tblEmployee with a random no that satisfies the FK Constraint. 

Create table tblCity
(
	CityId int primary key identity(1,1),
	CityName varchar(50) NOT NULL
)


Select * from tblCity
--Use the IDENTITY_INSERT if U want to explicity set the Values to the Identity column of the table. In that case, the insert statement must have the column list also
SET IDENTITY_INSERT tblCity ON
Insert into tblCity(CityId, CityName) Values(123, 'Dharwad')
SET IDENTITY_INSERT tblCity OFF

Insert into tblCity Values('Madras')
Insert into tblCity Values('Bombay')
Insert into tblCity Values('Calcutta')
Insert into tblCity Values('New Delhi')
Insert into tblCity Values('Hyderabad')
Insert into tblCity Values('Poona')
Insert into tblCity Values('Chandigarh')
Insert into tblCity Values('Amritsar')
Insert into tblCity Values('Lucknow')
Insert into tblCity Values('Patna')

--Drop the Column EmpAddress from the tblEmployee
Alter table tblEmployee
DROP COLUMN EmpAddress

Alter Table tblEmployee
Add CityId int REFERENCES tblCity(CityId)

SElect Count(*) from tblCity
sp_columns tblEmployee

--Any variable declarations in SQL server can be done using declare statement. 
-- The name of the variable should be prefixed with @ followed by the varname and the data type that U want to associate with it. U can also optionally assign value to it. Set keyword is used to set the value for a variable in SQL Server. 
--Declare @Id int
--Set @Id = 234
--PRINT @Id

--SQL Server itself has some variables and consts in it. They are prefixed with @@ 

PRINT @@VERSION

SET IDENTITY_INSERT tblCity OFF
Insert into tblCity values('Vizag')
PRINT @@IDENTITY --Contains the value of the newly inserted row's identity Column

DELETE FROM tblCity WHERE CityId >= 123

SELECT MAX(CityId) from tblCity

DECLARE @Id int = (SELECT MIN(EmpId) FROM tblEmployee)
DECLARE @CityCount int = (SELECT COUNT(*) FROM tblCity)
WHILE @id <= (SELECT MAX(EmpId) FROM tblEmployee)
BEGIN
	Update tblEmployee
	Set CityId = RAND() * (@CityCount - 1) + 1
	Where EmpId = @Id
	Set @Id = @Id + 1
END

Select CityId from tblEmployee
SELECT EmpId from tblEmployee