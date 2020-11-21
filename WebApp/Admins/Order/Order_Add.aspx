<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Leyout.Master" AutoEventWireup="true" CodeBehind="Order_Add.aspx.cs" Inherits="WebApp.Admins.Order.Order_Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>新增订购信息</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-md-offset-1 col-md-10">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">新增订购信息</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <label>订购书名:</label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>订购价格:</label>
                        <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>订购内容:</label>
                        <asp:TextBox ID="txtContent" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>订购菜单:</label>
                        <asp:DropDownList ID="ddlWebMenuId" CssClass="form-control" runat="server"></asp:DropDownList>
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
