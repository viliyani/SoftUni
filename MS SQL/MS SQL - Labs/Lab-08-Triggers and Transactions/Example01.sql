CREATE PROC usp_TransferFunds(
	@FromAccountId INT, @ToAccountId INT, @Amount MONEY)
AS
	BEGIN TRANSACTION 
	IF (SELECT Balance FROM Accounts WHERE Id = @FromAccountId) < @Amount
	BEGIN
		ROLLBACK;
		THROW 50001, 'Insufficient funds', 1;
	END

	IF NOT EXISTS(SELECT * FROM Accounts WHERE Id = @FromAccountId)
	BEGIN
		ROLLBACK;
		THROW 50002, 'FromAccount not found!', 1
	END

	IF NOT EXISTS(SELECT * FROM Accounts WHERE Id = @ToAccountId)
	BEGIN
		ROLLBACK;
		THROW 50003, 'ToAccount not found!', 1
	END

	UPDATE Accounts SET Balance = Balance - @Amount WHERE Id = @FromAccountId;
	UPDATE Accounts SET Balance = Balance + @Amount WHERE Id = @ToAccountId;
	COMMIT
GO

