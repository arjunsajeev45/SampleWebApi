using Microsoft.EntityFrameworkCore;
using SampleWebApi.Model;

namespace SampleWebApi.DB
{
    public class DemoDBContext:DbContext
    {
        public DemoDBContext(DbContextOptions<DemoDBContext> options) :base(options)
        { 
           
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Person> People { get; set; }
        public DbSet<Passport> Passports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .HasKey(p => p.Id);//Pk

            modelBuilder.Entity<Person>()
                .Property(p => p.Name).HasMaxLength(50);

            modelBuilder.Entity<Person>()
             .HasOne(p => p.Passport)
             .WithOne(p => p.Person)
             .HasForeignKey<Passport>(p => p.PersonId)
             .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }
    }
}
