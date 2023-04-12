using Microsoft.EntityFrameworkCore;
using NudeSolutionAssignment.Models;
using NudeSolutionAssignment.Persistence;

namespace NudeSolutionAssignment.Services
{
    public class ItemService: IItemService
    {
        private readonly InsuranceContext _dbContext;
        private readonly ILogger _logger;
        public ItemService(InsuranceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Item> Create(Item item)
        {
            _dbContext.Add(item);
            await _dbContext.SaveChangesAsync();

            return item;
        }

        public async Task<Item?> GetById(int id)
        {
            return await _dbContext.Items.FindAsync(id);
        }

        public async Task Delete(int id)
        {
            Item? item= await _dbContext.Items.FindAsync(id);
            if (item is null) return;

            _dbContext.Remove(item);
            await _dbContext.SaveChangesAsync();
            
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
