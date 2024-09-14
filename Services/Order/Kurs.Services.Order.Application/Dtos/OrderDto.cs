using System;
using System.Collections.Generic;

namespace Kurs.Services.Order.Application.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public AddressDto Adress { get; set; }
        public string BuyerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
    }
}
