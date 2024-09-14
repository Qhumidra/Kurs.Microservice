using Kurs.Shared.Dtos;
using Kurs.Web.Models.Discounts;
using System.Threading.Tasks;

namespace Kurs.Web.Services.Interfaces
{
    public interface IDiscountService
    {
        Task<DiscountViewModel> GetDiscount(string discountCode);
    }
}
