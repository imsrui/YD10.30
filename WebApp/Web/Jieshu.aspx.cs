using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Web
{
    public partial class Jieshu : System.Web.UI.Page
    {
        private readonly FreeService fs = new FreeService();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Repeater2.DataSource = fs.GetAll();
            this.Repeater2.DataBind();

            this.Repeater3.DataSource = fs.GetAll();
            this.Repeater3.DataBind();
            this.Repeater1.DataSource = fs.GetAll();
            this.Repeater1.DataBind();
            this.Repeater4.DataSource = fs.GetAll();
            this.Repeater4.DataBind();
        }
    }
}