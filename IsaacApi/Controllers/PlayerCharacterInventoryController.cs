using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using IsaacApi.Model.Entities;
using IsaacApi.Model.Services.Facades;

namespace IsaacApi.Controllers
{
    [Route("api/[controller]")]
    public class PlayerCharacterInventoryController : BaseController
    {
        public PlayerCharacterInventoryController(IIsaacFacade dataAccess, IHostingEnvironment hosting, IConfiguration cfg) : base(dataAccess, hosting, cfg)
        {
        }

        [HttpGet("{characterId}")]
        public List<CharacterInventory> Get(int characterId) {
            return _dataAccess.GetCharacterInventory(characterId);
        }
    }
}