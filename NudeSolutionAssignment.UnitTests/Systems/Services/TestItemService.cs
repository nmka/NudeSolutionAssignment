using Microsoft.EntityFrameworkCore;
using Moq;
using NudeSolutionAssignment.Persistence;
using NudeSolutionAssignment.Services;
using NudeSolutionAssignment.Models;
using NudeSolutionsAssingmentXUnitTests.Fixtures;
using Microsoft.Extensions.Logging;

namespace NudeSolutionsAssingmentXUnitTests.Systems.Services
{
    public class TestItemService
    {
        [Fact]
        public async Task GetItemById_WhenCalled_DbContext()
        {
            var mockdbContext = new Mock<InsuranceContext>();

            mockdbContext.Setup(x => x.Items.FindAsync(1).Result).Returns(ItemFixture.GetAll().Find(e => e.Id == 1) ?? new Item());
            var mockLogger = new Mock<Logger>();
            var sut = new ItemService(mockdbContext.Object, mockLogger.Object);

            var result = await sut.GetAll();

            mockdbContext.Verify(db => db.Items.ToList(), Times.Once);
        }


    }
}
