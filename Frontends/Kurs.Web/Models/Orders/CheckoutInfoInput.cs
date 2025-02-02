﻿using System.ComponentModel.DataAnnotations;

namespace Kurs.Web.Models.Orders
{
    public class CheckoutInfoInput
    {
        [Display(Name = "Il")]
        public string Province { get; set; }
        [Display(Name = "Ilce")]
        public string District { get; set; }
        [Display(Name = "Cadde")]
        public string Street { get; set; }
        [Display(Name = "Posta Kodu")]
        public string ZipCode { get; set; }
        [Display(Name = "Adres")]
        public string Line { get; set; }
        [Display(Name = "Kart isim soyisim")]
        public string CardName { get; set; }
        [Display(Name = "Kart numarasi")]
        public string CardNumber { get; set; }
        [Display(Name = "Son kullanma tarihi")]
        public string Expiration { get; set; }
        [Display(Name = "CVV numarasi")]
        public string CVV { get; set; }
    }
}
