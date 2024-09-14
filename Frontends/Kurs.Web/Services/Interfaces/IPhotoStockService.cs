using Kurs.Web.Models.PhotoStocks;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Kurs.Web.Services.Interfaces
{
    public interface IPhotoStockService
    {
        Task<PhotoViewModel> UploadPhoto(IFormFile photo);
        Task<bool> DeletePhoto(string photoUrl);
    }
}
