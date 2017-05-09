using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using IsaacApi.Model.Partial;
using IsaacApi.Model.Helpers;
using IsaacApi.Model.Services.Facades;

namespace IsaacApi.Controllers
{
    [Route("api/[controller]")]
    public class TranslationController : BaseController
    {
        public TranslationController(IIsaacFacade dataAccess, IHostingEnvironment hosting, IConfiguration cfg) : base(dataAccess, hosting, cfg)
        {
        }
        [HttpGet("languageId")]
        public List<ITranslation> Get(int languageId)
        {
            return _dataAccess.GetTranslations((IsaacLanguages)languageId);
        }
    }
}