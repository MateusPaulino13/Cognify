namespace Cognify.Models
{
    public class CourseCategory
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
