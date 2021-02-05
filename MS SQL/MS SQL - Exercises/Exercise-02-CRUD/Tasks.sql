-- ### Tasks for Softuni database

-- Task
SELECT * FROM Departments;

-- Task
SELECT [Name] FROM Departments;

-- Task
SELECT FirstName, LastName, Salary
	FROM Employees;

-- Task
SELECT FirstName, MiddleName, LastName
	FROM Employees;

-- Task
SELECT FirstName + '.' + LastName + '@softuni.bg' as [Full Email Address]
	FROM Employees;

-- Task
SELECT DISTINCT Salary
	FROM Employees;

-- Task
SELECT *
	FROM Employees
	WHERE JobTitle = 'Sales Representative';

-- Task
SELECT FirstName, LastName, JobTitle
	FROM Employees
	WHERE Salary >= 20000 AND Salary <= 30000;

-- Task
SELECT FirstName + ' ' + MiddleName + ' ' + LastName as [Full Name]
	FROM Employees
	WHERE Salary IN (25000, 14000, 12500, 23600);

-- Task
SELECT FirstName, LastName, ManagerID
	FROM Employees
	WHERE ManagerID IS NULL;

-- Task
SELECT FirstName, LastName, Salary
	FROM Employees
	WHERE Salary >= 50000
	ORDER BY Salary DESC;

-- Task
SELECT TOP(5) FirstName, LastName
	FROM Employees
	ORDER BY Salary DESC;

-- Task
SELECT FirstName, LastName
	FROM Employees
	WHERE DepartmentID != 4;

-- Task
SELECT *
	FROM Employees
	ORDER BY Salary DESC, FirstName ASC, LastName DESC, MiddleName ASC;

-- Task - VIEWs must to be in new file
CREATE VIEW V_EmployeesSalaries AS
SELECT FirstName, LastName, Salary
	FROM Employees;

-- Task - VIEWs must to be in new file
CREATE VIEW V_EmployeeNameJobTitle AS
SELECT FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName as [Full Name], JobTitle
	FROM Employees;

-- Task
SELECT DISTINCT JobTitle
	FROM Employees;

-- Task
SELECT TOP(5) *
	FROM Projects
	ORDER BY StartDate ASC, [Name] ASC;

-- Task
SELECT TOP(7) FirstName, LastName, HireDate
	FROM Employees
	ORDER BY HireDate DESC;

-- Task
SELECT *
	FROM Employees
	WHERE DepartmentID IN (1,2,4,11);

UPDATE Employees
	SET Salary *= 1.12
	WHERE DepartmentID IN (1,2,4,11);


-- ### Tasks for Geography database

-- Task
SELECT PeakName
	FROM Peaks
	ORDER BY PeakName ASC;

-- Task
SELECT TOP(30) CountryName, [Population]
	FROM Countries
	WHERE ContinentCode = 'EU'
	ORDER BY [Population] DESC, CountryName DESC;

-- Task
SELECT CountryName, CountryCode,
		CASE
			WHEN CurrencyCode = 'EUR' THEN 'Euro'
			ELSE 'Not Euro'
		END
	FROM Countries
	ORDER BY CountryName ASC;


-- ### Tasks for Diablo table
SELECT [Name]
	FROM  Characters
	ORDER BY [Name] ASC;