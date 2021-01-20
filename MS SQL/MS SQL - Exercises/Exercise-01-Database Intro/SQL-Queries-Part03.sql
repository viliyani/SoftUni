-- Task 15
CREATE DATABASE Hotel;

CREATE TABLE Employees
(
	Id INT IDENTITY PRIMARY KEY,
	FirstName VARCHAR(90) NOT NULL,
	LastName VARCHAR(90) NOT NULL,
	Title VARCHAR(50) NOT NULL,
	Notes VARCHAR(200)
)

CREATE TABLE Customers
(
	AccountNumber INT IDENTITY PRIMARY KEY,
	FirstName VARCHAR(90) NOT NULL,
	LastName VARCHAR(90) NOT NULL,
	PhoneNumber CHAR(10) NOT NULL,
	EmergencyName VARCHAR(90) NOT NULL,
	EmergencyNumber CHAR(10) NOT NULL,
	Notes VARCHAR(200)
)

CREATE TABLE RoomStatus
(
	RoomStatus VARCHAR(20) PRIMARY KEY,
	Notes VARCHAR(200)
)

CREATE TABLE RoomTypes
(
	RoomType VARCHAR(20) PRIMARY KEY,
	Notes VARCHAR(200)
)

CREATE TABLE BedTypes
(
	BedType VARCHAR(20) PRIMARY KEY,
	Notes VARCHAR(200)
)

CREATE TABLE Rooms
(
	RoomNumber INT IDENTITY PRIMARY KEY,
	RoomType VARCHAR(20) REFERENCES RoomTypes(RoomType),
	BedType VARCHAR(20) REFERENCES BedTypes(BedType),
	Rate DECIMAL(4,2),
	RoomStatus VARCHAR(20) REFERENCES RoomStatus(RoomStatus),
	Notes VARCHAR(200)
)

CREATE TABLE Payments
(
	Id INT IDENTITY PRIMARY KEY, 
	EmployeeId INT REFERENCES Employees(Id),
	PaymentDate DATETIME NOT NULL,
	AccountNumber INT REFERENCES Customers(AccountNumber), 
	FirstDateOccupied DATETIME NOT NULL,
	LastDateOccupied DATETIME NOT NULL	,
	TotalDays AS DATEDIFF(DAY, FirstDateOccupied, LastDateOccupied), 
	AmountCharged DECIMAL(6,2) NOT NULL, 
	TaxRate DECIMAL(4,2) NOT NULL, 
	TaxAmount AS AmountCharged * TaxRate, 
	PaymentTotal DECIMAL(6,2) NOT NULL, 
	Notes VARCHAR(200)
)

CREATE TABLE Occupancies
( 
	Id INT IDENTITY PRIMARY KEY,
	EmployeeId INT REFERENCES Employees(Id), 
	DateOccupied DATETIME NOT NULL, 
	AccountNumber INT REFERENCES Customers(AccountNumber), 
	RoomNumber INT REFERENCES Rooms(RoomNumber),
	RateApplied DECIMAL(4,2), 
	PhoneCharge DECIMAL(5,3), 
	Notes VARCHAR(200)
)
