using System.ComponentModel.DataAnnotations;

namespace Wetube.Client.Models
{
    public class UserVM
    {
        public int UserId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
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