using CourseManagementService.Models;

namespace CourseManagementService.Interfaces
{
    public interface ICourseRepository
    {
        Task<Course> GetCourseByIdAsync(int id);
        Task<List<Course>> GetCoursesAsync();
        Task CreateCourseAsync(Course course);
        Task UpdateCourseAsync(Course course);
        Task DeleteCourseAsync(int id);
    }
}
