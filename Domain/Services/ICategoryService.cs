using System.Collections.Generic;
using System.Threading.Tasks;
using SuperMarket.Domain.Models;
using SuperMarket.Domain.Services.Communication;

namespace SuperMarket.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
