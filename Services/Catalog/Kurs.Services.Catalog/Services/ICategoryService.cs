using Kurs.Services.Catalog.Dtos;
using Kurs.Services.Catalog.Model;
using Kurs.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kurs.Services.Catalog.Services
{
    public interface ICategoryService
    {
        Task<Response<List<Category>>> GetAllAsync();

        Task<Response<CategoryDto>> GetByIdAsync(string id);

        Task<Response<CategoryDto>> CreateAsync(CategoryDto categoryDto);
    }
}
