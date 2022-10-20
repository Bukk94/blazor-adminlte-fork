using System.ComponentModel.DataAnnotations;

namespace Blazor.AdminLte.Security.Abstractions.Models.Accounts
{
    public class VerifyEmailRequest
    {
        [Required] 
        public string Token { get; set; }
    }
}