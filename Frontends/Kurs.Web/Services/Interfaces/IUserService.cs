using Kurs.Web.Models;
using System.Threading.Tasks;

namespace Kurs.Web.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();
    }
}
