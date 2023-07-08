using Catelog.API.Models;

namespace Catelog.API.Contracts
{
    public interface ICatalogService
    {
        Task<List<Product>> GetAllAsync();

        Task<Product> GetByIdAsync(string id);

        Task<Product> CreateAsync(Product product);

        Task<Product> UpdateAsync(Product product);

        Task<bool> DeleteAsync(string id);
    }
}
