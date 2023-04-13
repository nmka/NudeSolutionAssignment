using Moq;
using NudeSolutionAssignment.Modules.Insurance.Repositories;
using NudeSolutionAssignment.Modules.Insurance.Services;

namespace NudeSolutionsAssingmentXUnitTests.Insurance.Systems.Services
{
    public class TestItemService
    {
        [Fact]
        public async Task GetById_WhenCalled_InvokesRepository()
        {
            var mockItemsRepo = new Mock<IItemsRepository>();

            var sut = new ItemsService(mockItemsRepo.Object);

            var result = await sut.GetAll();

            mockItemsRepo.Verify(repo => repo.GetAll(), Times.Once);
        }


    }
}
