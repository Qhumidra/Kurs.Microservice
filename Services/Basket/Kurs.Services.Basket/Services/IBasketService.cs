using Kurs.Services.Basket.Dtos;
using Kurs.Shared.Dtos;
using System.Threading.Tasks;

namespace Kurs.Services.Basket.Services
{
    public interface IBasketService
    {
        public Task<Response<BasketDto>> GetBasket(string id);
        public Task<Response<bool>> SaveOrUpdate(BasketDto basketdto);
        public Task<Response<bool>> Delete(string id);
    }
}
