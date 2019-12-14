using System.ComponentModel.DataAnnotations;

namespace Wetube.Client.Models
{
    public class UserVM
    {
        public int UserId { get; set; }
        [Required(ErrorMessage = "Please enter a valid username")]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter a valid password")]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        // [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please Enter Your First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter a valid email address")]
        [EmailAddress(ErrorMessage = "invalid email address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}