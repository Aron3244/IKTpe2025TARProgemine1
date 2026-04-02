using Microsoft.EntityFrameworkCore;
using University.Models;

namespace University.Data
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        { }

        public DbSet <Course> Courses { get; set; }
        public DbSet <Enrollment> Enrollments { get; set; }
        public DbSet <Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Course>().ToTable("Course");
            ModelBuilder.Entity<Enrollment>().ToTable("Course");
            ModelBuilder.Entity<Student>().ToTable("Course");
        }
    }
}
