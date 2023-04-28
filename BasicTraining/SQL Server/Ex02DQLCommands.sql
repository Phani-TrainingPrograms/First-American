--DQL is called as Data Query Language part of the SQL which is used to perform data extractions from the database tables. 
--Display all records from the tbleEmployee
Use FaiTraining

SELECT * FROM tblEmployee

SELECT * FROM tblEmployee WHERE EmpSalary > 50000

Select EmpName, EmpSalary from tblEmployee

SELECT * FROM tblEmployee WHERE EmpSalary > (SELECT AVG(EmpSalary) FROM tblEmployee)

Select Max(EmpSalary) AS MaxSalary, MIN(EmpSalary) as MinSalary, AVG(EmpSalary) as AvgSalary, COUNT(EmpId) as TotalEmpCount From tblEmployee --AS is used to create a Alias to the expression....

Select TOP(5) EmpName from tblEmployee

SELECT TOP 25 Percent EmpName from tblEmployee

SELECT EMPNAME FROM tblEmployee ORDER BY EmpName --DESC, default is ASC(Ascending). DESC means Descending

SELECT Empname, EmpSalary From tblEmployee ORDER BY EmpSalary DESC

--Get the Bottom 25% of the Employees from the tblEmployee
SELECT * FROM
(SELECT TOP 25 PERCENT * From tblEmployee ORDER BY EmpId DESC) TEMP ORDER BY EmpId ASC

------------------------WHERE CLAUSE---------------------
Select * from tblEmployee Where CityId > 5
Select * from tblEmployee Where CityId <= 5

Select * from tblEmployee Where EmpName LIKE '%ra%'

Select EmpName from tblEmployee WHERE CityId = 4 OR CityId = 7
Select EmpName from tblEmployee WHERE CityId = 3 AND EmpSalary > 50000

-----------------------JOINS in SQL----------------------------
Select EmpName, CityName from tblEmployee JOIN tblCity on tblEmployee.CityId = tblCity.CityId


Insert into tblEmployee(EmpName, EmpSalary, EmpPhone, DeptId) 
VALUES('Aakash', 56000, 98798676576, 2)

Insert into tblEmployee(EmpName, EmpSalary, EmpPhone, DeptId) 
VALUES('Omkar', 76000, 234343424, 3)

Insert into tblEmployee(EmpName, EmpSalary, EmpPhone, DeptId) 
VALUES('Veeresh', 36000, 4567887554, 4)

Insert into tblEmployee(EmpName, EmpSalary, EmpPhone, DeptId) 
VALUES('Abhisek', 76000, 2342423567, 5)

Insert into tblEmployee(EmpName, EmpSalary, EmpPhone, DeptId) 
VALUES('Sahana', 66000, 879465135, 6)

Insert into tblEmployee(EmpName, EmpSalary, EmpPhone, DeptId) 
VALUES('Harishankar', 86000, 46578985823, 4)

Insert into tblEmployee(EmpName, EmpSalary, EmpPhone, DeptId) 
VALUES('Faizal', 60000, 4415568897, 6)

Select * from tblEmployee Where CityId is NULL

Insert into tblCity values('Vadodara')
Insert into tblCity values('Nagpur')
--Add unique constraint to the tblCity so that we dont need duplicate City names
Alter table tblCity
ADD UNIQUE (CityName)

Update tblEmployee
Set CityId = NULL Where EmpId = 1005

-----------LEFT JOINS------------------------------
Select tblEmployee.*, tblCity.CityName from tblEmployee
LEFT JOIN tblCity ON tblEmployee.CityId = tblCity.CityId

-------------RIGHT JOIN-----------------------
Select tblEmployee.*, tblCity.CityName from tblEmployee
RIGHT JOIN tblCity ON tblEmployee.CityId = tblCity.CityId

-----------Get the Cityname and the max salary for each city using GROUP BY CLAUSE...
Select tblCity.CityName, MAX(tblEmployee.EmpSalary) as MaxSalary from tblEmployee RIGHT JOIN tblCity ON tblCity.CityId = tblEmployee.CityId
GROUP BY tblCity.CityName 

--Getting the EmpName, DeptName and CityName for each Employee
Select tblEmployee.EmpName, tblDept.DeptName, tblCity.CityName
from tblEmployee RIGHT JOIN tblDept
ON tblEmployee.DeptId = tblDept.DeptId
RIGHT JOIN tblCity ON tblEmployee.CityId = tblCity.CityId

--Get the EmpName who has the Max salary from each Dept and city from where he comes from. 

--Get the EmpCount of each dept. 
Select tblDept.DeptName, COUNT(tblEmployee.EmpId) as EmpCount
From tblEmployee RIGHT JOIN tblDept
ON tblEmployee.DeptId = tblDept.DeptId
GROUP BY tblDept.DeptName
ORDER BY EmpCount DESC

--Get the Total Salaries of each Dept.

--Get the Employee Count of the Employees based on Salary which comes b/w 50000 to 75000
Select Count(tblEmployee.EmpId) as EmpCount, tblEmployee.EmpSalary from tblEmployee Group by EmpSalary
Having EmpSalary between 50000 and 75000

--Get the Employees whose Salary is greater than the Avg Salary of his Dept.
 
