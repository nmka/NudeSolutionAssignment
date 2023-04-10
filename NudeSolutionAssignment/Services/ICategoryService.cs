using NudeSolutionAssignment.Models;

namespace NudeSolutionAssignment.Services
{
    public interface ICategoryService
    {

        public List<Category> GetAll();
        public Category? GetById(int id);
        public void Create(Category category);
        public void Update(Category category);
        public void Delete(int id);

    }
}
