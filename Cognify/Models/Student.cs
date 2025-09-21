namespace Cognify.Models
{
    public class Student
    {
        public Guid StudentId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
