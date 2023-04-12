using NudeSolutionAssignment.Models;
using NudeSolutionAssignment.Persistence;

namespace NudeSolutionAssignment.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly InsuranceContext _dbContext;


        public CategoryService(InsuranceContext dbContext)
        {
            _dbContext = dbContext;
     
        }

        public void Create(Category category)
        {
            _dbContext.Add(category);
            _dbContext.SaveChanges();
        }

        public Category? GetById(int id)
        {
            return _dbContext.Categories.Find(id);
        }

        public void Delete(int id)
        {
            Category? category = _dbContext.Categories.Find(id);
            if (category is null) return;

            _dbContext.Remove(category);
            _dbContext.SaveChanges();
        }

        public void Update(Category category)
        {
            var isExists = _dbContext.Categories.Any(x => x.Id == category.Id);
            if (!isExists) return;

            _dbContext.Update(category);
            _dbContext.SaveChanges();
        }

        public List<Category> GetAll()
        {
            return _dbContext.Categories.ToList();
        }
    }
}
