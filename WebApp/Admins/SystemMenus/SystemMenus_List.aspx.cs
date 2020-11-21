using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace WebApp.Admins.SystemMenus
{
    public partial class SystemMenus_List : System.Web.UI.Page
    {
        private readonly SystemMenuService sms = new SystemMenuService();
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
            var data = sms.GetSystemMenuByTitle(title);
            PagedDataSource pds = new PagedDataSource();

            pds.AllowCustomPaging = true;
            pds.DataSource = data;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;

            AspNetPager1.RecordCount = data.Count;
            this.RepSystemMenusList.DataSource = pds;
            this.RepSystemMenusList.DataBind();
        
        
        }

        public string GetMenusTitle(Guid id)
        {
            if (id == Guid.Empty) {

                return "一级菜单";
            
            }
            var data = sms.GetSystemMenus(id);
            return data.SystemMenus_Title;
        
        }   }
}