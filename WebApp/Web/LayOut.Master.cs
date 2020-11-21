using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Web
{
    public partial class LayOut : System.Web.UI.MasterPage
    {
        private readonly MenuService ms = new MenuService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            this.RepMenuList.DataSource = ms.GetAll();
            this.RepMenuList.DataBind();
        }
    }
}