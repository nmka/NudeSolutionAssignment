using NudeSolutionAssignment.Models;
using NudeSolutionAssignment.Persistence;

namespace NudeSolutionAssignment.Services
{
    public class ItemService: IItemService
    {
        private readonly InsuranceContext _dbContext;

        public ItemService(InsuranceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Item? Create(Item item)
        {
            _dbContext.Add(item);
            _dbContext.SaveChanges();
            Console.Write(item);

            return item;
        }

        public Item? GetById(int id)
        {
            return _dbContext.Items.Find(id);
        }

        public void Delete(int id)
        {
            Item? item= _dbContext.Items.Find(id);
            if (item is null) return;

            _dbContext.Remove(item);
            _dbContext.SaveChanges();

        }

        public void Update(Item item)
        {
            var isExists = _dbContext.Items.Any(x => x.Id == item.Id);
            if (!isExists) return;

            _dbContext.Update(item);
            _dbContext.SaveChanges();
        }

        public List<Item> GetAll()
        {
            return _dbContext.Items.ToList();
        }
    }
}
