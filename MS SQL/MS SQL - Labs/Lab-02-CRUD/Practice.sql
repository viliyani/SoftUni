-- Select Queries

SELECT FirstName + ' ' + LastName AS [Full Name], JobTitle, Salary
    FROM Employees;

SELECT *
    FROM Employees
    WHERE Salary > 50000;

SELECT *
    FROM Employees
    WHERE HireDate > '2002-01-01';

SELECT *
    FROM Employees
    WHERE NOT (Salary < 20000)
        OR DepartmentID = 1;

SELECT *
    FROM Employees
    WHERE DepartmentID IN (1, 2, 3, 4);

SELECT *
    FROM Employees
    WHERE ManagerID IS NULL;

SELECT *
    FROM Employees
    WHERE
        JobTitle LIKE '%Manager';

SELECT *
    FROM Employees
    WHERE Salary > 20000
    ORDER BY FirstName DESC;

CREATE VIEW v_EmployeesWithHighestSalaries AS
SELECT FirstName, LastName, Salary
    FROM Employees
    WHERE Salary > 50000;


-- Insert Queries

INSERT INTO Peaks (PeakName, MountainId, Elevation)
    VALUES ('Mancho', 17, 2771);

INSERT INTO Peaks (PeakName, MountainId, Elevation)
    VALUES  ('Data 1', 15, 120),
            ('Data 2', 15, 140),
            ('Data 3', 15, 150);

-- Update Queries

UPDATE Peaks
    SET Elevation = Elevation * 0.90
    WHERE MountainId = 17;

-- Delete Queries

DELETE FROM Peaks WHERE Elevation > 8000;