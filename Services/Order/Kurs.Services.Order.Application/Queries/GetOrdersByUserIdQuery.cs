
using Kurs.Services.Order.Application.Dtos;
using Kurs.Shared.Dtos;
using MediatR;
using System.Collections.Generic;

namespace Kurs.Services.Order.Application.Queries
{
    public class GetOrdersByUserIdQuery : IRequest<Response<List<OrderDto>>>
    {
        public string UserId { get; set; }
    }
}
