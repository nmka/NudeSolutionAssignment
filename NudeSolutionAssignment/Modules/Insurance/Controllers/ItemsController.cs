using Microsoft.AspNetCore.Mvc;
using NudeSolutionAssignment.Modules.Insurance.Controllers.DTO;
using NudeSolutionAssignment.Modules.Insurance.Models;
using NudeSolutionAssignment.Modules.Insurance.Services;

namespace NudeSolutionAssignment.Modules.Insurance.Controllers
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
            throw new NotImplementedException();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _itemsService.Delete(id);

            if (result) return Ok();
            return NotFound();
        }

       
    }

  
}
