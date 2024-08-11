CREATE TABLE Departments (
  department_id INT PRIMARY KEY,
  department_name VARCHAR(50) NOT NULL
);

CREATE TABLE Employees (
  employee_id INT PRIMARY KEY,
  name VARCHAR(50) NOT NULL,
  age INT,
  email VARCHAR(100) UNIQUE NOT NULL,
  salary DECIMAL(10, 2),
  department_id INT,
  FOREIGN KEY (department_id) REFERENCES Departments(department_id)
);

CREATE TABLE Projects (
  project_id INT PRIMARY KEY,
  project_name VARCHAR(100) NOT NULL,
  start_date DATE,
  end_date DATE
);

CREATE TABLE EmployeeProjects (
  employee_id INT,
  project_id INT,
  FOREIGN KEY (employee_id) REFERENCES Employees(employee_id),
  FOREIGN KEY (project_id) REFERENCES Projects(project_id)
);


INSERT INTO Departments (department_id, department_name) 
VALUES 
(1, 'Sales'),
(2, 'Marketing'),
(3, 'IT');


INSERT INTO Employees (employee_id, name, age, email, salary, department_id) 
VALUES 
(1, 'John Doe', 30, 'john.doe@example.com', 50000.00, 1),
(2, 'Jane Smith', 25, 'jane.smith@example.com', 60000.00, 2),
(3, 'Bob Johnson', 40, 'bob.johnson@example.com', 70000.00, 3),
(4, 'Alice Brown', 28, 'alice.brown@example.com', 55000.00, 1),
(5, 'Mike Davis', 35, 'mike.davis@example.com', 65000.00, 2);


INSERT INTO EmployeeProjects (employee_id, project_id) 
VALUES 
(1, 1),
(2, 2),
(3, 3);


INSERT INTO Projects (project_id, project_name, start_date, end_date) 
VALUES 
(1, 'Project 1', '2022-01-01', '2022-06-30'),
(2, 'Project 2', '2022-02-01', '2022-07-31'),
(3, 'Project 3', '2022-03-01', '2022-08-31');

--join
SELECT e.name, d.department_name ,p.project_name
from Employees e
join Departments d on e.department_id = d.department_id
join EmployeeProjects ep on e.employee_id = e.employee_id
join Projects p on ep.project_id = p.project_id

--union
SELECT department_name from Departments
union
select project_name from Projects

SELECT UPPER(department_name)
FROM Departments
UNION
SELECT UPPER(project_name)
FROM Projects;

--group by order by
select d.department_name, count(e.employee_id) as num_employees
from Employees e
join Departments d on e.department_id = d.department_id
group by d.department_name
order by d.department_name

--login and user , grant,revoke
CREATE LOGIN viewer WITH PASSWORD = 'password';
use Study
create user viewer for LOGIN viewer

GRANt SELECT ON Employees to viewer
revoke select on Employees to viewer

--trigger

create trigger min_salary 
on Employees
after insert,update
as
begin
update e set e.salary = 3000.0 from Employees e
join inserted i on e.employee_id = i.employee_id
where i.salary < 3000.0
end

--Stored procedure
create procedure GetEmployeeCountByDepartment
@DeptId int
As
Begin 
declare @employee_id int ;
select @employee_id = count(*) from Employees
where department_id = @DeptId
select @employee_id as TotalEmployee
End
EXEC GetEmployeeCountByDepartment @DeptId = 2; 

--function
create function GetEmployeeFullNameAndEmail(@EmployeeId int)
returns varchar(max)
As
Begin
declare @FullName varchar(max)
declare @Email varchar(max)
select @FullName = name, @Email = email from Employees
where employee_id = @EmployeeId
declare @Result varchar(max)=CONCAT(@FullName,'-',@Email);
return @Result;
end;
DECLARE @EmployeeInfo NVARCHAR(MAX);
SET @EmployeeInfo = dbo.GetEmployeeFullNameAndEmail(2); 
PRINT @EmployeeInfo;
