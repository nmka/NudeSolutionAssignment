using Microsoft.AspNetCore.Mvc;
using NudeSolutionAssignment.Controllers.Contracts;
using NudeSolutionAssignment.Models;
using NudeSolutionAssignment.Services;

namespace NudeSolutionAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsService _itemsService;
        public ItemsController(IItemsService itemService)
        {
            _itemsService = itemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _itemsService.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            Item? item = await _itemsService.GetById(id);

            if(item == null) return NotFound();

            return Ok(item);
        }



        [HttpPost()]
        public async Task<IActionResult> Create(CreateItemRequest request)
        {
            return Ok(await _itemsService.Create(new Item { Name = request.name, CategoryId = request.categoryId, Value = request.value}));
        }

        [HttpPut("{id:int}")]
        public void Update(int id, string name, float amount, int categoryId) {

        }
    }

  
}
