-- Task 1
SELECT [CustomerID]
      ,[FirstName]
      ,[LastName]
	  ,LEFT([PaymentNumber], 6) 
			+ REPLICATE('*', LEN(PaymentNumber) - 6) as PaymentNum
  FROM [Demo].[dbo].[Customers];


-- Task 2
SELECT *, (A*H/2) as Area
	FROM Triangles2;


-- Task 3
SELECT *
		,SQRT(SQUARE(X2 - X1) + SQUARE(Y2 - Y1))
	FROM lines;


-- Task 4
SELECT * 
	,BoxCapacity * PalletCapacity AS TotalCapacity
	,CEILING(1.0 * Quantity / (BoxCapacity * PalletCapacity)) as [Number of Pallets]
	FROM Products;


-- Task 5
use SoftUni;
SELECT *,
		DATEPART(QUARTER, HireDate) as Quarter,
		CAST(DATEPART(MONTH, HireDate) as varchar) + '/' + CAST(DATEPART(YEAR, HireDate) as varchar) as Month,
		DATEPART(DAY, HireDate) as  Day
	FROM Employees;