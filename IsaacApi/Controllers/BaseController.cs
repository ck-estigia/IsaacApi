using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using IsaacApi.Model.Services.Facades;

namespace IsaacApi.Controllers
{
    public class BaseController : Controller
    {
        internal readonly IIsaacFacade _dataAccess;
        internal readonly IHostingEnvironment _hostingEnvironment;
        internal readonly IConfiguration _configuration;

        public BaseController(IIsaacFacade dataAccess, IHostingEnvironment hosting, IConfiguration cfg)
        {
            _dataAccess = dataAccess;
            _hostingEnvironment = hosting;
            _configuration = cfg;
        }
    }
}