using Microsoft.EntityFrameworkCore;
using institute.Models;
namespace institute.Data
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options )
            : base(options)
        {
            Database.EnsureCreated();

        }
        public DbSet<Student> Students { get; set; }
    }
}
