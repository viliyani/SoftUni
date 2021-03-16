using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDemo.Models
{
    public class Address
    {
        public int Id { get; set; }

        // Example for 1 to 1 relationship (Employee - Address)
        [ForeignKey(nameof(Employee))]
        public int? EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
