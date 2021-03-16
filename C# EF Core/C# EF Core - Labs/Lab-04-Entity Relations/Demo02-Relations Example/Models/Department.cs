using System.Collections.Generic;

namespace EfCoreDemo.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        // Example for 1 to Many relationship (1 Department has Many Employees)
        public ICollection<Employee> Employees { get; set; }
    }
}
