using NudeSolutionAssignment.Models;

namespace NudeSolutionsAssingmentXUnitTests.Fixtures
{
    public static class ItemsFixture
    {
        public static List<Item> GetAll() => new()
        { new Item {Id = 1, Name = "Foo", Value = 100, CategoryId = 1 },
          new Item{Id = 2 , Name="Bar", Value = 300, CategoryId = 2 },
          new Item{Id = 3 , Name="Kit", Value = 200, CategoryId = 3 },
        };

    }
}
