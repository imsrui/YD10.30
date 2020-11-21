using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using WebApp.App_Code;

namespace WebApp.Admins.Menu
{
    public partial class Menu_Add : System.Web.UI.Page
    {
        private readonly MenuService ms = new MenuService();
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var res = ms.Add(new Model.reception.Menu()
            {
                Menu_Title = txtTitle.Text.Trim(),
                 Menu_Href = txtHref.Text.Trim()
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
            Response.Redirect("Menus_list.aspx");

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtTitle.Text = "";
        }
    }
}