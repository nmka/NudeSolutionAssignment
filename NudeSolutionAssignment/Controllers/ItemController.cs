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
        private readonly ILogger<ItemController> _logger;
        public ItemController(IItemService itemService, ILogger<ItemController> logger)
        {
            _logger = logger;
            _itemService = itemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(_itemService.GetAll());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            Item? item = _itemService.GetById(id);

            if(item == null) return NotFound();

            return Ok(item);
        }



        [HttpPost()]
        public async Task<IActionResult> Create(CreateItemRequest request)
        {
            return Ok(_itemService.Create(new Item(request.name, request.categoryId, request.amount)));
        }

        [HttpPut("{id:int}")]
        public void Update(int id, string name, float amount, int categoryId) {

        }
    }

  
}
