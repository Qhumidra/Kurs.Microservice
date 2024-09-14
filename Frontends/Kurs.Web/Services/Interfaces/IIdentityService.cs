using IdentityModel.Client;
using Kurs.Shared.Dtos;
using Kurs.Web.Models;
using System.Threading.Tasks;

namespace Kurs.Web.Services.Interfaces
{
    public interface IIdentityService
    {

        Task<Response<bool>> SignIn(SignInInput signInInput);
        Task<Response<bool>> Register(RegisterInput registerInput);
        Task<TokenResponse> GetAccessTokenByRefreshToken();
        Task RevokeRefreshToken();
    }
}
