using ThreeAmigos.Domain.Entities;
using ThreeAmigos.Domain.Interfaces.Repositories;
using ThreeAmigos.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreeAmigos.Domain.Services
{
    public class BrandService : IBrandService
    {
        private readonly IRepository<Brand> _repository;

        public BrandService(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task AddBrandAsync(Brand newBrand)
        {
            await _repository.Add(newBrand);
            await _repository.Save();
        }

        public async Task<IEnumerable<Brand>> GetBrandsAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
