using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace WebApp.Admins.Order
{
    public partial class Order_List : System.Web.UI.Page
    {
        private readonly OrderService os = new OrderService();
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

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            AspNetPager1.CurrentPageIndex = e.NewPageIndex;
            Bind(this.txtSearch.Text);

        }
        public void Bind(string title)
        {

            var data = os.GetByName(title);
            PagedDataSource pds = new PagedDataSource();
            pds.AllowCustomPaging = true;
            pds.DataSource = data;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;

            AspNetPager1.RecordCount = data.Count;

            this.RepOrderList.DataSource = pds;
            this.RepOrderList.DataBind();
        }
    }
}