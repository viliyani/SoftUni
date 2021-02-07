-- ### Tasks for Softuni database

-- Task
SELECT FirstName, LastName
	FROM Employees
	WHERE FirstName LIKE 'SA%';

-- Task
SELECT FirstName, LastName
	FROM Employees
	WHERE LastName LIKE '%ei%';

-- Task
SELECT FirstName
	FROM Employees
	WHERE
		DepartmentID IN (3, 10) AND
		(HireDate >= '1995-01-01' AND HireDate <= '2005-01-01');	  

-- Task
SELECT FirstName, LastName
	FROM Employees
	WHERE JobTitle NOT LIKE '%engineer%';

-- Task
SELECT [Name]
	FROM Towns
	WHERE LEN([Name]) = 5 OR LEN([Name]) = 6
	ORDER BY [Name] ASC;

-- Task
SELECT [Name]
	FROM Towns
	WHERE LEFT([Name], 1) IN ('M', 'K', 'B', 'E')
	ORDER BY [Name] ASC;

-- Task
SELECT [Name]
	FROM Towns
	WHERE NOT LEFT([Name], 1) IN ('R', 'B', 'D')
	ORDER BY [Name] ASC;

-- Task
SELECT FirstName, LastName
	FROM Employees
	WHERE LEN(LastName) = 5;

-- Task
SELECT EmployeeID, FirstName, LastName, Salary,
	DENSE_RANK() OVER (ORDER BY Salary DESC) AS [Rank]
	FROM Employees
	WHERE Salary >= 10000 AND Salary <= 50000
	ORDER BY Salary DESC;



-- ### Tasks for Geography database 

-- Task
SELECT CountryName, IsoCode
	FROM Countries
	WHERE LOWER(CountryName) LIKE '%a%a%a%'
	ORDER BY IsoCode ASC;

-- Task
SELECT PeakName, RiverName, LOWER(PeakName + RiverName) as Mix 
	FROM Peaks, Rivers
	WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
	ORDER BY Mix ASC;


-- ### Tasks for Diablo databse

-- Task
SELECT TOP(50) [Name], FORMAT([Start], 'yyyy-MM-dd', 'bg-BG') AS [Start]
	FROM [Games]
	WHERE DATEPART(YEAR, [Start]) BETWEEN 2011 AND 2012
	ORDER BY [Start], [Name];

-- Task
SELECT 
	Username, 
	SUBSTRING(
		Email, 
		CHARINDEX('@', Email) + 1, 
		LEN(Email) - CHARINDEX('@', Email)
	) AS [Email Provider]
	FROM Users
	ORDER BY [Email Provider], Username;

-- Task
SELECT Username, IpAddress 
	FROM Users
	WHERE IpAddress LIKE ('[0-9][0-9][0-9].[1]%.[0-9][0-9][0-9]')
	ORDER BY Username;

-- Task
SELECT 
	[Name],
	CASE
		WHEN DATEPART(HOUR, [Start]) BETWEEN 0 AND 11 THEN 'Morning'
		WHEN DATEPART(HOUR, [Start]) BETWEEN 12 AND 17 THEN 'Afternoon'
		WHEN DATEPART(HOUR, [Start]) BETWEEN 18 AND 23 THEN 'Evening'
	END AS [Part of the Day],
	CASE
		WHEN Duration <= 3 THEN 'Extra Short'
		WHEN Duration BETWEEN 4 AND 6 THEN 'Short'
		WHEN Duration > 6 THEN 'Long'
		ELSE 'Extra Long'
	END AS [Duration]
			FROM Games
				ORDER BY [Name], Duration

