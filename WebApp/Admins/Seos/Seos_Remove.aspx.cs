using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using WebApp.App_Code;

namespace WebApp.Admins.Seos
{
    public partial class Seos_Remove : System.Web.UI.Page

    {
        private readonly SeosService sSvc = new SeosService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            var id = Guid.Parse(Request.Params["action"]);

            var rs = sSvc.PutTrash(id);

            var rm = rs > 0 ? new ReturnMsg()
            {
                Code = StatusCode.Ok,
                Message = "放入回收站成功",
                Data = null
            } : new ReturnMsg()
            {
                Code = StatusCode.Ok,
                Message = "放入回收站失败",
                Data = null
            };
            Session["Msg"] = rm;
            Response.Redirect("Seos_List.aspx");

        }
    }
}