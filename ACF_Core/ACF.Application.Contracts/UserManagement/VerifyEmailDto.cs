using System.ComponentModel.DataAnnotations;

namespace ACF.Application.Contracts.UserManagement
{
    public class VerifyEmailDto
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Token { get; set; }
    }
}
