using NudeSolutionAssignment.Modules.Insurance.Models;

namespace NudeSolutionAssignment.Modules.Insurance.Services
{
    public interface ICategoriesService
    {

        public Task<List<Category>> GetAllWithItems();
        public Task<Category?> GetById(int id);

    }
}
