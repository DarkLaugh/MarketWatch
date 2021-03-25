using System.ComponentModel.DataAnnotations;

namespace MarketWatch.Application.DTOs.Requests
{
    public class LoginRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(1)]
        public string Password { get; set; }
    }
}
