using ThreeAmigos.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreeAmigos.Domain.Interfaces.Services
{
    public interface IBrandService
    {
        Task<IEnumerable<Brand>> GetBrandsAsync();
        Task AddBrandAsync(Brand newBrand);
        
    }
}
