using NudeSolutionAssignment.Modules.Insurance.Models;

namespace NudeSolutionAssignment.Modules.Insurance.Repositories
{
    public interface ICategoriesRepository
    {

        public Task<List<Category>> GetAllWithItems();
        public Task<Category?> GetById(int id);
    }
}
