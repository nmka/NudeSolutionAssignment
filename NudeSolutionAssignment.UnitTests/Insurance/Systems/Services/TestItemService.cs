using Microsoft.EntityFrameworkCore;
using Moq;
using NudeSolutionAssignment.Persistence;
using NudeSolutionAssignment.Modules.Insurance.Services;
using NudeSolutionAssignment.Modules.Insurance.Models;

using Microsoft.Extensions.Logging;
using NudeSolutionAssignment.Modules.Insurance.Repositories;

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
