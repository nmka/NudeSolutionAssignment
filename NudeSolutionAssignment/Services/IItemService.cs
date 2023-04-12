using NudeSolutionAssignment.Models;

namespace NudeSolutionAssignment.Services
{
    public interface IItemService
    {
        public Task<List<Item>> GetAll();
        public Task<Item> GetById(int id);
        public Task<Item> Create(Item item);
        public Task<Item> Update(Item item);
        public Task Delete(int id);

    }
}
