using SuperMarket.Domain.Models;

namespace SuperMarket.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
