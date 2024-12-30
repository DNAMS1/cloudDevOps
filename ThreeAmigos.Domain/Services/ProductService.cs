using ThreeAmigos.Domain.Entities;
using ThreeAmigos.Domain.Interfaces.Repositories;
using ThreeAmigos.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreeAmigos.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task AddProductAsync(Product newProduct)
        {
            await _repository.Add(newProduct);
            await _repository.Save();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
