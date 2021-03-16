using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreDemo.Models
{
    public class Employee
    {
        public Employee()
        {
            ClubParticipations = new HashSet<EmployeeInClub>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public DateTime? StartWorkDate { get; set; }

        public decimal? Salary { get; set; }

        // Example for 1 to Many relationship (1 Department has Many Employees)
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        // Example for 1 to 1 relationship (Employee - Address)
        [ForeignKey(nameof(Address))]
        public int? AddressId { get; set; }

        public Address Address { get; set; }

        // Example for Many to Many relationship (Many Employee in Many Clubs)
        public ICollection<EmployeeInClub> ClubParticipations { get; set; }

        public int? BirthTownId { get; set; }

        [InverseProperty(nameof(Town.NativeCitizens))]
        public Town BirthTown { get; set; }

        public int? WorkTownId { get; set; }

        [InverseProperty(nameof(Town.Workers))]
        public Town WorkTown { get; set; }
    }
}
