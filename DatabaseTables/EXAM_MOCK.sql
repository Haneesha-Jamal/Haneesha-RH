CREATE DATABASE EXAM
USE EXAM

--DDL
CREATE TABLE Employees(emp_Id int primary key,firstname varchar(50),lastname varchar(50),salary decimal(10,2),HireDate date)
Alter table Employees Add Departement varchar(50) 

exec sp_rename 'Employees', 'Staff'
Select * from Staff

ALTER TABLE Staff DROP COLUMN HireDate;

--DML
insert into Staff values(1,'John','Deo',50000,'IT')
insert into Staff values(2,'Jane','Smith',60000,'HR')
insert into Staff values(3,'Mike','Johnson',70000,'Sales')
select *  from Staff

update Staff set salary = 65000 where emp_id = 2

delete from Staff where lastname = 'Johnson'

select * from Staff where salary > 55000

update Staff set salary = (salary*10/100)+salary  where Departement = 'IT'

select * from Staff

--DCL
create login A with password = 'data123'
create user analyst for login A

GRANT SELECT ,INSERT on Staff to analyst 
revoke insert on Staff to analyst

create Role Manager 
Grant update , delete on Staff to Manager




