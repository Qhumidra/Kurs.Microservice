using Kurs.Services.Order.Insfrastructure;
using Kurs.Shared.Messages;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Services.Order.Application.Consumers
{
    public class CreateOrderMesssageCommandConsumer : IConsumer<CreateOrderMesssageCommand>
    {
        private readonly OrderDbContext _orderDbContext;

        public CreateOrderMesssageCommandConsumer(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        public async Task Consume(ConsumeContext<CreateOrderMesssageCommand> context)
        {
            var newAddress = new Domain.OrderAggregate.Address
                (context.Message.Province, context.Message.District, context.Message.Street, context.Message.ZipCode, context.Message.Line);

            Domain.OrderAggregate.Order order = new Domain.OrderAggregate.Order(context.Message.BuyerId, newAddress);

            context.Message.OrderItems.ForEach(x =>
            {
                order.AddOrderItem(x.ProductId, x.ProductName, x.Price, x.PictureUrl);
            });

            await _orderDbContext.Orders.AddAsync(order);

            await _orderDbContext.SaveChangesAsync();
        }
    }
}
