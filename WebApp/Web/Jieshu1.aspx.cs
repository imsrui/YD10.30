using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace WebApp.Web
{
    public partial class Jieshu1 : System.Web.UI.Page
    {
        private readonly FreeService fs = new FreeService();
        private readonly CatalohueService cs = new CatalohueService();

        private readonly TryService ts = new TryService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            this.Repeater1.DataSource = fs.GetAll();
            this.Repeater1.DataBind();

            this.Repeater2.DataSource = cs.GetALL();
            this.Repeater2.DataBind();
            this.Repeater3.DataSource = ts.GetAll();
            this.Repeater3.DataBind();
        }
    }
}