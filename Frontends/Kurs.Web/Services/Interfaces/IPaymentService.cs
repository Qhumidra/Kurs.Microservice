using Kurs.Web.Models.FakePayments;
using System.Threading.Tasks;

namespace Kurs.Web.Services.Interfaces
{
    public interface IPaymentService
    {
        Task<bool> ReceivePayment(PaymentInfoInput paymentInfoInput);
    }
}
