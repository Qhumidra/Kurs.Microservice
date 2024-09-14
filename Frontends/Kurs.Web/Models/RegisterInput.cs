using System.ComponentModel.DataAnnotations;

namespace Kurs.Web.Models
{
    public class RegisterInput
    {
        [Required]
        [Display(Name = "Kullanici adiniz")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Email adresiniz")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Sifreniz")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Sehrinizi giriniz")]
        public string City { get; set; }        
    }
}
