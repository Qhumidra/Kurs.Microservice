using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Kurs.Web.Models.Catalogs
{
    public class CourseUpdateInput
    {
        public string Id { get; set; }
        [Display(Name = "Kurs Ismi")]
        public string Name { get; set; }
        [Display(Name = "Kurs Aciklama")]
        
        public string Description { get; set; }
        [Display(Name = "Kurs Fiyat")]
        public decimal Price { get; set; }
        public string UserId { get; set; }
        public string Picture { get; set; }
        public FeatureViewModel Feature { get; set; }
        [Display(Name = "Kurs Kategori")]
        public string CategoryId { get; set; }
        [Display(Name = "Kurs Resim")]
        public IFormFile PhotoFormFile { get; set; }
    }
}
