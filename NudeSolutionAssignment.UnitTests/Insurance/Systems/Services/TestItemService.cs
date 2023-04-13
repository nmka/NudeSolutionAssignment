using Microsoft.EntityFrameworkCore;
using Moq;
using NudeSolutionAssignment.Persistence;
using NudeSolutionAssignment.Modules.Insurance.Services;
using NudeSolutionAssignment.Modules.Insurance.Models;

using Microsoft.Extensions.Logging;

namespace NudeSolutionsAssingmentXUnitTests.Insurance.Systems.Services
{
    public class TestItemService
    {
        //[Fact]
        //public async Task GetById_WhenCalled_DbContext()
        //{
        //    var mockdbContext = new Mock<InsuranceContext>();

        //    mockdbContext.Setup(x => x.Items.FindAsync(1).Result).Returns(ItemsFixture.GetAll().Find(e => e.Id == 1) ?? new Item());
        //    var sut = new CategoriesService(mockdbContext.Object);

        //    var result = await sut.GetAllWithItems();

        //    mockdbContext.Verify(db => db.Items.ToList(), Times.Once);
        //}


    }
}
