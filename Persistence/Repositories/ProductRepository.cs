using Microsoft.EntityFrameworkCore;
using SuperMarket.Domain.Models;
using SuperMarket.Domain.Repositories;
using SuperMarket.Persistence.Contexts;

namespace SuperMarket.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category)
                                          .ToListAsync();
        }
    }
}
