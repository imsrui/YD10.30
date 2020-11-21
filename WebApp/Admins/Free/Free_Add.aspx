<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Leyout.Master" AutoEventWireup="true" CodeBehind="Free_Add.aspx.cs" Inherits="WebApp.Admins.Free.Free_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">新增书名</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>名称:</label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>标题:</label>
                        <asp:TextBox ID="txtTitle"  runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>价格:</label>
                        <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>版权:</label>
                       <asp:TextBox ID="txtPublish" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                   
                    <div class="form-group">
                        <label>作者:</label>
                        <asp:TextBox ID="txtAuthor" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                   
                    
                    <div class="form-group">
                        <label>内容:</label>
                        <asp:TextBox ID="txtContent" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                   
                    <div class="form-group">
                        <label>目录:</label>
                        <asp:TextBox ID="txtCatalohue" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>部分:</label>
                        <asp:TextBox ID="txtPortion" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                   
                         <div class="form-group">
                        <label>父级导航:</label>
                        <asp:TextBox ID="txtPrientId" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                   
                    <div class="form-group">
                        <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server"  Text="保存" CssClass="btn btn-primary" />
                        <asp:Button ID="btnReset" OnClick="btnReset_Click" runat="server" Text="重置" CssClass="btn btn-danger" />
                    </div>
                </div>
            </div>
            

        </div>
    </div>
</asp:Content>
