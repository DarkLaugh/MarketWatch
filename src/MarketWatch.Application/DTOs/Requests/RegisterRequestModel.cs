using System.ComponentModel.DataAnnotations;

namespace MarketWatch.Application.DTOs.Requests
{
    public class RegisterRequestModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(1)]
        public string Password { get; set; }

        [Required]
        [MinLength(1)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
