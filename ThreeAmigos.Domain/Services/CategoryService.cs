using ThreeAmigos.Domain.Entities;
using ThreeAmigos.Domain.Interfaces.Repositories;
using ThreeAmigos.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreeAmigos.Domain.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repository;

        public CategoryService(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task AddCategoryAsync(Category newCategory)
        {
            await _repository.Add(newCategory);
            await _repository.Save();
        }

        public async Task<IEnumerable<Category>> GetCategorysAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
