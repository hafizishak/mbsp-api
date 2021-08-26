using System.ComponentModel.DataAnnotations;

namespace Iaf.API.DTO
{
    public class UserForLoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 4, ErrorMessage = "4 to 20 password length") ]
        public string Password { get; set; }
    }
}