using System;

namespace EfCoreDemo.Models
{
    public class EmployeeInClub
    {
        // This is an example for Many to Many relationship
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        public int ClubId { get; set; }

        public Club Club { get; set; }

        public DateTime JoinDate { get; set; }
    }
}
