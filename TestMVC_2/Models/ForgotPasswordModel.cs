using System.ComponentModel.DataAnnotations;

namespace TestMVC_2.Models
{
    public class ForgotPasswordModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
