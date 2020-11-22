using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using WebApp.App_Code;

namespace WebApp.Admins.News
{
    public partial class News_Add : System.Web.UI.Page
    {
        private readonly NewsService ns = new NewsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            

            var res = ns.Add(new Model.reception.News()
            {
                Title=txtTitle.Text.Trim(),
                content = txtContact.Text.Trim(),
                ParentId = Guid.Parse(txtParentId.Text.Trim()),
                Image = upFileName(this.FileUpload1, "../../upload/News/"),


            });
            ReturnMsg fs = res > 0 ? new ReturnMsg
            {
                Code = StatusCode.Ok,
                Message = "新增新闻成功",
                Data = null

            } : new ReturnMsg
            {
                Code = StatusCode.Error,
                Message = "新增新闻失败",
                Data = null
            };
            Session["Msg"] = fs;
            Response.Redirect("News_Add.aspx");

        }
  

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtTitle.Text = "";
            this.txtContact.Text = "";
            this.txtParentId.Text = "";

           

        
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