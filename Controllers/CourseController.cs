using CourseManagementService.Interfaces;
using CourseManagementService.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseManagementService.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCourseByIdAsync(int id)
        {
            var course = await courseService.GetCourseByIdAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return Ok(course);
        }

        [HttpGet]
        public async Task<IActionResult> GetCoursesAsync()
        {
            var courses = await courseService.GetCoursesAsync();
            return Ok(courses);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourseAsync([FromBody] Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await courseService.CreateCourseAsync(course);
            return CreatedAtAction(nameof(GetCourseByIdAsync), new { id = course.Id }, course);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCourseAsync(int id, [FromBody] Course course)
        {
            if(id != course.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await courseService.UpdateCourseAsync(course);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCourseAsync(int id)
        {
            await courseService.DeleteCourseAsync(id);
            return NoContent();
        }
    }
}
