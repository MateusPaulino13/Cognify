using System.ComponentModel.DataAnnotations;

namespace Cognify.Models
{
    public class User
    {
       [Key]
       public Guid UserId { get; set; }
       public string FullName { get; set; }
       public string Email { get; set; }
       public string Password { get; set; } 
       public DateTime RegistrationDate { get; set; }
       public Student Student { get; set; }
       public Teacher Teacher { get; set; }

    }
}
