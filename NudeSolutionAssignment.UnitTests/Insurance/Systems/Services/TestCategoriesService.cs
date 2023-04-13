using Moq;
using NudeSolutionAssignment.Modules.Insurance.Repositories;
using NudeSolutionAssignment.Modules.Insurance.Services;

namespace NudeSolutionsAssingmentXUnitTests.Insurance.Systems.Services
{
    public class TestCategoriesService
    {
        [Fact]
        public async Task GetById_WhenCalled_InvokesRepository()
        {
            var mockCategoryRepo = new Mock<ICategoriesRepository>();
            ;
            var sut = new CategoriesService(mockCategoryRepo.Object);

            var result = await sut.GetAllWithItems();

            mockCategoryRepo.Verify(repo => repo.GetAllWithItems(), Times.Once);
        }


    }
}
