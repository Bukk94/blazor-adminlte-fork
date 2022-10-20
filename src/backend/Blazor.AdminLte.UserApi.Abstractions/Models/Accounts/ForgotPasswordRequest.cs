using System.ComponentModel.DataAnnotations;

namespace Blazor.AdminLte.Security.Abstractions.Models.Accounts
{
    public class ForgotPasswordRequest
    {
        [Required] 
        [EmailAddress] 
        public string Email { get; set; }
    }
}