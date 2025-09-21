namespace Cognify.Models
{
    public class Progress
    {
        public Guid ProgressId { get; set; }
        public string StatusProgress { get; set; }
        public DateTime LastUpdate { get; set; }

        public Enrollment Enrollment { get; set; }
        public Guid EnrollmentId { get; set; }
        public Class Class { get; set; }
        public Guid ClassId { get; set; }
    }
}
