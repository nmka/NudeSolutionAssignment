using Microsoft.EntityFrameworkCore;
using NudeSolutionAssignment.Modules.Insurance.Models;
using NudeSolutionAssignment.Modules.Insurance.Repositories;
using NudeSolutionAssignment.Persistence;

namespace NudeSolutionAssignment.Modules.Insurance.Services
{
    public class ItemsService: IItemsService
    {
        private readonly IItemsRepository _itemsRepository;
        public ItemsService(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        public async Task<Item?> Create(Item item)
        {
            return await _itemsRepository.Create(item);
        }

        public async Task<Item?> GetById(int id)
        {
            return await _itemsRepository.GetById(id);
        }

        public async Task<bool> Delete(int id)
        {
            return await _itemsRepository.Delete(id);
        }

        public async Task<Item?> Update(Item item)
        {
            return await _itemsRepository.Update(item);
        }

        public async Task<List<Item>> GetAll()
        {
            return await _itemsRepository.GetAll();
        }
    }
}
