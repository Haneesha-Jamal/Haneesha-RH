create database Study
use Study

CREATE TABLE Employee (
    employee_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    date_of_birth DATE,
    department VARCHAR(100),
    salary DECIMAL(10, 2)
);
create table Departements (
DepartmentId int primary key ,
DepartmentName varchar(100),
EmployeeId int,
foreign key (EmployeeId) references Employee(employee_Id)
)

INSERT INTO Employee VALUES (1, 'John', 'Doe', '2023-01-30', 'Manager', 50000);
INSERT INTO Employee VALUES (2, 'Alice', 'Brown', '2022-08-28', 'Designer', 45000);

--Stored procedure
create procedure Studproc
@Employee_id int 
AS
begin
select top 1 * from Employee where employee_id  = @Employee_id;
end
exec Studproc @Employee_id = 2;


--Trigger 
create trigger UpdateLast
ON Employee
After Update
As
begin
update Employee set salary = 45867654 from Employee e
join inserted i on e.employee_id = i.employee_id;
end;

select * from Employee

