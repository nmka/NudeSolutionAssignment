using Microsoft.AspNetCore.Mvc;
using NudeSolutionAssignment.Controllers.Contracts;
using NudeSolutionAssignment.Models;
using NudeSolutionAssignment.Services;

namespace NudeSolutionAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;
        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _itemService.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            Item? item = await _itemService.GetById(id);

            if(item == null) return NotFound();

            return Ok(item);
        }



        [HttpPost()]
        public async Task<IActionResult> Create(CreateItemRequest request)
        {
            return Ok(await _itemService.Create(new Item { Name = request.name, CategoryId = request.categoryId, Value = request.value}));
        }

        [HttpPut("{id:int}")]
        public void Update(int id, string name, float amount, int categoryId) {

        }
    }

  
}
