using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.App_Code;
using BLL;

namespace WebApp.Admins.Seos
{
    public partial class Seos_Add : System.Web.UI.Page
    {
        private readonly SeosService sSvc = new SeosService();
        private readonly WebMenusService wmSvc = new WebMenusService();

        protected void Page_Load(object sender, EventArgs e)
        {if (IsPostBack)
                return;
          

            this.ddlWebMenuId.DataSource = wmSvc.GetAll();
            this.ddlWebMenuId.DataValueField = "WebMenus_Id";
            this.ddlWebMenuId.DataTextField = "WebMenus_Title";
            this.ddlWebMenuId.DataBind();

           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var model = new Model.Seos
            {
                Seos_Title = this.txtName.Text,
                Seos_Keyword = this.txtKeyword.Text,
                Seos_Description = this.txtDescription.Text,
                Seos_WebMenuId = Guid.Parse(this.ddlWebMenuId.SelectedValue)
            };
            var res = sSvc.Add(model);
            var rm = res > 0 ? new ReturnMsg()
            {
                Code = StatusCode.Ok,
                Message = "新增优化信息成功",
                Data = null
            } : new ReturnMsg()
            {
                Code = StatusCode.Error,
                Message = "新增优化信息失败",
                Data = null
            };
            Session["Msg"] = rm;
            Response.Redirect("Seos_List.aspx");

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtDescription.Text = this.txtName.Text = this.txtKeyword.Text = "";
            this.ddlWebMenuId.SelectedIndex = 0;

        }
    }
}