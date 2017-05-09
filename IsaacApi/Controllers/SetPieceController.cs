using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using IsaacApi.Model.Entities;
using IsaacApi.Model.Services.Facades;

namespace IsaacApi.Controllers
{
    [Route("api/[controller]")]
    public class SetPieceController : BaseController
    {
        public SetPieceController(IIsaacFacade dataAccess, IHostingEnvironment hosting, IConfiguration cfg) : base(dataAccess, hosting, cfg)
        {
        }

        [HttpGet]
        public List<SetPiece> Get() {
            return _dataAccess.GetSetPieces();
        }
    }
}