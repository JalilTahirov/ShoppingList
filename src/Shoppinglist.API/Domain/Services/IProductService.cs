
using System.Collections.Generic;
using System.Threading.Tasks;
using Shoppinglist.API.Domain.Models;
using Shoppinglist.API.Domain.Services.Communication;

namespace Shoppinglist.API.Domain.Services
{
    public interface IProductService
    {
        IEnumerable<Product> List();
        ProductResponse Save(Product product);
        ProductResponse Update(int id, Product product);
        ProductResponse Delete(int id);
    }
}
