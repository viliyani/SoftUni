CREATE PROC sp_AddToProject(@EmployeeId INT, @ProjectId INT)
AS
	DECLARE @EmployeesProjects INT = 
		(SELECT COUNT(*) FROM EmployeesProjects
			WHERE EmployeeID = @EmployeeId);

	IF (@EmployeesProjects >= 3)
		THROW 50001, 'Employee has more than 3 projects', 1;

	DECLARE @EmployeInThisProject INT = 
		(SELECT COUNT(*) FROM EmployeesProjects
			WHERE EmployeeID = @EmployeeId
					AND ProjectID = @ProjectId);

	IF (@EmployeInThisProject >= 1)
		THROW 50001, 'Employee already in this project', 1;

	INSERT INTO EmployeesProjects (EmployeeID, ProjectID)
		VALUES (@EmployeeId, @ProjectId);

GO


EXEC sp_AddToProject 1, 1