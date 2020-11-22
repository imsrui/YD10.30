using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model.reception;
using WebApp.App_Code;

namespace WebApp.Admins.Catalohue
{
    public partial class Cl_Add : System.Web.UI.Page
    {
        private readonly CatalohueService cs = new CatalohueService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var res = cs.Add(new Model.reception.Catalogue()
            {

                Title = txtTitle.Text.Trim(),
                Link = txtTitle.Text.Trim(),


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
            Response.Redirect("Cl_Add.aspx");

        }
    

    protected void btnReset_Click(object sender, EventArgs e)
    {
            
            this.txtTitle.Text = "";
            this.txtLink.Text = "";
        }

}
}