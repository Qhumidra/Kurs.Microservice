using Kurs.Services.Basket.Dtos;
using Kurs.Services.Basket.Services;
using Kurs.Shared.Messages;
using Kurs.Shared.Services;
using MassTransit;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kurs.Service.Basket.Consumers
{
    public class CourseNameChangedEventConsumer : IConsumer<CourseNameChangedEvent>
    {
        private readonly ISharedIdentityService _sharedIdentityService;
        private readonly IBasketService _basketService;

        public CourseNameChangedEventConsumer(ISharedIdentityService sharedIdentityService, IBasketService basketService)
        {
            _sharedIdentityService = sharedIdentityService;
            _basketService = basketService;
        }

        public async Task Consume(ConsumeContext<CourseNameChangedEvent> context)
        {
            var basketItem = await _basketService.GetBasket(context.Message.UserId);

            basketItem.Data.BasketItems.ForEach(x =>
            {
                if (x.CourseId == context.Message.CourseId)
                {
                    x.CourseName = context.Message.CourseName;
                    x.Price = context.Message.Price;
                }
            });

            await _basketService.SaveOrUpdate(basketItem.Data);
        }
    }
}
