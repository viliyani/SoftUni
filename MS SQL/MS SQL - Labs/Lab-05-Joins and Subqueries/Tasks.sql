use Softuni;

-- Task 1
SELECT e.FirstName, e.LastName, t.Name as Town, a.AddressText
	FROM Employees e
	LEFT JOIN Addresses a ON e.AddressID = a.AddressID
	LEFT JOIN Towns t ON a.TownID = t.TownID
	ORDER BY FirstName, LastName;


-- Task 2
SELECT * 
	FROM Employees e
		INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'
	ORDER BY e.EmployeeID;


-- Task 3
SELECT * 
	FROM Employees e
		INNER JOIN Departments d ON e.DepartmentID = d.DepartmentID
	WHERE e.HireDate > '1999-01-01' AND
			(d.Name = 'Sales' OR d.Name = 'Finance')
	ORDER BY e.EmployeeID;


-- Task 4
SELECT * 
	FROM Employees e
		LEFT JOIN Employees m ON e.ManagerID = m.EmployeeID
		LEFT JOIN Departments d ON e.DepartmentID = d.DepartmentID
	ORDER BY e.EmployeeID;


-- Task 5
SELECT
	(SELECT AVG(Salary)
		FROM Employees
		WHERE DepartmentID = d.DepartmentID) as AvgSalary
	FROM Departments d
	WHERE (SELECT COUNT(*) FROM Employees WHERE DepartmentID = d.DepartmentID) > 0
	ORDER BY AvgSalary ASC
