using System.Collections.Generic;

namespace EfCoreDemo.Models
{
   public class Club
    {
        public Club()
        {
            Employees = new HashSet<EmployeeInClub>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        // Example for Many to Many relationship (Many Employee in Many Clubs)
        public ICollection<EmployeeInClub> Employees { get; set; }
    }
}
