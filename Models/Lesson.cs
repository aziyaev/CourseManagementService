namespace CourseManagementService.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public Language? Language { get; set; }
    }
}
