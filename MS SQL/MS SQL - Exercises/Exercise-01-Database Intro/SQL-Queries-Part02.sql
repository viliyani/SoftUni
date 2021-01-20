-- Task 7
CREATE TABLE People
(
	Id INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(200) NOT NULL,
	Picture VARBINARY(3000) NULL,
	Height DECIMAL(5,2) NULL,
	Weight DECIMAL(5,2) NULL,
	Gender CHAR(1) NOT NULL
)

INSERT INTO People 
(Name, Picture, Height, Weight, Gender) 
VALUES
('Pesho', NULL, 179.00, 79.00, 'm'),
('Gergana', NULL, 164.00, 49.00, 'f'),
('Mitko', NULL, 169.00, 64.00, 'm'),
('Gloria', NULL, 173.00, 59.00, 'f'),
('John', NULL, 183.00, 86.00, 'm');


-- Task 8
CREATE TABLE Users
(
	Id BIGINT IDENTITY PRIMARY KEY,
	Username VARCHAR(30) NOT NULL,
	Password VARCHAR(26) NOT NULL,
	ProfilePicture VARCHAR(250),
	LastLoginTime DATE,
	IsDeleted BIT
)

INSERT INTO Users
(Username, [Password], ProfilePicture, LastLoginTime, IsDeleted)
VALUES
('myname1', 'qwerty', 'images/avatar1.jpg', '2021-01-20', 0),
('myname2', 'qwerty', 'images/avatar2.jpg', '2021-01-20', 0),
('myname3', 'qwerty', 'images/avatar3.jpg', '2021-01-20', 0),
('myname4', 'qwerty', 'images/avatar4.jpg', '2021-01-20', 0),
('myname5', 'qwerty', 'images/avatar5.jpg', '2021-01-20', 0);


-- Task 9
ALTER TABLE Users
DROP CONSTRAINT PK__Users__3214EC079468AD91;

ALTER TABLE Users
ADD CONSTRAINT PK_Users_CompositeIdUsername
PRIMARY KEY(Id, Username);


-- Task 10
ALTER TABLE Users
ADD CONSTRAINT CH_PasswordIsMinimum5Symbols CHECK(LEN(Password) >= 5);


-- Task 11
ALTER TABLE Users
ADD CONSTRAINT DF_Users_LastLoginTime
DEFAULT GETDATE() FOR LastLoginTime;


-- Task 12
ALTER TABLE Users
DROP CONSTRAINT [PK_Users_CompositeIdUsername];

ALTER TABLE Users
ADD CONSTRAINT PK_Users_Id
PRIMARY KEY(Id);

ALTER TABLE Users
ADD CONSTRAINT U_Users_Username
UNIQUE(Username);

ALTER TABLE Users
ADD CONSTRAINT CK_Users_UsernameLength
CHECK(LEN(Username)>=3);