using Catelog.API.Contracts;
using Catelog.API.Models;
using MongoDB.Driver;

namespace Catelog.API.Services
{
    public class CatalogService : ICatalogService
    {
        private readonly IMongoCollection<Product> _products;

        public CatalogService(ICatelogDbSettings catelogDbSettings)
        {
            //create mongo client
            //create database
            //create collection
            var client = new MongoClient(catelogDbSettings.ConnectionString);
            var db = client.GetDatabase(catelogDbSettings.DatabaseName);
            _products = db.GetCollection<Product>(catelogDbSettings.CollectionName);
        }

        public async Task<Product> CreateAsync(Product product)
        {
            await _products.InsertOneAsync(product);
            return product;
        }

        public async Task<bool> DeleteAsync(string id)
        {
            await _products.DeleteOneAsync(p => p.Id == id);
            return true;
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _products.Find(p => true).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(string id)
        {
            return await _products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Product> UpdateAsync(Product product)
        {
            await _products.ReplaceOneAsync(p => p.Id == product.Id, product);
            return product;
        }
    }
}
