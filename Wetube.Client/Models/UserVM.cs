using System.ComponentModel.DataAnnotations;

namespace Wetube.Client.Models
{
    public class UserVM
    {
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public int Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "invalid email address")]
        public string Email { get; set; }
    }
}