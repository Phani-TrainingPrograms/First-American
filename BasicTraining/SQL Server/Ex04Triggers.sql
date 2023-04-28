--Triggers are like events of SQL Server. They are sp kind of stored Procedures that are invoked automatically when an insert, delete or an update operation happens to a table in the database. 
--They are usually created to automate processes within the databases after a certain operation is done by the users of the database. They are used to auto create backup data after a certain period of insertions are done, or updations or any DML 

Create table tblCustomer
(
CstId int primary key, 
CstName varchar(50) NOT NULL, 
CstAddress varchar(200) NOT NULL, 
BillDate Date Default GetDate(),
BillAmount money
)
--For triggering purpose
Create table Customer_Audit
(
	EntryId int primary key identity(1,1),
	Details varchar(200) NOT NULL 
)

Create Trigger OnInsertCustomer ON tblCustomer
FOR INSERT
AS
BEGIN
DECLARE @id int
Select @id = CstId from inserted --inserted is the reference of the row U have inserted in the tblCustomer
Insert into Customer_Audit VALUES
(CAST(@id as varchar) + ' is inserted into the database on ' + dbo.CreateDate(GETDATE()) + '')
END

Insert into tblCustomer(CstId, CstName, CstAddress, BillAmount) values(111, 'Phaniraj', 'Bangalore', 5600)

Create Trigger OnDeleteCustomer on tblCustomer AFTER DELETE
AS
BEGIN
  DECLARE @id int 
  Select @id = CstId from deleted
  Insert into Customer_Audit values(CAST(@id as varchar) + ' is deleted from the database on ' + CAST(GETDATE() as varchar(50)))
END

--Implement Update Trigger for tblCustomer 
Delete From tblCustomer where CstId = 111
Select * from Customer_Audit
Select * from tblCustomer