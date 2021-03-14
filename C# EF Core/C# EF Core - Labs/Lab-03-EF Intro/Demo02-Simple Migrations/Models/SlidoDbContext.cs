using Microsoft.EntityFrameworkCore;

namespace EfCodeFirstDemo.Models
{
    public class SlidoDbContext : DbContext
    {

        public SlidoDbContext()
        {
        }

        public SlidoDbContext(DbContextOptions dbContextOptions)
            : base(dbContextOptions)
        {
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Integrated Security=true;Database=SliDo");
            }
        }

    }
}
