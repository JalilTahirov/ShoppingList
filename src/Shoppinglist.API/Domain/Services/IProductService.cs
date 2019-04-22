
using System.Collections.Generic;
using System.Threading.Tasks;
using Shoppinglist.API.Domain.Models;
using Shoppinglist.API.Domain.Services.Communication;

namespace Shoppinglist.API.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}
