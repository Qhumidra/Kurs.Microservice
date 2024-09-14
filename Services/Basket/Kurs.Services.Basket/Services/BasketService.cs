using Kurs.Services.Basket.Dtos;
using Kurs.Shared.Dtos;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kurs.Services.Basket.Services
{
    public class BasketService : IBasketService
    {
        private readonly RedisService _redisService;

        public BasketService(RedisService redisService)
        {
            _redisService = redisService;
        }

        public async Task<Response<bool>> Delete(string id)
        {
            var status = await _redisService.GetDatabase().KeyDeleteAsync(id);

            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Basket could not delete", 400);
        }

        public async Task<Response<BasketDto>> GetBasket(string id)
        {
            var existBasket = await _redisService.GetDatabase().StringGetAsync(id);

            if (String.IsNullOrEmpty(existBasket))
            {
                return Response<BasketDto>.Fail("Basket not found", 404);
            }

            var response = JsonSerializer.Deserialize<BasketDto>(existBasket);

            return Response<BasketDto>.Success(JsonSerializer.Deserialize<BasketDto>(existBasket), 200);
        }

        public async Task<Response<bool>> SaveOrUpdate(BasketDto basketdto)
        {
            var status = await _redisService.GetDatabase().StringSetAsync(basketdto.UserId, JsonSerializer.Serialize(basketdto));

            return status ? Response<bool>.Success(204) : Response<bool>.Fail("Basket could not update or save", 500);
        }
    }
}
