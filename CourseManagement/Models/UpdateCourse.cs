namespace CourseManagement.Models
{
    public class UpdateCourse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Cost { get; set; }
    }
}
