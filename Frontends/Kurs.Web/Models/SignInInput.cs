using System.ComponentModel.DataAnnotations;

namespace Kurs.Web.Models
{
    public class SignInInput
    {
        [Required]
        [Display(Name ="Email adresiniz")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Sifreniz")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Beni hatirla")]
        public bool IsRemember { get; set; }
    }
}
