using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using IsaacApi.Model.Entities;
using IsaacApi.Model.Services.Facades;
using Microsoft.AspNetCore.Authorization;

namespace IsaacApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class WeaponController : BaseController
    {
        public WeaponController(IIsaacFacade dataAccess, IHostingEnvironment hosting, IConfiguration cfg) : base(dataAccess, hosting, cfg)
        {
        }

        [HttpGet]
        public List<Weapon> Get() {
            return _dataAccess.GetWeaponsInventory();
        }

        [HttpGet("{id}")]
        public List<Weapon> Get(int id) {
            return _dataAccess.GetWeaponsInventory(id);
        }
    }
}