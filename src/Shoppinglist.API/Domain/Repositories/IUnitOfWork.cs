using System.Threading.Tasks;

namespace Shoppinglist.API.Domain.Repositories
{
    public interface IUnitOfWork
    {
         Task CompleteAsync();
    }
}