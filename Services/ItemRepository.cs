using PatienceShoppingPlatform.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatienceShoppingPlatform.DataAccess.Repository
{
    public class ItemRepository :IRepository<Item>
    {
        private ShoppingItemsDbContext dbContext;

        public ItemRepository(ShoppingItemsDbContext shoppingItemsDbContext)
        {
            dbContext = shoppingItemsDbContext;
        }

        public void Delete(Item entity)
        {
            dbContext.Items.Remove(entity);
            dbContext.SaveChanges();
        }

     

        public IQueryable<Item> GetAll()
        {
            return dbContext.Items.AsQueryable();
        }

      
        public Item GetById(int id)
        {
            return dbContext.Items.FirstOrDefault(x => x.Id == id);
                
        }

        public void Insert(Item entity)
        {
            dbContext.Items.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(Item entity)
        {
            var _Item = dbContext.Items.SingleOrDefault(x => x.Id == entity.Id);

            _Item.Id = entity.Id;
            _Item.Name = entity.Name;
            _Item.RemovedBy = entity.RemovedBy;
            _Item.Status = entity.Status;
            _Item.DateRemoved = entity.DateRemoved;
            _Item.CreatedBy = entity.CreatedBy;
            _Item.DateCreated = entity.DateCreated;
            _Item.Description = entity.Description;

            dbContext.SaveChanges();

        }

        IQueryable<Item> IRepository<Item>.Find(Func<Item, bool> predicate)
        {
            throw new NotImplementedException();
        }
       
    }
}
