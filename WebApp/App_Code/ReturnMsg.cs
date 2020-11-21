using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.App_Code
{
    public class ReturnMsg
    {
        public StatusCode Code { get; set; }

        public string Message { get; set; }

        public object Data { get; set; }
    }
}