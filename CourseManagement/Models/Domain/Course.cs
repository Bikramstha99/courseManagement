namespace CourseManagement.Models.Domain
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Cost { get; set; }
    }
}
