using System.ComponentModel.DataAnnotations;

namespace Kurs.Web.Models.Catalogs
{
   public class FeatureViewModel
    {
        [Display(Name = "Kurs Sure")]
        [Required]
        public int Duration { get; set; }

    }
}
