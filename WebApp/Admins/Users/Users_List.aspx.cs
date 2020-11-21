using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Admins.Users
{
    public partial class Users_List : System.Web.UI.Page
    {
        private readonly UsersService us = new UsersService();
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
        public void Bind(string nickName) {
            var data = us.GetByNickName(nickName);
            PagedDataSource pds = new PagedDataSource();
            pds.DataSource = data;
            pds.AllowPaging = true;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            pds.PageSize = AspNetPager1.PageSize;
            AspNetPager1.RecordCount = data.Count;
            this.RepUsersList.DataSource = pds;
            this.RepUsersList.DataBind();
        }
    }
}