using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.Admins.UsersPermissions
{
    public partial class UsersPermissions_List : System.Web.UI.Page
    {
        private readonly RolesService rSvc = new RolesService();
        private readonly UsersPermissionsService upSvc = new UsersPermissionsService();
       
        private readonly SystemMenuService smSvc = new SystemMenuService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;



            RolesBind();
            Bind();
        }


        

        protected void Button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.RepNoHad.Items.Count; i++)
            {
                CheckBox cb = (CheckBox)this.RepNoHad.Items[i].FindControl("ckNoHavId");
                Label lbl = (Label)this.RepNoHad.Items[i].FindControl("MenuId");
                if (cb != null)
                {
                    if (cb.Checked)
                    {
                        upSvc.Add(new Model.UsersPermissions()
                        {
                            UsersPermissions_RolesId = Guid.Parse(this.ddlRoles.SelectedValue),
                            UsersPermissions_SystemMenuId = Guid.Parse(lbl.Text)
                        });
                    }
                }
            }

            Response.Redirect("UsersPermissions_List.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.RepHad.Items.Count; i++)
            {
                CheckBox cb = (CheckBox)this.RepHad.Items[i].FindControl("ckId");
                Label lbl = (Label)this.RepHad.Items[i].FindControl("UsersPermissionId");
                if (cb != null)
                {
                    if (cb.Checked)
                    {
                        upSvc.Delete(Guid.Parse(lbl.Text));
                    }
                }
            }
            Response.Redirect("UsersPermissions_List.aspx");
        }

       
        public void RolesBind()
        {
            var data = rSvc.GetAll();
            this.ddlRoles.DataSource = data;
            this.ddlRoles.DataValueField = "Roles_Id";
            this.ddlRoles.DataTextField = "Roles_Title";
            this.ddlRoles.DataBind();
        }
        public void Bind()
        {
           
     
            var val = Guid.Parse(this.ddlRoles.SelectedValue);
           
            var data = upSvc.GetUsersPermissionsesByRolesId(val);
            this.RepHad.DataSource = data; 
            this.RepHad.DataBind();
            string idList = "";
            foreach (var item in data)
            {
                idList += "'" + item.UsersPermissions_SystemMenuId.ToString() + "',";
            }

            if (data.Count > 0)
            {
                
                var menus = smSvc.GetSystemMenusesByIdList(idList.Substring(0, idList.Length - 1));
                this.RepNoHad.DataSource = menus;
                this.RepNoHad.DataBind();
            }
            else
            {
                var menus = smSvc.GetAll();
                this.RepNoHad.DataSource = menus;
                this.RepNoHad.DataBind();
            }




        }
      
        public string GetMenuTitle(Guid menuid) {
            var data = smSvc.GetSystemMenus(menuid);
            return data.SystemMenus_Title;
        
        }

        protected void ddlRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bind();
        }
    }
}