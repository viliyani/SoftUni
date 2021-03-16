using EfCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreDemo.ModelsBuilding
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .Property(x => x.StartWorkDate)
                .HasColumnName("StartedOn");

            builder
                .Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            builder
                .Ignore(x => x.FullName);

            builder
                .HasOne(x => x.Department) // required
                .WithMany(x => x.Employees) // optional (inverse)
                .HasForeignKey(x => x.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
