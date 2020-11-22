using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using WebApp.App_Code;

namespace WebApp.Admins.Try
{
    public partial class Try_Add : System.Web.UI.Page
    {
        private readonly TryService ts = new TryService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var res = ts.Add(new Model.reception.Try()
            {

                Contact = txtContact.Text.Trim(),
                ParentId = int.Parse(txtParentId.Text.Trim()),


            });
            ReturnMsg fs = res > 0 ? new ReturnMsg
            {
                Code = StatusCode.Ok,
                Message = "新增书名成功",
                Data = null

            } : new ReturnMsg
            {
                Code = StatusCode.Error,
                Message = "新增书名失败",
                Data = null
            };
            Session["Msg"] = fs;
            Response.Redirect("Try_Add.aspx");

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtContact.Text = "";
            this.txtParentId.Text = "";
        }
    }
}