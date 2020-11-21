using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using WebApp.App_Code;

namespace WebApp.Admins.SystemMenus
{
    public partial class SystemMenus_Edit : System.Web.UI.Page
    {
        private readonly SystemMenuService smSvc = new SystemMenuService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind();

        }
        public void Bind() {
            Guid id = Request.Params["action"] == null ? Guid.Empty : Guid.Parse(Request.Params["action"]);
            if (id == Guid.Empty)
            {

                Response.Write("<script>alert('数据丢失,请重试';location.href='SystemMenus_List.aspx'</script>");
            }
                var data = smSvc.GetSystemMenus(id);
                this.HiddenField1.Value = data.SystemMenus_Id.ToString();
                this.txtName.Text = data.SystemMenus_Title;
                this.txtLink.Text = data.SystemMenus_Link;
                this.txtIcon.Text = data.SystemMenus_Icon;

                if (data.SystemMenus_ParentId != Guid.Empty) {
                    var parentData = smSvc.GetSystemMenus(data.SystemMenus_ParentId);
                    if (parentData.SystemMenus_ParentId == Guid.Empty)
                    {
                        this.ddlFirst.SelectedValue = "2";
                        this.ddlSecond.Style.Add("display", "block");
                        var parentdatas = smSvc.GetSystemMenusByParentId(Guid.Empty);
                        this.ddlSecond.DataSource = parentdatas;
                        this.ddlSecond.DataTextField = "SystemMenus_Title";
                        this.ddlSecond.DataValueField = "SystemMenus_Id";
                        this.ddlSecond.DataBind();

                        this.ddlSecond.SelectedValue = parentData.SystemMenus_Id.ToString();

                    }
                    else {
                        this.ddlFirst.SelectedValue = "3";
                    
                    }

                }
                    
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
                this.ddlThird.DataSource = data;
                this.ddlThird.DataTextField = "SystemMenus_Title";
                this.ddlThird.DataValueField = "SystemMenus_Id";
                this.ddlThird.DataBind();
            }
        }

        protected void ddlSecond_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secondData = smSvc.GetSystemMenusByParentId(Guid.Parse(this.ddlSecond.SelectedValue));
            this.ddlThird.DataSource = secondData;
            this.ddlThird.DataTextField = "SystemMenus_Title";
            this.ddlThird.DataValueField = "SystemMenus_Id";
            this.ddlThird.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var data = smSvc.GetSystemMenus(Guid.Parse(this.HiddenField1.Value));
            data.SystemMenus_Title = this.txtName.Text;
            data.SystemMenus_Link = this.txtLink.Text;
            data.SystemMenus_Icon = this.txtIcon.Text;

            if (this.ddlFirst.SelectedValue == "1")
            {
                data.SystemMenus_ParentId = Guid.Empty;

            }
            else if (this.ddlFirst.SelectedValue == "2")
            {
                data.SystemMenus_ParentId = Guid.Parse(this.ddlSecond.SelectedValue);

            }
            else if (this.ddlFirst.SelectedValue == "3") {

                data.SystemMenus_ParentId = Guid.Parse(this.ddlThird.SelectedValue);
            }
            data.SystemMenus_UpdateTime = DateTime.Now;
            var res = smSvc.Edit(data);
            ReturnMsg rm = res > 0 ? new ReturnMsg()
            {
                Code = StatusCode.Ok,
                Message = "编辑系统菜单成功",
                Data = null
            } : new ReturnMsg()
            {
                Code = StatusCode.Error,
                Message = "编辑系统菜单失败",
                Data = null
            };
            Session["Msg"] = rm;
            Response.Redirect("SystemMenus_List.aspx");

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Bind();
        }
    }
}