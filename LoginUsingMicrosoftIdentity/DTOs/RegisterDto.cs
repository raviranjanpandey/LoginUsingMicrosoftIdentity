using System.ComponentModel.DataAnnotations;

namespace LoginUsingMicrosoftIdentity.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", ErrorMessage = "Password must have a number, Uppercase, Lowercase and length between 4 to 8")]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public short UserType { get; set; }
    }
}
