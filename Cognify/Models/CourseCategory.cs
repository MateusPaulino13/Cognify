using System.ComponentModel.DataAnnotations;

namespace Cognify.Models
{
    public class CourseCategory
    {
        [Key]
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
