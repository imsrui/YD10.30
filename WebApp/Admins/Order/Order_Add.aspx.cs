using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.App_Code;
using BLL;

namespace WebApp.Admins.Order
{
    public partial class Order_Add : System.Web.UI.Page
    {
        private readonly OrderService os = new OrderService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var model = new Model.reception.Order1
            {
                Order_Name = this.txtName.Text,
                Order_Price = int.Parse(this.txtPrice.Text),
                Order_Content = this.txtContent.Text,
                Order_WebMenusId = Guid.Parse(this.ddlWebMenuId.SelectedValue)
            };
            var res = os.Add(model);
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
            this.txtContent.Text = this.txtName.Text = this.txtPrice.Text = "";
            this.ddlWebMenuId.SelectedIndex = 0;
        }
    }
}