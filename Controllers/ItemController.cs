using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatienceShoppingPlatform.Business;
using PatienceShoppingPlatform.DataAccess;
using PatienceShoppingPlatform.DataAccess.Repository;

namespace PatienceShoppingPlatform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        private IRepository<Item> _itemBusiness = null;


        public ItemController(IRepository<Item> itemBusiness)
        {
            _itemBusiness = itemBusiness;
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            return Ok(_itemBusiness.GetAll());
        }
                
    }
}