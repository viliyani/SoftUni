-- ### Tasks for Softuni database

-- Task
CREATE PROC dbo.usp_GetEmployeesSalaryAbove35000 
AS
	SELECT FirstName, LastName
		FROM Employees
		WHERE Salary > 35000
GO

EXEC dbo.usp_GetEmployeesSalaryAbove35000


-- Task
CREATE PROC dbo.usp_GetEmployeesSalaryAboveNumber (@inputSalary DECIMAL(18,4))
AS
	SELECT FirstName, LastName
		FROM Employees
		WHERE Salary >= @inputSalary
GO

EXEC dbo.usp_GetEmployeesSalaryAboveNumber 48100


-- Task
CREATE PROC dbo.usp_GetTownsStartingWith (@string NVARCHAR(50))
AS
SELECT [Name] AS Town
	FROM Towns
	WHERE [Name] LIKE @string + '%';
GO

EXEC dbo.usp_GetTownsStartingWith 'b'


-- Task
CREATE PROC dbo.usp_GetEmployeesFromTown (@townName NVARCHAR(50))
AS
SELECT e.FirstName, e.LastName
	FROM Employees e
	JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID = t.TownID
	WHERE t.Name = @townName;
GO

EXEC dbo.usp_GetEmployeesFromTown 'Sofia'


-- Task
CREATE FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
RETURNS VARCHAR(10)
AS
BEGIN
	DECLARE @result VARCHAR(10);

	SET @result = CASE
					WHEN @salary < 30000 THEN 'Low1'
					WHEN @salary <= 50000 THEN 'Average1'
					WHEN @salary > 50000 THEN 'High1'
				END;

	RETURN @result;
END


SELECT Salary,
		dbo.ufn_GetSalaryLevel(Salary)
	FROM Employees;


-- Task
CREATE PROC usp_EmployeesBySalaryLevel (@level VARCHAR(10))
AS
	SELECT FirstName, LastName
		FROM Employees
		WHERE dbo.ufn_GetSalaryLevel(Salary) = @level;
GO

EXEC usp_EmployeesBySalaryLevel 'High'


-- Task
CREATE FUNCTION ufn_IsWordComprised(@setOfLetters NVARCHAR(50), @word NVARCHAR(50))
RETURNS BIT
AS
BEGIN

	DECLARE @i TINYINT = 1;

	WHILE LEN(@word) >= @i
	BEGIN
		DECLARE @currentLetter NVARCHAR(1) = SUBSTRING(@word, @i, 1);

		IF(CHARINDEX(@currentLetter, @setOfLetters) = 0)
		  RETURN 0

		SET @i += 1;
	END

  RETURN 1

END

GO

SELECT dbo.ufn_IsWordComprised('oistmiahf', 'Sofia')

SELECT dbo.ufn_IsWordComprised('oistmiahf', 'halves')




-- ### Tasks for Bank database

-- Task
CREATE PROC usp_GetHoldersFullName
AS
BEGIN
  
	SELECT 
		FirstName + ' ' + LastName AS [Full Name]
		FROM AccountHolders

END

GO

EXEC usp_GetHoldersFullName


-- Task
CREATE PROC usp_GetHoldersWithBalanceHigherThan(@inputSalary MONEY)
AS
BEGIN
	SELECT 
			ah.FirstName,
			ah.LastName
		FROM Accounts a
			JOIN AccountHolders ah ON ah.Id = a.AccountHolderId
		GROUP BY a.AccountHolderId, ah.FirstName, ah.LastName
		HAVING SUM(a.Balance) > @inputSalary
		ORDER BY ah.FirstName, ah.LastName
END

GO

EXEC usp_GetHoldersWithBalanceHigherThan 50000


-- Task
CREATE FUNCTION ufn_CalculateFutureValue (@sum DECIMAL(18, 4), @yearlyInterestRate FLOAT, @numberOfyears INT)
RETURNS DECIMAL(18, 4)
AS
BEGIN
	DECLARE @x FLOAT = 1 + @yearlyInterestRate;
	DECLARE @calculate DECIMAL(18,4) = @sum * (POWER(@x, @numberOfyears));
	RETURN @calculate 
END

GO

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)


-- Task
CREATE PROC usp_CalculateFutureValueForAccount (@accountID INT ,@interestRate FLOAT)
AS
BEGIN
	SELECT
			a.Id AS [Account Id],
			ah.FirstName AS [First Name],
			ah.LastName AS [Last Name],
			a.Balance AS [Current Balance],
			dbo.ufn_CalculateFutureValue(a.Balance, @interestRate, 5) AS [Balance in 5 years]
		FROM Accounts a
			JOIN AccountHolders ah ON ah.Id = a.AccountHolderId
		WHERE a.Id = @accountID
END

GO

usp_CalculateFutureValueForAccount 1, 0.1
