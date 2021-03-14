using EfCoreIntroDemo.Models;
using System;
using System.Linq;

namespace EfCoreIntroDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new SoftUniContext();

            var departments = db.Departments
                .Where(d => d.Name.StartsWith("P"))
                .Select(d => new { d.DepartmentId, d.Name, d.Manager, d.Employees })
                .ToList();

            foreach (var department in departments)
            {
                Console.WriteLine($"--- Department: {department.Name}");
                Console.WriteLine($"-- Manager: {department.Manager.FirstName}");

                foreach (var employee in department.Employees.Where(e => e.JobTitle.EndsWith("Supervisor")).Select(e => new { e.FirstName, e.LastName, e.JobTitle }))
                {
                    Console.WriteLine($"- {employee.FirstName} {employee.LastName} -> {employee.JobTitle}");
                }
            }
        }
    }
}
