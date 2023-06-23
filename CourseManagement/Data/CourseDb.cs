using CourseManagement.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CourseManagement.Data
{
    public class CourseDb : DbContext
    {
        public CourseDb(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Course> Courses { get; set; }
    }
}
