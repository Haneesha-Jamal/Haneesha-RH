use EMP_DB

CREATE TABLE emppp (
    employee_id INT,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    salary DECIMAL(10, 2)
);

insert into emppp values (1,'Haneesha','RH',50000.0)
insert into emppp values (2,'Hashir','RH',60000.0)
insert into emppp values (3,'John','smith',45000.0)

--in-Built functions
--Aggregate function
SELECT SUM(salary) As total_salary from emppp
SELECT AVG(salary) As average_salary from emppp
SELECT COUNT(employee_id) AS num_of_employ from emppp
SELECT MAX(salary) AS highest_salary from emppp
SELECT MIN(salary) AS lowest_salary from emppp

--scalar function

SELECT UPPER(first_name) AS uppercase_name FROM emppp;
SELECT LOWER(first_name) AS lowercase_name FROM emppp;
SELECT LEN(first_name) AS name_length FROM emppp;
SELECT ROUND(salary, 2) AS rounded_salary FROM emppp;
SELECT ABS(salary - 50000) AS difference_from_50000 FROM emppp;

--string functions

SELECT CONCAT(first_name, ' ', last_name) AS full_name FROM emppp;
SELECT SUBSTRING(first_name, 1, 3) AS short_name FROM emppp;
SELECT REPLACE(first_name, 'a', '0') AS modified_name FROM emppp;
SELECT LTRIM('   John') AS trimmed_name;
SELECT RTRIM('Doe   ') AS trimmed_name;

--DATE functions 

SELECT GETDATE() AS current_date_time;
SELECT DATEADD(day, 10, GETDATE()) AS date_plus_10_days;
SELECT DATEDIFF(day, '2023-01-01', GETDATE()) AS days_since_start_of_year;
SELECT DATEPART(year, GETDATE()) AS current_year;
SELECT FORMAT(GETDATE(), 'yyyy-MM-dd') AS formatted_date;

--mathematica function

SELECT SQRT(25) AS square_root;
SELECT POWER(5, 3) AS power_result;
SELECT CEILING(4.2) AS ceiling_value;
SELECT FLOOR(4.8) AS floor_value;
SELECT RAND() AS random_number;

--User defined function
--tabular function 

CREATE FUNCTION HighSalaryEmployee(@threshold DECIMAL(10,2))
RETURNS TABLE
AS
RETURN 
(
select employee_id,first_name,last_name,salary
from emppp
where salary > @threshold
)
select * from HighSalaryEmployee(50000.0)

--scalar function
create function CalculateAnnualSalary(@employee_id int)
RETURNS decimal(10,2)
AS
BEGIN
DECLARE @monthly_salary DECIMAL(10,2)
DECLARE @annual_salary DECIMAL(10,2)

SELECT @monthly_salary = salary
from emppp
where employee_id = @employee_id
set @annual_salary = @monthly_salary*12
return @annual_salary
END


