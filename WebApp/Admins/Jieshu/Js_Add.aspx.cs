using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using WebApp.App_Code;

namespace WebApp.Admins.Jieshu
{
    public partial class Js_Add : System.Web.UI.Page
    {
        private readonly JsService jss = new JsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var res = jss.Add(new Model.reception.jieshu()
            {
                Name = txtName.Text.Trim(),
                Title = txtTitle.Text.Trim(),
                Link = txtLink.Text.Trim(),
                Contact = txtContact.Text.Trim(),
                 Image = upFileName(this.FileUpload1, "../../upload/Jieshu/"),


            }) ;
            ReturnMsg fs = res > 0 ? new ReturnMsg
            {
                Code = StatusCode.Ok,
                Message = "新增成功",
                Data = null

            } : new ReturnMsg
            {
                Code = StatusCode.Error,
                Message = "新增失败",
                Data = null
            };
            Session["Msg"] = fs;
            Response.Redirect("Jieshu_List.aspx");

        

    }

        protected void btnReset_Click(object sender, EventArgs e)
        {
        this.txtName.Text = "";
            this.txtContact.Text = "";
            this.txtLink.Text = "";
            this.txtTitle.Text = "";
            
        }
        public string upFileName(FileUpload f, string url)
        {
            string res = "";
            Random ran = new Random();
            string filePath = f.FileName;
            string fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + Convert.ToString(ran.Next(1, 1 + 9999));
            if (filePath != "")
            {
                string fileType = filePath.Substring(filePath.LastIndexOf(".") + 1);
                //string filePic = Server.MapPath(url + filePath);
                string filePic = Server.MapPath(url + fileName + "." + fileType);
                f.PostedFile.SaveAs(filePic);
                res = fileName + "." + fileType;
            }
            return res;
        }
    }
}