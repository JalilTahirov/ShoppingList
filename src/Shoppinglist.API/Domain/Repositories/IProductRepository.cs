using System.Collections.Generic;
using System.Threading.Tasks;
using Shoppinglist.API.Domain.Models;

namespace Shoppinglist.API.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}