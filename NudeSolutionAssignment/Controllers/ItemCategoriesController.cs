using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NudeSolutionAssignment.Models;
using NudeSolutionAssignment.Services;

namespace NudeSolutionAssignment.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemCategoriesController : ControllerBase
    {
        private readonly ICategoriesService _categoriesService;
        public ItemCategoriesController(ICategoriesService categoriesService) {
            _categoriesService = categoriesService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWithItems()
        {
            return Ok(await _categoriesService.GetAllWithItems());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var item = await _categoriesService.GetById(id);

            if (item == null) return NotFound();

            return Ok(item);
        }
    }


}
