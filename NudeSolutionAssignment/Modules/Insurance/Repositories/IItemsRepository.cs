using NudeSolutionAssignment.Modules.Insurance.Models;

namespace NudeSolutionAssignment.Modules.Insurance.Repositories
{
    public interface IItemsRepository
    {
        public Task<List<Item>> GetAll();
        public Task<Item?> GetById(int id);
        public Task<Item?> Create(Item item);
        public Task<Item?> Update(Item item);
        public Task<bool> Delete(int id);
    }
}
