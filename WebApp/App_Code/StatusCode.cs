using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.App_Code
{
    public enum StatusCode
    {
        Ok = 200,
        NotFound = 404,
        Frozen = 403,
        Error = 500
    }
}