use EMP_DB

--SQL code is to automatically log changes made to the employees table into the employees_audit table.

CREATE TABLE employees (
    employee_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    salary DECIMAL(10, 2)
);

CREATE TABLE employees_audit (
    audit_id INT IDENTITY(1,1) PRIMARY KEY,
    employee_id INT,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    salary DECIMAL(10, 2),
    operation VARCHAR(10),
    operation_date DATETIME DEFAULT GETDATE()
);
-- To store a record of changes made to the employees


CREATE TRIGGER after_employee_update
ON employees
AFTER UPDATE
AS
BEGIN
    INSERT INTO employees_audit (employee_id, first_name, last_name, salary, operation, operation_date)
    SELECT d.employee_id, d.first_name, d.last_name, d.salary, 'UPDATE', GETDATE()
    FROM deleted d;
END;

--To automatically insert a record into the employees_audit table whenever an UPDATE operation is performed on the employees table.
--AFTER UPDATE: The trigger fires after an update operation.
--deleted table: SQL Server provides a special deleted table that contains the old values of the updated rows.
--INSERT INTO employees_audit: Inserts a new record into the employees_audit table.
--SELECT ... FROM deleted: Selects the old values from the deleted table to insert into the employees_audit table.
--It also sets the operation column to 'UPDATE' and the operation_date column to the current date and time using GETDATE().

INSERT INTO employees (employee_id, first_name, last_name, salary)
VALUES (1, 'John', 'Doe', 50000.00);
--To add an initial employee record to the employees table.

UPDATE employees
SET salary = 55000.00
WHERE employee_id = 1;
--To change the salary of the employee with employee_id 1. 
--This action triggers the after_employee_update trigger, which logs the change in the employees_audit table.

SELECT * FROM employees_audit;

--This logic ensures that every update to the employees table is recorded in the employees_audit table,
--providing a complete history of changes for auditing purposes.





