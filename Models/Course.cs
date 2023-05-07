namespace CourseManagementService.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int LanguageId { get; set; }
        public Language? Language { get; set; }
        public List<Lesson>? Lessons { get; set; }
    }
}
