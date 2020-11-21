using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.App_Code;

namespace WebApp.Admins.Roles
{
    public partial class Roles_Add : System.Web.UI.Page
    {
        private readonly RolesService rs = new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var res = rs.Add(new Model.Roles()
            {
                Roles_Title = txtName.Text.Trim()
            });
            ReturnMsg rm = res > 0 ? new ReturnMsg
            {
                Code = StatusCode.Ok,
                Message = "新增权限成功",
                Data = null

            } : new ReturnMsg
            {
                Code = StatusCode.Error,
                Message = "新增权限失败",
                Data = null
            };
            Session["Msg"] = rm;
            Response.Redirect("Roles_list.aspx");


        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtName.Text="";
        }
    }
}