using NudeSolutionAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NudeSolutionsAssingmentXUnitTests.Fixtures
{
    public class CategoriesFixture
    {
        public static List<Category> GetAll() => new()
        { new Category {Id = 1, Name = "Electronics"},
          new Category {Id = 2 , Name="Kitchen"},
          new Category {Id = 3 , Name="Kit" },
        };

    }
}
