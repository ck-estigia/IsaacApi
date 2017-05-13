using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using IsaacApi.Model.Entities;
using IsaacApi.Model.Services.Facades;
using Microsoft.AspNetCore.Authorization;

namespace IsaacApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class CharacterBuildController : BaseController
    {
        public CharacterBuildController(IIsaacFacade dataAccess, IHostingEnvironment hosting, IConfiguration cfg) : base(dataAccess, hosting, cfg)
        {
        }

        [HttpGet("{playerCharacterId}")]
        public List<CharacterBuild> Get(int playerCharacterId)
        {
            return _dataAccess.GetCharacterBuilds(playerCharacterId);
        }
    }
}