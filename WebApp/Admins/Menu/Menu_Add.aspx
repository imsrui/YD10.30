<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Leyout.Master" AutoEventWireup="true" CodeBehind="Menu_Add.aspx.cs" Inherits="WebApp.Admins.Menu.Menu_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title>新增菜单</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">新增菜单</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>菜单名称:</label>
                        <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>菜单路径:</label>
                        <asp:TextBox ID="txtHref" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="保存" CssClass="btn btn-primary" />
                        <asp:Button ID="btnReset" OnClick="btnReset_Click" runat="server" Text="重置" CssClass="btn btn-danger" />
                    </div>
                </div>
            </div>
            

        </div>
    </div>
</asp:Content>
