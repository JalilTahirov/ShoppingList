using System.Collections.Generic;
using System.Threading.Tasks;
using Shoppinglist.API.Domain.Models;
using Shoppinglist.API.Domain.Services;
using Shoppinglist.API.Domain.Services.Communication;

namespace Shoppinglist.Test
{
    public class MockProductService : IProductService
    {
        public MockProductService()
        {
            DeleteAsyncWasCalled = false;
            ListAsyncWasCalled = false;
            SaveAsyncWasCalled = false;
            UpdateAsyncWasCalled = false;
        }

        public bool DeleteAsyncWasCalled
        {
            get; private set;
        }

        public bool ListAsyncWasCalled
        {
            get; private set;
        }

        public bool SaveAsyncWasCalled
        {
            get; private set;
        }

        public bool UpdateAsyncWasCalled
        {
            get; private set;
        }


        public Task<ProductResponse> ReturnValue { get; set; }
        public Task<IEnumerable<Product>> ReturnListValue { get; set; }


        public Task<ProductResponse> DeleteAsync(int id)
        {
            DeleteAsyncWasCalled = true;
            return ReturnValue;
        }

        public Task<IEnumerable<Product>> ListAsync()
        {
            ListAsyncWasCalled = true;
            return ReturnListValue;
        }

        public Task<ProductResponse> SaveAsync(Product product)
        {
            SaveAsyncWasCalled = true;
            return ReturnValue;
        }

        public Task<ProductResponse> UpdateAsync(int id, Product product)
        {
            UpdateAsyncWasCalled = true;
            return ReturnValue;
        }
    }
}