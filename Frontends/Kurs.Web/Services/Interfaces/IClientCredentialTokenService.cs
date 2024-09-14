using System;
using System.Threading.Tasks;

namespace Kurs.Web.Services.Interfaces
{
    public interface IClientCredentialTokenService
    {
        Task<String> GetToken();
    }
}
