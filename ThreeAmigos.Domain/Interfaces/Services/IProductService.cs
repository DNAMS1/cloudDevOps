using ThreeAmigos.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreeAmigos.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task AddProductAsync(Product newProduct);
        
    }
}
