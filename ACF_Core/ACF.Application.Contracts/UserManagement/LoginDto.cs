using System.ComponentModel.DataAnnotations;

namespace ACF.Application.Contracts.UserManagement
{
    public class LoginDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
