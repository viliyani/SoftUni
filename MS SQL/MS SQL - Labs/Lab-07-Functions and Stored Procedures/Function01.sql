CREATE FUNCTION udf_BigPower(@Base INT, @Exp INT)
RETURNS BIGINT
AS
BEGIN
	DECLARE @Result BIGINT = 1;
	WHILE (@Exp > 0)
	BEGIN
		SET @Result = @Result * @Base;
		SET @Exp -= 1;
	END
	RETURN @Result
END

SELECT dbo.udf_BigPower(2, 7);