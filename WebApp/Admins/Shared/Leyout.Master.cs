using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.App_Code;
using Model;

namespace WebApp.Admins.Shared
{
    public partial class Leyout : System.Web.UI.MasterPage
    {
        public string msg = "initial";
        public int code = 0;
        private readonly SystemMenuService menuSvc = new SystemMenuService();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
                return;

            object ob = Session["Msg"];
            if (ob != null)
            {
                var res = ob as ReturnMsg;
                msg = res.Message;
                code = (int)res.Code;
                Session["Msg"] = null;
            }

            #region 一级菜单绑定
            //在这里我们还需要获取当前账号信息登入的权限等级
            object signIn = Session["LoginOk"];
            if (signIn != null)
            {
                Model.Users users = (Model.Users)signIn;
                Guid rid = users.Users_RolesId; //得到我们要用的权限id

                this.RepLeftNavi.DataSource = Bind(rid, Guid.Empty);
                this.RepLeftNavi.DataBind();
                this.lblNickName.Text = users.Users_NickName;
                this.Image1.ImageUrl = "../../upload/users/" + users.Users_Photo;
            }
            else
            {
                // Response.Write("<script>alert('登入超时,请重新登入');location.href='../Login.aspx'</script>");

                Console.WriteLine("请重新登陆");
            }

            #endregion

        }


        //一级菜单  ParentId   Guid.Empty


        public IList<Model.SystemMenus> Bind(Guid rid, Guid parentId)
        {
            var data = menuSvc.GetSystemMenusByRolesIdAndParnetId(rid, parentId);
            return data;
        }

        protected void RepLeftNavi_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            Label lbl = (Label)e.Item.FindControl("lblParentId");
            Repeater rep = (Repeater)e.Item.FindControl("RepSonMenu");
            object signIn = Session["LoginOk"];
            if (signIn != null)
            {
                Model.Users users = (Model.Users)signIn;
                Guid rid = users.Users_RolesId; //得到我们要用的权限id
                rep.DataSource = Bind(rid, Guid.Parse(lbl.Text));
                rep.DataBind();
            }
        }
    }
}