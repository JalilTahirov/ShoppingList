 using System.Collections.Generic;
using System.Threading.Tasks;
using Shoppinglist.API.Domain.Models;

namespace Shoppinglist.API.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
