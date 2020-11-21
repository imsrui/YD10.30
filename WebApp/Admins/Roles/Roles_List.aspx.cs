using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Admins.Roles
{
    public partial class Roles_List : System.Web.UI.Page
    {
        private readonly RolesService rsvc = new RolesService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind("");
        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            Bind(this.txtSearch.Text);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Bind(this.txtSearch.Text);
        }

        public void Bind(string title) {

            var data = rsvc.GetByTitle(title);
            PagedDataSource pds = new PagedDataSource();
            pds.AllowCustomPaging = true;
            pds.DataSource = data;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;

            AspNetPager1.RecordCount = data.Count;

            this.RepRolesList.DataSource = pds;
            this.RepRolesList.DataBind();
        }
    }
}