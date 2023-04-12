using NudeSolutionAssignment.Models;

namespace NudeSolutionAssignment.Services
{
    public interface ICategoriesService
    {

        public Task<List<Category>> GetAllWithItems();
        public Task<Category?> GetById(int id);

    }
}
