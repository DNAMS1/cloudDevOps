using ThreeAmigos.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ThreeAmigos.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetCategorysAsync();
        Task AddCategoryAsync(Category newCategory);
        
    }
}
