using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Admins.Free
{
    public partial class Free_List : System.Web.UI.Page
    {
        private readonly FreeService fs = new FreeService();
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
            Bind(this.btnSearch.Text);

        }
        public void Bind(string title){
            PagedDataSource pds = new PagedDataSource();

            var data= fs.GetByTitle(title);
            pds.AllowPaging = true;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.DataSource = data;
            pds.PageSize = AspNetPager1.PageSize;

            AspNetPager1.RecordCount = data.Count;
            this.RepFreeList.DataSource = pds;
            this.RepFreeList.DataBind();
            
            
            }
    }
}