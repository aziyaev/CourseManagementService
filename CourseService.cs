using CourseManagementService.Interfaces;
using CourseManagementService.Models;

namespace CourseManagementService
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            return await courseRepository.GetCourseByIdAsync(id);
        }

        public async Task<List<Course>> GetCoursesAsync()
        {
            return await courseRepository.GetCoursesAsync();
        }

        public async Task CreateCourseAsync(Course course)
        {
            await courseRepository.CreateCourseAsync(course);
        }

        public async Task UpdateCourseAsync(Course course)
        {
            await courseRepository.UpdateCourseAsync(course);
        }

        public async Task DeleteCourseAsync(int id)
        {
            await courseRepository.DeleteCourseAsync(id);
        }
    }
}
