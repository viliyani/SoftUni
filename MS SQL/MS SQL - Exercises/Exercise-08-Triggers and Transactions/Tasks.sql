-- ### Tasks for Bank database

-- Task
CREATE TABLE Logs 
(
	LogId INT PRIMARY KEY IDENTITY, 
	AccountId INT REFERENCES Accounts(Id), 
	OldSum DECIMAL(15, 2), 
	NewSum DECIMAL(15, 2)
)

CREATE TRIGGER tr_InsertAccountInfo ON Accounts FOR UPDATE
AS
	DECLARE @newSum DECIMAL(15, 2) = (SELECT Balance FROM inserted);
	DECLARE @oldSum DECIMAL(15, 2) = (SELECT Balance FROM deleted);
	DECLARE @accountId INT = (SELECT Id FROM inserted);

	INSERT INTO Logs(AccountId, NewSum, OldSum) VALUES
					(@accountId, @newSum, @oldSum);
GO

UPDATE Accounts
	SET Balance += 10
	WHERE Id = 1;

SELECT * FROM Logs;



-- Task
CREATE TABLE NotificationEmails 
(
	Id INT PRIMARY KEY IDENTITY, 
	Recipient INT REFERENCES Accounts(Id), 
	[Subject] VARCHAR(50), 
	Body VARCHAR(MAX)
)

CREATE TRIGGER tr_LogEmail ON Logs FOR INSERT
AS 
	DECLARE @accountId INT = (SELECT TOP(1) AccountId FROM inserted);
	DECLARE @oldSum DECIMAL(15, 2) = (SELECT TOP(1) OldSum FROM inserted);
	DECLARE @newSum DECIMAL(15, 2) = (SELECT TOP(1) NewSum FROM inserted);

	INSERT INTO NotificationEmails (Recipient, [Subject], Body) VALUES
		(
			@accountId, 
			'Balance changed for account: ' + CAST(@accountId AS VARCHAR(20)),
			'Balanced have been changed from' + CAST(@oldSum AS VARCHAR(20)) + ' to ' + CAST(@newSum AS VARCHAR(20))
		);
GO

UPDATE Accounts
	SET Balance += 100
	WHERE Id = 1;

SELECT * FROM NotificationEmails;