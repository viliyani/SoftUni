using EfCoreDemo.ModelsBuilding;
using Microsoft.EntityFrameworkCore;

namespace EfCoreDemo.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Club> Clubs { get; set; }

        public DbSet<EmployeeInClub> EmployeesInClubs { get; set; }

        public DbSet<Town> Towns { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Integrated Security=true;Database=EfCoreDemo;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());

            modelBuilder.Entity<EmployeeInClub>()
                .HasKey(x => new { x.EmployeeId, x.ClubId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
