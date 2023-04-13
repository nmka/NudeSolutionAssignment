using NudeSolutionAssignment.Modules.Insurance.Models;
using NudeSolutionAssignment.Modules.Insurance.Repositories;

namespace NudeSolutionAssignment.Modules.Insurance.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoriesRepository _categoriesRepository;


        public CategoriesService(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;

        }
        public async Task<Category?> GetById(int id)
        {
            return await _categoriesRepository.GetById(id);
        }

        public async Task<List<Category>> GetAllWithItems()
        {
            return await _categoriesRepository.GetAllWithItems();
        }
    }
}
