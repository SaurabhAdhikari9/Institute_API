using Microsoft.EntityFrameworkCore;
using institute.Models;

namespace institute.Data
{
    public class TeacherDbContext :DbContext
    {
        public TeacherDbContext(DbContextOptions<TeacherDbContext> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
