CREATE FUNCTION	udf_EmployeesByYear(@Year SMALLINT)
RETURNS TABLE
AS
RETURN
(
	SELECT * FROM Employees
	WHERE YEAR(HireDate) = @Year
)

SELECT * FROM udf_EmployeesByYear(1999);