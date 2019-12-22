using PatienceShoppingPlatform.DataAccess;
using PatienceShoppingPlatform.DataAccess.Repository;
using PatienceShoppingPlatform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatienceShoppingPlatform.Business
{
    public class ItemBusiness
    {
        private readonly ItemRepository _itemRepository = null;

        public ItemBusiness(ItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public List<ItemDisplay> GetAllItems()
        {
            try
            {

                return _itemRepository.GetAll().Select(x => new ItemDisplay
                {
                    Id = x.Id,
                    CreatedBy = x.CreatedBy,
                    DateCreated = x.DateCreated,
                    DateRemoved = x.DateRemoved,
                    Description = x.Description,
                    Name = x.Name,
                    RemovedBy = x.RemovedBy,
                    Status = x.Status
                }).ToList();
            }
            catch (Exception ex)
            {

                throw new Exception();
            }
        }


        public void Insert(ItemDisplay itemDisplay)
        {
            try
            {
               // string imageData = @"data:image / jpeg; base64," + Convert.ToBase64String(File.ReadAllBytes(imgPath));

                var item = new Item
                {
                    Id = itemDisplay.Id,
                    Status = itemDisplay.Status,
                    RemovedBy = itemDisplay.RemovedBy,
                    Name = itemDisplay.Name,
                    CreatedBy = itemDisplay.CreatedBy,
                    DateCreated = itemDisplay.DateCreated,
                    DateRemoved = itemDisplay.DateRemoved,
                    Description = itemDisplay.Description
                };

                _itemRepository.Insert(item);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
