using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NudeSolutionAssignment.Controllers;
using NudeSolutionAssignment.Services;
using NudeSolutionAssignment.Models;
using Microsoft.Extensions.Logging;
using NudeSolutionsAssingmentXUnitTests.Fixtures;

namespace UnitTests.Systems.Controllers;

public class TestItemsController
{
    [Fact]
    public async Task Get_OnSuccess_ReturnsStatusCode200()
    {
        //Arrange

        var mockItemService = new Mock<IItemsService>();
        var mockLogger = new Mock<ILogger<ItemsController>>();
        var sut = new ItemsController(mockItemService.Object);

        //Act
        var result = (OkObjectResult)await sut.GetAll();

        //Assert
        result.StatusCode.Should().Be(200);
    }
    [Fact]
    public async Task Get_OnSuccess_InvokesItemService()
    {

        var mockItemService = new Mock<IItemsService>();
        mockItemService.Setup(service => service.GetAll()).ReturnsAsync(ItemsFixture.GetAll());
        var sut = new ItemsController(mockItemService.Object);

        var result = (OkObjectResult)await sut.GetAll();

        mockItemService.Verify(service => service.GetAll(), Times.Once);
    }

    [Fact]
    public async Task Get_OnSuccess_ReturnsListOfUsers()
    {

        var mockItemService = new Mock<IItemsService>();
        mockItemService.Setup(service => service.GetAll()).ReturnsAsync(ItemsFixture.GetAll());
        var sut = new ItemsController(mockItemService.Object);

        var result = await sut.GetAll();

        result.Should().BeOfType<OkObjectResult>();
        var objectResult = (OkObjectResult)result;
        objectResult.Value.Should().BeOfType<List<Item>>();
    }

    [Fact]
    public async Task GetById_OnSuccess_ReturnsUser()
    {

        var mockItemService = new Mock<IItemsService>();
        mockItemService.Setup(service => service.GetById(1)).ReturnsAsync(ItemsFixture.GetAll().First());

        var sut = new ItemsController(mockItemService.Object);
        var result = await sut.GetById(1);

        result.Should().BeOfType<OkObjectResult>();
        var objectResult = (OkObjectResult)result;
        objectResult.Value.Should().BeOfType<Item>();
    }

    [Fact]
    public async Task GetById_OnNoItemsFound_Returns404()
    {
        var mockItemService = new Mock<IItemsService>();

        var sut = new ItemsController(mockItemService.Object);

        var result = await sut.GetById(1);

        result.Should().BeOfType<NotFoundResult>();
    }


    [Theory]
    [InlineData(1, "Tv", 600)]
    [InlineData(2, "PlayStation", 400)]
    [InlineData(3, "gameboi", 20)]
    public void Create_OnSuccess_ReturnsStatusCode200(int id, string name, float amount)
    {

    }
}