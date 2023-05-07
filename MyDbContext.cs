using CourseManagementService.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementService
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Language> Languages { get; set; }
    }
}
