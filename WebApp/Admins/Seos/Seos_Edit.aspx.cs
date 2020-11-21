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
    public partial class Seos_Edit : System.Web.UI.Page
    {
        private readonly WebMenusService wmSvc = new WebMenusService();
        private readonly SeosService sSvc = new SeosService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;


           

            this.ddlWebMenuId.DataSource = wmSvc.GetAll();
            this.ddlWebMenuId.DataValueField = "WebMenus_Id";
            this.ddlWebMenuId.DataTextField = "WebMenus_Title";
            this.ddlWebMenuId.DataBind();
           

            Bind();
        }
        public void Bind()
        {
            var id = Guid.Parse(Request.Params["action"]);
            var data = sSvc.GetSeosById(id);
            if (data == null)
            {
                var rm = new ReturnMsg()
                {
                    Code = StatusCode.Error,
                    Message = "数据丢失,请稍后再试",
                    Data = null
                };
                Session["Msg"] = rm;
                Response.Redirect("Seos_List.aspx");
            }
            else
            {
                this.hfSeosId.Value = data.Seos_Id.ToString();
                this.txtName.Text = data.Seos_Title;
                this.txtKeyword.Text = data.Seos_Keyword;
                this.txtDescription.Text = data.Seos_Description;
                this.ddlWebMenuId.SelectedValue = data.Seos_WebMenuId.ToString();
            }
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var id = Guid.Parse(this.hfSeosId.Value);
            var data = sSvc.GetSeosById(id);
            data.Seos_Title = this.txtName.Text;
            data.Seos_Keyword = this.txtKeyword.Text;
            data.Seos_Description = this.txtDescription.Text;
            data.Seos_WebMenuId = Guid.Parse(this.ddlWebMenuId.SelectedValue);
            var rs = sSvc.Edit(data);
            var rm = rs > 0 ? new ReturnMsg()
            {
                Code = StatusCode.Ok,
                Message = "编辑优化信息成功",
                Data = null
            } : new ReturnMsg()
            {
                Code = StatusCode.Error,
                Message = "编辑优化信息失败",
                Data = null
            };
            Session["Msg"] = rm;
            Response.Redirect("Seos_List.aspx");
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Bind();
        }
    }
}