using AutoMapper;
using Kurs.Services.Order.Application.Dtos;
using Kurs.Services.Order.Domain.OrderAggregate;

namespace Kurs.Services.Order.Application.Mapping
{
    public class CustomMapping : Profile
    {
        public CustomMapping()
        {
            CreateMap<Domain.OrderAggregate.Order, OrderDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemDto>().ReverseMap();
            CreateMap<Address, AddressDto>().ReverseMap();


        }
    }
}
