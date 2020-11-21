<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Leyout.Master" AutoEventWireup="true" CodeBehind="About_List.aspx.cs" Inherits="WebApp.Admins.About.About_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>编辑关于我们</title>
    <script charset="utf-8" src="../../kindeditor/kindeditor.js" type="text/javascript"></script>
    <script charset="utf-8" src="../../kindeditor/lang/zh_CN.js" type="text/javascript"></script>
    <script charset="utf-8" src="../../kindeditor/plugins/code/prettify.js" type="text/javascript"></script>
    <script type="text/javascript">
        KindEditor.ready(function (K) {
            var editor1 = K.create('#ContentPlaceHolder2_txtAboutContent', {
                cssPath: '../../kindeditor/plugins/code/prettify.css',
                uploadJson: './kindeditor/asp.net/upload_json.ashx',
                fileManagerJson: './kindeditor/asp.net/file_manager_json.ashx',
                allowFileManager: true,
                afterCreate: function () {
                    var self = this;
                    K.ctrl(document, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                }
            });
            prettyPrint();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">编辑关于我们</h3>
                </div>
                <div class="panel-body">
                    <asp:HiddenField ID="hfAboutId" runat="server" />
                    <div class="form-group">
                        <label>关于我们名称:</label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>关于我们内容:</label>
                        <textarea id="txtAboutContent" cols="100" rows="15" style="width:821px;height:400px;visibility:hidden;" runat="server"></textarea>
                    </div>
                    <div>
                        <label>关于我们图片:</label>
                        <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click"server" Text="保存" CssClass="btn btn-primary" />
                        <asp:Button ID="btnReset" OnClick="btnReset_Click" runat="server" Text="重置" CssClass="btn btn-danger" />
                    </div>
                </div>
            </div>
            

        </div>
    </div>
    
    
</asp:Content>
