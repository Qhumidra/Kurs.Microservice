﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Kurs.Web.Models.Baskets
{
    public class BasketViewModel
    {
        public BasketViewModel()
        {
            _basketItems = new List<BasketItemViewModel>();
        }
        public string UserId { get; set; }
        public string DiscountCode { get; set; }
        public int? DiscountRate { get; set; }
        private List<BasketItemViewModel> _basketItems { get; set; }
        public List<BasketItemViewModel> BasketItems
        {
            get
            {
                if (HasDiscount)
                {
                    _basketItems.ForEach(b =>
                    {
                        var discountPrice = b.Price * ((decimal)DiscountRate.Value / 100);
                        b.AppliedDiscount(Math.Round(b.Price - discountPrice, 2));
                    });
                }
                return _basketItems;
            }
            set { _basketItems = value; }
        }
        public decimal TotalPrice { get => _basketItems.Sum(x => x.GetCurrentPrice); }

        public bool HasDiscount { get => !string.IsNullOrEmpty(DiscountCode) && DiscountRate.HasValue; }

        public void ApplyDiscount(string code, int rate)
        {
            DiscountCode = code;
            DiscountRate = rate;
        }

        public void CancelDiscount()
        {
            DiscountCode = null;
            DiscountRate = null;
        }
    }
}
