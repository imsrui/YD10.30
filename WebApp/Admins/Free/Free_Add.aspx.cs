using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using WebApp.App_Code;

namespace WebApp.Admins.Free
{
    public partial class Free_Add : System.Web.UI.Page
    {
        private readonly FreeService fSvc = new FreeService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;

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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var res = fSvc.Add(new Model.reception.Free()
            {
                Free_Name = txtName.Text.Trim(),
                Free_ParentId = Guid.Parse(txtPrientId.Text.Trim()),
                Free_Title = txtTitle.Text.Trim(),
                Free_Price = int.Parse(txtPrice.Text.Trim()),
                Free_Publish = txtPublish.Text.Trim(),
                Free_Author = txtAuthor.Text.Trim(),
                Free_Content = txtContent.Text.Trim(),
                Free_Catalohue = txtCatalohue.Text.Trim(),
                Free_Portion = txtPortion.Text.Trim(),

            });
            ReturnMsg fs = res > 0 ? new ReturnMsg
            {
                Code = StatusCode.Ok,
                Message = "新增书名成功",
                Data = null

            } : new ReturnMsg
            {
                Code = StatusCode.Error,
                Message = "新增书名失败",
                Data = null
            };
            Session["Msg"] = fs;
            Response.Redirect("Free_List.aspx");

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";


              this.txtPrientId.Text = "";

            this.txtPrientId.Text = "";
            this.txtPrice.Text = "";
            this.txtPublish.Text = "";
            this.txtAuthor.Text = "";
            this.txtContent.Text = "";
            this.txtCatalohue.Text = "";
            this.txtPortion.Text = "";
        }
    }
}