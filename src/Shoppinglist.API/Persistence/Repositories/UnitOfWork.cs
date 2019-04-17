using System.Threading.Tasks;
using Shoppinglist.API.Domain.Repositories;
using Shoppinglist.API.Persistence.Contexts;

namespace Shoppinglist.API.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;     
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
