using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using IsaacApi.Model.Entities;
using IsaacApi.Model.Services.Facades;

namespace IsaacApi.Controllers
{
    [Route("api/[controller]")]
    public class InventoryAttributeController : BaseController
    {
        public InventoryAttributeController(IIsaacFacade dataAccess, IHostingEnvironment hosting, IConfiguration cfg) : base(dataAccess, hosting, cfg)
        {
        }

        [HttpGet]
        public List<InventoryAttribute> Get()
        {
            return _dataAccess.GetInventoryAttribute();
        }

        [HttpGet("{inventoryTypeId}")]
        public List<InventoryAttribute> Get(int inventoryTypeId)
        {
            return _dataAccess.GetInventoryAttribute(inventoryTypeId);
        }

    }
}