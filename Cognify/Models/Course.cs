using System.Collections.Generic;

namespace Cognify.Models
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? WorkLoad { get; set; }

        public Teacher Teacher { get; set; }
        public Guid? TeacherId { get; set; }
        public CourseCategory Category { get; set; }
        public Guid? CategoryId { get; set; }
        public ICollection<Class> Classes { get; set; } = new List<Class>();
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
