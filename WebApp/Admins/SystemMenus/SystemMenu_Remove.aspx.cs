using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.App_Code;
using BLL;
namespace WebApp.Admins.SystemMenus
{
    public partial class SystemMenu_Remove : System.Web.UI.Page
    {
        private readonly SystemMenuService smSvc = new SystemMenuService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Guid id = Request.Params["action"] == null ? Guid.Empty : Guid.Parse(Request.Params["action"]);
            if (id == Guid.Empty)
            {
                ReturnMsg rm = new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "数据丢失,请稍后再试",
                    Data = null
                };
                Session["msg"] = rm;
                Response.Redirect("SystemMenus_List.aspx");
            }
            else
            {
                var res = smSvc.PutTrash(id);
                ReturnMsg rm = res > 0 ? new ReturnMsg
                {
                    Code = StatusCode.Ok,
                    Message = "放入回收站成功",
                    Data = null
                } : new ReturnMsg
                {
                    Code = StatusCode.Error,
                    Message = "放入回收站失败",
                    Data = null
                };
                Session["msg"] = rm;
                Response.Redirect("SystemMenus_List.aspx");

            }

        
    }
    }
}