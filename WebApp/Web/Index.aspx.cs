using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace WebApp.Web
{
    public partial class Index : System.Web.UI.Page
    {
        private readonly NewsService ns = new NewsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Repeater1.DataSource = ns.GetAll();
            this.Repeater1.DataBind();
        }
    }
}