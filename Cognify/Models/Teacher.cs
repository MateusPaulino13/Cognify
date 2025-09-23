using System.ComponentModel.DataAnnotations;

namespace Cognify.Models
{
    public class Teacher
    {
        [Key]
        public Guid TeacherId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Curriculum { get; set; }
        public string Biography { get; set; }
        public User User { get; set; }
        public Guid UserId { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }   
}
