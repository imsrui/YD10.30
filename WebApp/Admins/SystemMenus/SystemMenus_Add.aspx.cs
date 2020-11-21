using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;
using WebApp.App_Code;

namespace WebApp.Admins.SystemMenus
{
    public partial class SystemMenus_Add : System.Web.UI.Page
    {
        private readonly SystemMenuService smSvc = new SystemMenuService();
        protected void Page_Load(object sender, EventArgs e)
        {if (IsPostBack)
                return;

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var choose = this.ddlFirst.SelectedValue;
            Guid id = Guid.Empty;
            if (choose == "2") {


                id = Guid.Parse(this.ddlSecond.SelectedValue);
            } else if (choose == "3") {
                id = Guid.Parse(this.ddlThird.SelectedValue);

            }
            var model = new Model.SystemMenus
            {
                SystemMenus_Title = this.txtName.Text,
                SystemMenus_Link = this.txtLink.Text,
                SystemMenus_Icon = this.txtIcon.Text,
                SystemMenus_ParentId = id

            };


            var res = smSvc.Add(model);
            ReturnMsg rm = res > 0 ? new ReturnMsg() {
                Code = StatusCode.Ok,
                Message = "新增权限成功",
                Data = null
            } : new ReturnMsg() {
                Code=StatusCode.Error,
                Message="新增权限失败",
                Data=null
               

        };
            Session["Msg"] = rm;
            Response.Redirect("SystemMenus_List.aspx");

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {

        }

        protected void ddlSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secondData = smSvc.GetSystemMenusByParentId(Guid.Parse(this.ddlSecond.SelectedValue));
            this.ddlThird.DataSource = secondData;
            this.ddlThird.DataTextField = "SystemMenus_Title";
            this.ddlThird.DataValueField = "SystemMenus_Id";
            this.ddlThird.DataBind();
        }

        protected void ddlFirst_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ddlFirst.SelectedValue == "1")
            {
                this.ddlSecond.Style.Add("display", "none");
                this.ddlThird.Style.Add("display", "none");
            }
            else if (this.ddlFirst.SelectedValue == "2")
            {
                this.ddlSecond.Style.Add("display", "block");
                var data = smSvc.GetSystemMenusByParentId(Guid.Empty);
                this.ddlSecond.DataSource = data;
                this.ddlSecond.DataTextField = "SystemMenus_Title";
                this.ddlSecond.DataValueField = "SystemMenus_Id";
                this.ddlSecond.DataBind();

            }
            else if (this.ddlFirst.SelectedValue == "3")
            {
                this.ddlSecond.Style.Add("display", "block");
                this.ddlThird.Style.Add("display", "block");
                var data = smSvc.GetSystemMenusByParentId(Guid.Empty);
                this.ddlSecond.DataSource = data;
                this.ddlSecond.DataTextField = "SystemMenus_Title";
                this.ddlSecond.DataValueField = "SystemMenus_Id";
                this.ddlSecond.DataBind();

                var secondData = smSvc.GetSystemMenusByParentId(Guid.Parse(this.ddlSecond.SelectedValue));
                this.ddlThird.DataSource = secondData;
                this.ddlThird.DataTextField = "SystemMenus_Title";
                this.ddlThird.DataValueField = "SystemMenus_Id";
                this.ddlThird.DataBind();
            }
        }

       
        
    }
}