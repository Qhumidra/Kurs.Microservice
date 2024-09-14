using Microsoft.AspNetCore.Http;

namespace Kurs.Shared.Services
{
    public class SharedIdentiyService : ISharedIdentityService
    {
        IHttpContextAccessor _httpContextAccessor;

        public SharedIdentiyService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserId => _httpContextAccessor.HttpContext.User.FindFirst("sub").Value;
    }
}
