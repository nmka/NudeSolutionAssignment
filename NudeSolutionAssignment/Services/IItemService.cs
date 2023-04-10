using NudeSolutionAssignment.Models;

namespace NudeSolutionAssignment.Services
{
    public interface IItemService
    {
        public List<Item> GetAll();
        public Item? GetById(int id);
        public Item? Create(Item item);
        public void Update(Item item);
        public void Delete(int id);

    }
}
