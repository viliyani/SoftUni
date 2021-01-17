-- Task 01
CREATE VIEW v_HighestPeak AS
SELECT TOP(1) *
    FROM Peaks
    ORDER BY Elevation DESC;

-- Task 02
UPDATE Projects
    SET EndDate = GETDATE()
    WHERE EndDate IS NULL;