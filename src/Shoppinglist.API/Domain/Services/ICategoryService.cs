
using System.Collections.Generic;
using System.Threading.Tasks;
using Shoppinglist.API.Domain.Models;
using Shoppinglist.API.Domain.Services.Communication;

namespace Shoppinglist.API.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);
    }
}
