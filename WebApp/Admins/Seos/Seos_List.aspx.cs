using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Admins.Seos
{
    public partial class Seos_List : System.Web.UI.Page
    {
        private readonly SeosService sSvc = new SeosService();
        private readonly WebMenusService wmSvc = new WebMenusService();
        protected void Page_Load(object sender, EventArgs e)
        {if (IsPostBack)
                return;
            Bind("");
        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            Bind(this.txtSearch.Text);

        }
        public void Bind(string title)
        {
            var data = sSvc.GetSeosByTitle(title);

            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            AspNetPager1.RecordCount = data.Count;
            pds.PageSize = AspNetPager1.PageSize;

            this.RepSeosList.DataSource = pds;
            this.RepSeosList.DataBind();

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Bind(this.txtSearch.Text);
        }
        public string getWebMenuTitle(Guid id) {

            var data = wmSvc.GetWebMenus(id);
            if (data == null)
                return "";
            else
                return data.WebMenus_Title;
        
    }
    }
}