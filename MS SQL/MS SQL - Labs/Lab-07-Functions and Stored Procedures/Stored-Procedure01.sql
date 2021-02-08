CREATE PROCEDURE sp_CreateNamesWithSalaries(@Count INT = 5)
AS
	INSERT INTO NamesWithSalaries(FullName, Salary)
		SELECT TOP(@Count) '[new]' + FullName, Salary
		FROM NamesWithSalaries
		ORDER BY [Salary] DESC
GO