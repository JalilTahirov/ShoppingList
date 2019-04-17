
using System.Collections.Generic;
using System.Threading.Tasks;
using Shoppinglist.API.Domain.Models;
using Shoppinglist.API.Domain.Repositories;
using Shoppinglist.API.Domain.Services;

namespace Shoppinglist.API.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}
