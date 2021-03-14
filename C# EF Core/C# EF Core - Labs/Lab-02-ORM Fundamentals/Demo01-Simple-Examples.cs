using OrmFund.Models;
using System;
using System.Linq;

namespace OrmFund
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new SoftUniContext();

            // Example for Select Data
            var employees = db.Employees
                .Where(x => x.FirstName.StartsWith("N"))
                .OrderByDescending(x => x.Salary)
                .Select(x => new { x.FirstName, x.LastName, x.Salary })
                .ToList();

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} => {employee.Salary}");
            }


            // Another example for Select Data
            var departments = db.Employees
                .GroupBy(x => x.Department.Name)
                .Select(x => new { Name = x.Key, Count = x.Count() })
                .ToList();

            foreach (var department in departments)
            {
                Console.WriteLine($"Name = {department.Name}, Employees Count = {department.Count}");
            }


            // Example for Insert Data
            db.Towns.Add(new Town { Name = "Pernik" });
            db.SaveChanges();
        }
    }
}
