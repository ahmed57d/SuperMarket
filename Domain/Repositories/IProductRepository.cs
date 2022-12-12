using SuperMarket.Domain.Models;

namespace SuperMarket.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
