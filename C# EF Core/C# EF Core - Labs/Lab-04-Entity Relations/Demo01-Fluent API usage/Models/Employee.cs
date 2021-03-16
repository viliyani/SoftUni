using System;

namespace EfCoreDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public DateTime? StartWorkDate { get; set; }

        public decimal? Salary { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
