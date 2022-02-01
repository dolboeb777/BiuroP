using System.ComponentModel.DataAnnotations;

namespace BiuroP.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Zapamiętać mnie?")]
        public bool RememberMe { get; set; }
    }
}
