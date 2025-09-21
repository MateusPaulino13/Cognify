namespace Cognify.Models
{
    public class Enrollment
    {
        public Guid EnrollmentId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Student Student { get; set; }
        public Guid StudentId { get; set; }
        public Course Course { get; set; }
        public Guid CourseId { get; set; }

        public ICollection<Progress> Progresses { get; set; } = new List<Progress>();
    }
}
