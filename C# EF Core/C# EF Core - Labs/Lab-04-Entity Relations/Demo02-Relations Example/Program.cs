using System;
using EfCoreDemo.Models;

namespace EfCoreDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new ApplicationDbContext();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var department = new Department { Name = "HR" };

            for (int i = 1; i <= 10; i++)
            {
                db.Employees.Add(new Employee
                {
                    FirstName = "John",
                    LastName = "Doe",
                    StartWorkDate = new DateTime(2010 + i, 1, 1),
                    Salary = 100 + i,
                    Department = department,
                });
            }

            db.SaveChanges();
        }
    }
}
