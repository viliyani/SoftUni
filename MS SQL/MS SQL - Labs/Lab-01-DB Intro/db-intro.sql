CREATE TABLE People
(
	Id INT PRIMARY KEY IDENTITY,
	Email VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50),
	LastName VARCHAR(50)
);


INSERT INTO People (Email, FirstName, LastName)
VALUES 
('vanko@gmail.com', 'Ivan', 'Petrov'),
('pesho@gmail.com', 'Peter', 'Kirilov'),
('gosho@gmail.com', 'Georgi', 'Ivanov');


SELECT *
FROM People;
