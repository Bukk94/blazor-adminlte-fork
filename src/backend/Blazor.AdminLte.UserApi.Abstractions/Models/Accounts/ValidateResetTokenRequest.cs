using System.ComponentModel.DataAnnotations;

namespace Blazor.AdminLte.Security.Abstractions.Models.Accounts
{
    public class ValidateResetTokenRequest
    {
        [Required] 
        public string Token { get; set; }
    }
}