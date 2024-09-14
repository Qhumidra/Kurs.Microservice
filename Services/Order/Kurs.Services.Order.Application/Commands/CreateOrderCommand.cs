using Kurs.Services.Order.Application.Dtos;
using Kurs.Shared.Dtos;
using MediatR;
using System.Collections.Generic;

namespace Kurs.Services.Order.Application.Commands
{
    public class CreateOrderCommand : IRequest<Response<CreatedOrderDto>>
    {
        public string BuyerId { get; set; }
        public List<OrderItemDto> OrderItems { get; set; }
        public AddressDto Address { get; set; }
    }
}
