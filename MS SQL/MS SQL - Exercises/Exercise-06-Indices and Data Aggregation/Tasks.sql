-- ### Tasks for Gringotts database

-- Task
SELECT COUNT(*) AS [Count] 
	FROM WizzardDeposits; 

-- Task
SELECT MAX(MagicWandSize) AS [LongestMagicWand]
	FROM WizzardDeposits;

-- Task
SELECT DepositGroup, MAX(MagicWandSize) AS [LongestMagicWand]
	FROM WizzardDeposits
	GROUP BY DepositGroup;

-- Task
SELECT TOP(2) DepositGroup
	FROM WizzardDeposits
	GROUP BY DepositGroup
	ORDER BY AVG(MagicWandSize) ASC;

-- Task
SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
	FROM WizzardDeposits
	GROUP BY DepositGroup;

-- Task
SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
	FROM WizzardDeposits
	WHERE MagicWandCreator = 'Ollivander family'
	GROUP BY DepositGroup;

-- Task
SELECT DepositGroup, SUM(DepositAmount) AS TotalSum
	FROM WizzardDeposits
		WHERE MagicWandCreator = 'Ollivander family'
	GROUP BY DepositGroup
		HAVING SUM(DepositAmount) < 150000
	ORDER BY SUM(DepositAmount) DESC;

-- Task
SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge
	FROM WizzardDeposits
	GROUP BY DepositGroup, MagicWandCreator;

-- Task
SELECT a.AgeGroup, COUNT(a.AgeGroup) AS WizardCount
	FROM (
		SELECT Age,
			CASE 
				WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
				WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
				WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
				WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
				WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
				WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
				WHEN Age >= 61 THEN '[61+]'
			END AS AgeGroup
		FROM WizzardDeposits
	) AS a
	GROUP BY a.AgeGroup;

-- Task
SELECT *
	FROM (
		SELECT LEFT(FirstName, 1) AS FirstLetter
			FROM WizzardDeposits
			WHERE DepositGroup = 'Troll Chest'
	) AS a
	GROUP BY FirstLetter
	ORDER BY FirstLetter ASC;

-- Task
SELECT 
		DepositGroup,
		IsDepositExpired,
		AVG(DepositInterest) AS AverageInterest
	FROM WizzardDeposits
	WHERE DepositStartDate > '01/01/1985'
    GROUP BY DepositGroup, IsDepositExpired
	ORDER BY DepositGroup DESC;

-- Task
SELECT SUM(Guest.DepositAmount - Host.DepositAmount) AS [SumDifference]
	FROM WizzardDeposits Host
	JOIN WizzardDeposits Guest ON Guest.Id + 1 = Host.Id;


-- ### Tasks for Softuni database

-- Task
SELECT 
		DepartmentID, 
		SUM(Salary) as TotalSalary
	FROM Employees
	GROUP BY DepartmentID
	ORDER BY DepartmentID

-- Task
SELECT 
		DepartmentID, 
		SUM(Salary) as TotalSalary
	FROM Employees
	GROUP BY DepartmentID
	ORDER BY DepartmentID

-- Task
SELECT 
		DepartmentID,
		MAX(Salary) AS MaxSalary
	FROM Employees
	GROUP BY DepartmentID
	HAVING MAX(Salary)  < 30000 OR MAX(Salary) > 70000