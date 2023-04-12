using Moq;
using NudeSolutionAssignment.Models;
using NudeSolutionAssignment.Persistence;
using NudeSolutionAssignment.Services;
using NudeSolutionsAssingmentXUnitTests.Fixtures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NudeSolutionsAssingmentXUnitTests.Systems.Services
{
    public class TestCategoriesService
    {
        //[Fact]
        //public async Task GetById_WhenCalled_DbContext()
        //{
        //    var mockdbContext = new Mock<InsuranceContext>();

        //    mockdbContext.Setup(x => x.Categories.FindAsync(1).Result).Returns(CategoriesFixture.GetAll().Find(e => e.Id == 1) ?? new Category());
        //    var sut = new CategoriesService(mockdbContext.Object);

        //    var result = await sut.GetAllWithItems();

        //    mockdbContext.Verify(db => db.Items.ToList(), Times.Once);
        //}


    }
}
