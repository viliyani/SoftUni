-- ### Tasks for Softuni database

-- Task
SELECT TOP(5) 
		e.EmployeeID, e.JobTitle, a.AddressID, a.AddressText
	FROM Employees e
		INNER JOIN Addresses a ON e.AddressID = a.AddressID
	ORDER BY e.AddressID ASC;

-- Task
SELECT TOP(50) 
		e.FirstName, e.LastName, t.[Name] AS Town, a.AddressText
	FROM Employees e
		INNER JOIN Addresses a ON e.AddressID = a.AddressID
		INNER JOIN Towns t ON a.TownID = t.TownID
	ORDER BY e.FirstName ASC, e.LastName ASC;

-- Task
SELECT e.EmployeeID, e.FirstName, e.LastName, d.[Name] as DepartmentName
	FROM Employees e
		JOIN Departments d ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'
	ORDER BY e.EmployeeID ASC;

-- Task
SELECT TOP(5) e.EmployeeID, e.FirstName, e.Salary, d.[Name] AS DepartmentName
	FROM Employees e
		JOIN Departments d ON e.DepartmentID = d.DepartmentID
	WHERE e.Salary > 15000
	ORDER BY e.DepartmentID ASC;

-- Task 
SELECT TOP(3) e.EmployeeID, e.FirstName
	FROM Employees e
		LEFT JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID
	WHERE ep.EmployeeID IS NULL
	ORDER BY e.EmployeeID ASC;

-- Task
SELECT e.FirstName, e.LastName, e.HireDate, d.[Name] AS DeptName
	FROM Employees e
		JOIN Departments d ON e.DepartmentID = d.DepartmentID
	WHERE 
		d.[Name] IN ('Sales', 'Finance')
		AND e.HireDate > '1999-01-01'
	ORDER BY e.HireDate ASC;

-- Task
SELECT TOP(5) e.EmployeeID, e.FirstName, p.[Name] AS ProjectName
	FROM Employees e
		JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID
		JOIN Projects p ON ep.ProjectID = p.ProjectID
	WHERE p.StartDate > '2002-08-13' AND p.EndDate IS NULL
	ORDER BY e.EmployeeID ASC;

-- Task
SELECT TOP(5) e.EmployeeID, e.FirstName,
				CASE 
					WHEN YEAR(p.StartDate) >= 2005 THEN NULL
					ELSE p.Name
				END AS ProjectName
	FROM Employees e
		JOIN EmployeesProjects ep ON e.EmployeeID = ep.EmployeeID
		JOIN Projects p ON ep.ProjectID = p.ProjectID
	WHERE e.EmployeeID = 24
	ORDER BY e.EmployeeID ASC;

-- Task
SELECT e.EmployeeID, e.FirstName, m.EmployeeID as ManagerID, m.FirstName
	FROM Employees e
		JOIN Employees m ON e.ManagerID = m.EmployeeID
	WHERE e.ManagerID IN (3, 7)
	ORDER BY e.EmployeeID ASC;

-- Task
SELECT e.EmployeeID, e.FirstName, m.FirstName as ManagerName, d.Name AS DepartmentName
	FROM Employees e
		JOIN Employees m ON e.ManagerID = m.EmployeeID
		JOIN Departments d ON d.DepartmentID = e.DepartmentID
	ORDER BY e.EmployeeID ASC;

-- Task
SELECT TOP(1) (SELECT AVG(Salary) FROM Employees e WHERE e.DepartmentID = d.DepartmentID) AS MinAverageSalary
	FROM Departments d
	ORDER BY MinAverageSalary ASC;


-- ### Tasks for Geography database

-- Task
SELECT c.CountryCode, m.MountainRange, p.PeakName, p.Elevation
	FROM Countries c
		JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
		JOIN Mountains m ON m.Id = mc.MountainId
		JOIN Peaks p ON m.Id = p.MountainId
	WHERE c.CountryName = 'Bulgaria' AND p.Elevation > 2835
	ORDER BY p.Elevation DESC;

-- Task
SELECT c.CountryCode, COUNT(*) AS MountainRanges
	FROM Countries c
		JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
	WHERE c.CountryName IN ('Bulgaria', 'Russia', 'United States')
	GROUP BY c.CountryCode;

-- Task
SELECT c.CountryName, r.RiverName
	FROM Countries c
		JOIN Continents c2 ON c.ContinentCode = c2.ContinentCode 
		FULL OUTER JOIN CountriesRivers cr ON c.CountryCode = cr.CountryCode
		FULL OUTER JOIN Rivers r ON cr.RiverId = r.Id
	WHERE c2.ContinentName = 'Africa'
	ORDER BY c.CountryName ASC

-- Task
SELECT ContinentCode, CurrencyCode, Total FROM (
	SELECT ContinentCode, CurrencyCode, COUNT(CurrencyCode) AS Total,
		DENSE_RANK() OVER(PARTITION BY ContinentCode ORDER BY COUNT(CurrencyCode) DESC) AS Ranked
	FROM Countries 
	GROUP BY ContinentCode, CurrencyCode) AS k
WHERE Ranked = 1 AND Total > 1
ORDER BY ContinentCode;

-- Task
SELECT COUNT(*) AS [Count]
	FROM Countries c
		LEFT JOIN MountainsCountries mc ON mc.CountryCode = c.CountryCode
	WHERE mc.MountainId IS NULL

-- Task
SELECT TOP(5) c.CountryName,
		(SELECT MAX(p.Elevation) FROM Peaks p JOIN MountainsCountries mc ON p.MountainId = mc.MountainId WHERE mc.CountryCode = c.CountryCode) AS HighestPeak,
		(SELECT MAX(r.Length) FROM Rivers r JOIN CountriesRivers cr ON r.Id = cr.RiverID WHERE cr.CountryCode = c.CountryCode) AS LongestRiver
	FROM Countries c
	ORDER BY HighestPeak DESC, LongestRiver DESC, c.CountryName ASC;

-- Task
SELECT TOP(5)
	CountryName, 
	ISNULL(PeakName, '(no highest peak)') AS [Highest Peak Name],
	CASE
		WHEN Elevation IS NULL THEN 0
		ELSE Elevation
	END AS [Highest Peak Elevation],
	ISNULL(MountainRange, '(no mountain)') AS [Mountain]
FROM(
	SELECT
		CountryName, 
		PeakName, 
		Elevation, 
		MountainRange,
		DENSE_RANK() OVER (PARTITION BY CountryName ORDER BY Elevation DESC) AS [Rank]
	FROM 
		Countries c
			LEFT JOIN 
				MountainsCountries mc ON mc.CountryCode = c.CountryCode
			LEFT JOIN 
				Mountains m ON m.Id = mc.MountainId
			LEFT JOIN 
				Peaks p ON p.MountainId = m.Id
	) AS Ranked
WHERE 
	Ranked.[Rank] = 1
ORDER BY 
	Ranked.CountryName, Ranked.PeakName;