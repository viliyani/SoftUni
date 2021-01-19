SELECT m.MountainRange, p.PeakName, p.Elevation
    FROM Mountains as m
    JOIN Peaks as p
        ON m.Id = p.MountainId
    WHERE m.MountainRange = 'Rila'
    ORDER BY p.Elevation DESC;
