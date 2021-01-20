-- Task 1
CREATE DATABASE Minions;

-- Task 2
CREATE TABLE Minions 
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Age TINYINT NOT NULL
)

CREATE TABLE Towns 
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL
)

-- Task 3
ALTER TABLE Minions
	ADD TownId INT REFERENCES Towns(Id);

-- Task 4
INSERT INTO Towns(Name) VALUES
('Sofia'),
('Plovdiv'),
('Varna');

INSERT INTO Minions(Name, Age, TownId) VALUES  
('Kevin', 22, 1),
('Bob', 15, 3),
('Steward', 18, 2);

-- Task 5
TRUNCATE TABLE Minions;

-- Task 6
DROP TABLE Minions;
DROP TABLE Towns;

