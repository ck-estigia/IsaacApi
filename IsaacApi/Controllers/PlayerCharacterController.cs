using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using IsaacApi.Model.Entities;
using IsaacApi.Model.Services.Facades;

namespace IsaacApi.Controllers
{
    [Route("api/[controller]")]
    public class PlayerCharacterController:BaseController
    {
        public PlayerCharacterController(IIsaacFacade dataAccess, IHostingEnvironment hosting, IConfiguration cfg) : base(dataAccess, hosting, cfg)
        {
        }

        [HttpGet]
        public List<PlayerCharacter> Get()
        {
            return _dataAccess.GetCharacters();
        }

        [HttpPost]
        public PlayerCharacter Create([FromBody] PlayerCharacter character)
        {
            return _dataAccess.CreateCharacter(character);
        }

        [HttpPut]
        public IActionResult Update([FromBody] PlayerCharacter character)
        {
            _dataAccess.UpdateCharacter(character);
            return new NoContentResult();
        }

        [HttpDelete("{characterId}")]
        public IActionResult Delete(int characterId)
        {
            _dataAccess.DeleteCharacter(characterId);
            return new NoContentResult();
        }
    }
}