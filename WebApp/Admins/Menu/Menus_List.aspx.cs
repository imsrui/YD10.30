using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Admins.Menu
{
    public partial class Menus_List : System.Web.UI.Page
    {
        private readonly MenuService ms = new MenuService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
            Bind("");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Bind(this.btnSearch.Text);

        }
        public void Bind(string title) {
            var data = ms.GetByTitle(title);
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.PageSize = AspNetPager1.PageSize;
            pds.DataSource = data;


            AspNetPager1.RecordCount = data.Count;
            this.RepMenuList.DataSource= pds;
            this.RepMenuList.DataBind();
        
        
        }


        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            Bind(this.txtSearch.Text);
        }
    }
}