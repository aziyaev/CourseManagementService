using CourseManagementService.Models;

namespace CourseManagementService.Interfaces
{
    public interface ICourseService
    {
        Task<Course> GetCourseByIdAsync(int id);
        Task<List<Course>> GetCoursesAsync();
        Task CreateCourseAsync(Course course);
        Task UpdateCourseAsync(Course course);
        Task DeleteCourseAsync(int id);
    }
}
