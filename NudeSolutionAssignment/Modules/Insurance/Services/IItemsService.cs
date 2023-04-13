using NudeSolutionAssignment.Modules.Insurance.Models;

namespace NudeSolutionAssignment.Modules.Insurance.Services
{
    public interface IItemsService
    {
        public Task<List<Item>> GetAll();
        public Task<Item?> GetById(int id);
        public Task<Item?> Create(Item item);
        public Task<Item?> Update(Item item);
        public Task<bool> Delete(int id);

    }
}
