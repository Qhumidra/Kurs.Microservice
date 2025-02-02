﻿using Kurs.Web.Models.Orders;
using Kurs.Web.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Kurs.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IBasketService _basketService;
        private readonly IOrderService _orderService;

        public OrderController(IBasketService basketService, IOrderService orderService)
        {
            _basketService = basketService;
            _orderService = orderService;
        }

        public async Task<IActionResult> Checkout()
        {
            var basket = await _basketService.Get();

            ViewBag.basket = basket;

            return View(new CheckoutInfoInput());
        }
        [HttpPost]
        public async Task<IActionResult> Checkout(CheckoutInfoInput checkoutInfoInput)
        {
            var orderSuspend = await _orderService.SuspendOrder(checkoutInfoInput);

            if (!orderSuspend.IsSuccessful)
            {
                var basket = await _basketService.Get();

                ViewBag.basket.BasketItems = basket;

                ViewBag.error = orderSuspend.Error;

                return View();
            }

            return RedirectToAction(nameof(SuccessfulCheckout), new { orderId = new Random().Next(1, 1000) });
        }
        public IActionResult SuccessfulCheckout(int orderId)
        {
            ViewBag.orderId = orderId;
            return View();
        }
        public async Task<IActionResult> CheckoutHistory()
        {
            return View(await _orderService.GetOrder());
        }
    }
}
