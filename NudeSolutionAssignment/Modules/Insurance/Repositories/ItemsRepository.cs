using Microsoft.EntityFrameworkCore;
using NudeSolutionAssignment.Modules.Insurance.Models;
using NudeSolutionAssignment.Persistence;

namespace NudeSolutionAssignment.Modules.Insurance.Repositories
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly InsuranceContext _dbContext;


        public ItemsRepository(InsuranceContext dbContext)
        {
            _dbContext = dbContext;

        }

        public async Task<Item?> Create(Item item)
        {
            _dbContext.Add(item);
            await _dbContext.SaveChangesAsync();

            return item;
        }

        public async Task<Item?> GetById(int id)
        {
            return await _dbContext.Items.FindAsync(id);
        }

        public async Task<bool> Delete(int id)
        {
            Item? item = await _dbContext.Items.FindAsync(id);
            if (item is null) return false;

            _dbContext.Remove(item);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<Item?> Update(Item item)
        {
            var isExists = _dbContext.Items.Any(x => x.Id == item.Id);
            if (!isExists) return null;

            _dbContext.Update(item);
            await _dbContext.SaveChangesAsync();

            return item;
        }

        public async Task<List<Item>> GetAll()
        {
            return await _dbContext.Items.ToListAsync();
        }
    }
}
