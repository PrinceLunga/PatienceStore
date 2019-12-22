using Microsoft.EntityFrameworkCore;
using PatienceShoppingPlatform.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatienceShoppingPlatform.Context
{
    public class ShoppingItemsDbContext:DbContext
    {

        public ShoppingItemsDbContext(DbContextOptions option) : base(option)
        {
        }
        //public ShoppingItemsDbContext(DbContextOptions<ShoppingItemsDbContext> options) : base()
        //{

        //}

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Item>().HasData(new Item
            {
                CreatedBy = "Nondumiso Lunga",
                DateCreated = DateTime.Now.AddDays(-26),
                DateModified = new DateTime(),
                DateRemoved = new DateTime(),
                Description = "V-Neck man t-shirt",
                Id = 1,
                Image = null,
                ModifiedBy = "System Administrator",
                Name = "Plain white summer T-shirt",
                RemovedBy = null,
                Status = "Instock"

            }, new Item
            {
                Id = 2,
                Name = "Blue Jeams Short",
                Status = "Instock",
                ModifiedBy = " ",
                RemovedBy = " ",
                CreatedBy = "Prince Lunga",
                DateCreated = DateTime.Now.AddDays(-55),
                DateModified = new DateTime(),
                DateRemoved = new DateTime(),
                Description = "Young boys blue jeans",
                Image = null
               
            }
            , new Item
            {
                Id = 3,
                Name = "Blue Jeams Short skirrt",
                Status = "Instock",
                ModifiedBy = " ",
                RemovedBy = " ",
                CreatedBy = "Prince Lunga",
                DateCreated = DateTime.Now.AddDays(-65),
                DateModified = new DateTime(),
                DateRemoved = new DateTime(),
                Description = "Young girls blue jeans",
                Image = null
            }) ;
        }
    }
}
