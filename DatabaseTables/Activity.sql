create database activity
use activity
create table activitytable(id int primary key,name varchar(50))
select * from activitytable
insert into activitytable values(1,'Haneesha')
insert into activitytable values(2,'Ani')
insert into activitytable values(3,'fgednjm')
insert into activitytable values(4,'cbhnxm')
select * from activitytable

CREATE TABLE EMPLOYEE (EmpNo BIGINT,EmpName varchar(50),DepNo BIGINT ,Job varchar(50),HireDate datetime)
insert into EMPLOYEE values(2000,'Suresh',2312456,'Sales Executive',11-5-2030)
insert into EMPLOYEE values(3000,'Rahul',2334456,'Sales Executive',3-5-2030)
select * from EMPLOYEE
CREATE TABLE DEPT (DeptNo BIGINT ,DeptName varchar(20) ,Loc varchar(20))

CREATE TABLE TS_Company_Master(Id int,Name varchar(50),Remarks int)
CREATE TABLE TS_Group_Master(Id int,Name varchar(50),Remarks int)
CREATE TABLE TS_Item_Master(Id int,Name varchar(50),Company_Id int ,Group_Id int,Rate int,Remarks int)
CREATE TABLE TS_Purchase_Header(Id int,Name varchar(50),Remarks int)
CREATE TABLE TS_Purchase_Detail(Id int,Header_Id int,SI_no int,Item_Id int,Qty int,rate int,amount int)

insert into TS_Company_Master values(1,'P&G','')
insert into TS_Company_Master values(2,'Xenical','')
insert into TS_Company_Master values(3,'J&J','')
insert into TS_Company_Master values(4,'JAC','')
SELECT * FROM TS_Company_Master

insert into TS_Group_Master values(1,'INHAILER','')
insert into TS_Group_Master values(1,'DROPS','')
insert into TS_Group_Master values(1,'POWDER','')
insert into TS_Group_Master values(1,'OINTMENT','')
SELECT * FROM TS_Group_Master

INSERT INTO TS_Purchase_Header VALUES(1,'CAR',23)
SELECT * FROM TS_Purchase_Header

delete from TS_Company_Master
delete from TS_Company_Master where id=1
delete from TS_Group_Master where name='INHAILER'

UPDATE TS_Company_Master SET Name='P&G' where id=2
UPDATE EMPLOYEE SET EmpName=(SELECT EmpName FROM EMPLOYEE WHERE EmpNo=2000)

select Id,Name into Copy_Group from TS_Group_Master
SELECT * INTO Copy_TS_Group_Master from TS_Group_Master
select * from Copy_TS_Group_Master

ALTER TABLE TS_Purchase_Header alter column Remarks int
alter table TS_Purchase_Header add Results int

exec sp_rename TS_Purchase_Header,TS_Purchase
select * from TS_Purchase

exec Sp_renamedb activity,Sample
use Sample
////////////////////////////////////////////////////

CREATE TABLE TS_Company_Master(Id int,Name varchar(50),Remarks int)

insert into TS_Company_Master values(1,'P&G','')
insert into TS_Company_Master values(2,'Xenical','')
insert into TS_Company_Master values(3,'J&J','')
insert into TS_Company_Master values(4,'JAC','')
SELECT * FROM TS_Company_Master

select * from TS_Company_Master where Name like '%a%' 
select * from TS_Company_Master where Name like 'j%' 
select * from TS_Company_Master where Name like '%j' 
select * from TS_Company_Master where Name like '_a%'

select Id,Name,Remarks from TS_Company_Master
Union
select Id,Name,Remarks from TS_Group_Master

select Id,Name  from TS_Company_Master
Union All
select Id,Name from TS_Group_Master

select * from TS_Company_Master,TS_Group_Master

select ABS (-1.0) -- Value = 1.0
select ABS (0.0) -- Value = 0.0
select ABS (1.0) -- Value = 1.0

select FLOOR (32.15) -- Value = 33
select FLOOR (-32.15) -- Value = -32
select FLOOR ($32.15) -- Value = 33.00

select CEILING (32.15) -- Value = 33
select CEILING (-32.15) -- Value = -32
select CEILING ($32.15) -- Value = 33.00

select ROUND (32.15,1) -- Value = 32.20
select ROUND (32.14,1) -- Value = 33.10
select ROUND (32.14998,4) -- Value = 32.15000

select AVG(Salary) FROM A


//////////////////////////////////////////////////////////////////


CREATE proc TS_Company_Master_insert(@Name as varchar(50),@Remarks as int)
as
declare @Id as int 
begin 
select @Id = (select isnull(max(Id),0)+1 from TS_Company_Master)
insert into TS_Company_Master(Id,Name,Remarks)values(@Id,@Name,@Remarks)
end
Go
exec TS_Company_Master_insert 'Lion', ''
select * from TS_Company_Master


CREATE PROC TS_Company_Master_Update(@Id as int,@Name as varchar(50),@Remarks as varchar(250))
as
begin 
UPDATE TS_Company_Master SET Name = @Name,@Remarks = @Remarks WHERE Id = @Id
END
GO
EXEC TS_Company_Master_Update 5,'ocm',''
SELECT*FROM TS_Company_Master



Alter PROC TS_Company_Master_Delete @Id as int
as
begin
delete from TS_Company_Master where id =@Id
end
GO

exec TS_Company_Master_Delete  @Id=1


CREATE PROC SelectProc2(@Id as int)
As
Begin
select * from TS_Company_Master where id = @Id
End
EXEC SelectProc2 4

CREATE PROC SelectProc4(@Name as varchar(50))
As
Begin
select * from TS_Company_Master where Name = @Name
End
EXEC SelectProc4 'JAC'

CREATE PROC SelectPro6(@Name varchar(50)=Null)
As
Begin
select * from TS_Company_Master where Name = @Name
END
Go
Exec SelectPro6 



CREATE PROC SelectProc8
As
Begin
EXEC SelectProc4
END
GO
EXEC SelectProc8 
