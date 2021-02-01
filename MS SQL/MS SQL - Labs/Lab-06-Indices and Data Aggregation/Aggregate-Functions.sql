-- Task 1
SELECT 
	d.Name, COUNT(*) as Count, SUM(Salary) as SalarySum
	FROM Employees e
	JOIN Departments d ON e.DepartmentID = d.DepartmentID
	GROUP BY d.Name
	ORDER BY SalarySum DESC;


-- Task 2
SELECT 
	DepartmentID, MIN(Salary) as MinSalary
	FROM Employees
	GROUP BY DepartmentID


-- Task 3
SELECT 
		DepartmentID, 
		MIN(Salary) as MinSalary,
		STRING_AGG(Salary, '--')
	FROM Employees
	ORDER BY DepartmentID;


-- Task 4
SELECT 
	DepartmentID, SUM(Salary) as TotalSalary
	FROM Employees
	GROUP BY DepartmentID
	HAVING SUM(Salary) > 150000;
