using Microsoft.EntityFrameworkCore;

namespace StudentAdminPortal.API.DataModels
{
    public class StudentAdminContext : DbContext
    {
        // Constructor
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options) : base(options) { }

        // This will create tables inside our SQL server when we run the migrations.
        public DbSet<Student> Student { get;set; }
        public DbSet<Gender> Gender { get;set; }
        public DbSet<Address> Address { get;set; }
    }
}
