using Microsoft.EntityFrameworkCore;
using NudeSolutionAssignment.Modules.Insurance.Models;
using NudeSolutionAssignment.Persistence;

namespace NudeSolutionAssignment.Modules.Insurance.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly InsuranceContext _dbContext;
        public CategoriesRepository(InsuranceContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Category?> GetById(int id)
        {
            return await _dbContext.Categories.FindAsync(id);
        }

        public Task<List<Category>> GetAllWithItems()
        {
            return _dbContext.Categories.Include("Items").ToListAsync();
        }
    }
}
