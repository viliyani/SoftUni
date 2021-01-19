CREATE TABLE Students
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    FacultyNumber CHAR(6) UNIQUE,
    Photo VARBINARY(200),
    DateOfEnlistment DATE
)

CREATE TABLE Towns
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
)

CREATE TABLE Courses
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    TownId INT REFERENCES Towns(Id)
)

CREATE TABLE StudentsCourses
(
    StudentId INT REFERENCES Students(Id),
    CourseId INT REFERENCES Courses(Id),
    Mark DECIMAL(3,2),
    CONSTRAINT PK_StudentsCourses
        PRIMARY KEY (StudentId, CourseId)
)