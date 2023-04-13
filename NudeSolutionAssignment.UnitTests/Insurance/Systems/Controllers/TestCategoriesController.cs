using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NudeSolutionAssignment.Modules.Insurance.Controllers;
using NudeSolutionAssignment.Modules.Insurance.Models;
using NudeSolutionAssignment.Modules.Insurance.Services;
using NudeSolutionsAssingmentXUnitTests.Insurance.Fixtures;

namespace NudeSolutionsAssingmentXUnitTests.Insurance.Systems.Controllers
{
    public class TestCategoriesController
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnsStatusCode200()
        {
            //Arrange
            var mockCategoriesService = new Mock<ICategoriesService>();
            var sut = new ItemCategoriesController(mockCategoriesService.Object);

            //Act
            var result = (OkObjectResult)await sut.GetAllWithItems();

            //Assert
            result.StatusCode.Should().Be(200);
        }
        [Fact]
        public async Task Get_OnSuccess_InvokesItemService()
        {

            var mockCategoriesService = new Mock<ICategoriesService>();
            mockCategoriesService.Setup(service => service.GetAllWithItems()).ReturnsAsync(CategoriesFixture.GetAll());
            var sut = new ItemCategoriesController(mockCategoriesService.Object);

            var result = (OkObjectResult)await sut.GetAllWithItems();

            mockCategoriesService.Verify(service => service.GetAllWithItems(), Times.Once);
        }

        [Fact]
        public async Task Get_OnSuccess_ReturnsListOfUsers()
        {

            var mockCategoriesService = new Mock<ICategoriesService>();
            mockCategoriesService.Setup(service => service.GetAllWithItems()).ReturnsAsync(CategoriesFixture.GetAll());
            var sut = new ItemCategoriesController(mockCategoriesService.Object);

            var result = await sut.GetAllWithItems();

            result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult)result;
            objectResult.Value.Should().BeOfType<List<Category>>();
        }

        [Fact]
        public async Task GetById_OnSuccess_ReturnsUser()
        {

            var mockCategoriesService = new Mock<ICategoriesService>();
            mockCategoriesService.Setup(service => service.GetById(1)).ReturnsAsync(CategoriesFixture.GetAll().First());

            var sut = new ItemCategoriesController(mockCategoriesService.Object);
            var result = await sut.GetById(1);

            result.Should().BeOfType<OkObjectResult>();
            var objectResult = (OkObjectResult)result;
            objectResult.Value.Should().BeOfType<Category>();
        }
    }
}
