CREATE TABLE Teachers
(
	TeacherID INT IDENTITY PRIMARY KEY,
	[Name] NVARCHAR(30) NOT NULL,
	ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers
	([Name], ManagerID)
VALUES
	('John', NULL),
	('Maya', 106),
	('Silvia', 106),
	('Ted', 105),
	('Mark', 101),
	('Greta', 101)