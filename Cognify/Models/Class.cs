namespace Cognify.Models
{
    public class Class
    {
        public Guid ClassId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public DateTime DateClass { get; set; }

        public Course Course { get; set; }
        public Guid CourseId { get; set; }
        public ICollection<Progress> Progresses { get; set; } = new List<Progress>();
    }
}
