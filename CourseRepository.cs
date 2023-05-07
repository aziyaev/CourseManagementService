using CourseManagementService.Interfaces;
using CourseManagementService.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseManagementService
{
    public class CourseRepository : ICourseRepository
    {
        private readonly MyDbContext dbContext;

        public CourseRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await dbContext.Courses
                .Include(c => c.Language)
                .Include(c => c.Lessons)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<Course>> GetCoursesAsync()
        {
            return await dbContext.Courses
                .Include(c => c.Language)
                .Include(c => c.Lessons)
                .ToListAsync();
        }

        public async Task CreateCourseAsync(Course course)
        {
            dbContext.Courses.Add(course);
            await dbContext.SaveChangesAsync();
        }

        public async Task UpdateCourseAsync(Course course)
        {
            dbContext.Courses.Update(course);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteCourseAsync(int id)
        {
            var course = await GetCourseByIdAsync(id);
            dbContext.Courses.Remove(course);
            await dbContext.SaveChangesAsync();
        }


    }
}
