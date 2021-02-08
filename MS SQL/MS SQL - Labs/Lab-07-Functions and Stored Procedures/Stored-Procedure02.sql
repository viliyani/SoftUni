CREATE PROC sp_AddEmployeeToProject(@EmployeeId INT, @ProjectId INT)
AS
	DECLARE @CountEmployeeProject INT = 
		(SELECT COUNT(*) FROM EmployeesProjects
			WHERE EmployeeID = @EmployeeId
				AND ProjectID = @ProjectId);

	IF @CountEmployeeProject > 0
		THROW 50001, 'This Employee is already in the project.', 1
	
	INSERT INTO EmployeesProjects(EmployeeId, ProjectID)
		VALUES (@EmployeeId, @ProjectId); 
GO

EXEC sp_AddEmployeeToProject 1, 104