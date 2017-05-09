using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IsaacApi.Helpers
{
    public class IsaacErrorresponse
    {
        public string Message { set; get; }
        public IsaacErrorresponse(string message)
        {
            Message = message;
        }
    }
}
