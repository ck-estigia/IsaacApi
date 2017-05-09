using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaacApi.Helpers
{
    public class IsaacExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;
            context.Result = new ObjectResult(new IsaacErrorresponse(context.Exception.Message))
            {
                StatusCode = 500,
                DeclaredType = typeof(IsaacErrorresponse)
            };
        }
    }
}
