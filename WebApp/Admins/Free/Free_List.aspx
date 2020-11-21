<%@ Page Title="" Language="C#" MasterPageFile="~/Admins/Shared/Leyout.Master" AutoEventWireup="true" CodeBehind="Free_List.aspx.cs" Inherits="WebApp.Admins.Free.Free_List" %>
<%@ Register Assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row mb-1">
        <div class="col-md-10 col-md-offset-1">
            
            <div class="col-md-5">
                <%--<input type="text" class="form-control"/>--%>
                <asp:TextBox ID="txtSearch" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-md-4">
                <%--<button class="btn btn-primary">Go</button>--%>
                <asp:Button ID="btnSearch" runat="server" Text="Go" CssClass="btn btn-primary" OnClick="btnSearch_Click" />
                <a href="Free_Add.aspx" class="btn btn-success">Insert</a>
                <button class="btn btn-danger">Delete</button>
            </div>

        </div>
    </div>
    
    <div class="row">
        <div class="col-md-10 col-md-offset-1">
            <div class="panel">
                <div class="panel-heading">
                    <h3 class="panel-title">免费借书表</h3>
                </div>
                <div class="panel-body">
                    <table class="table table-bordered table-hover">
                        <thead>
                            <tr>
                                <th width="5%">编号</th>
                                <th width="5%">名称</th>
                                <th width="5%">标题</th>
                                <th width="5%">价格</th>

                                <th width="5%">版权</th>
                                <th width="5%">作者</th>
                                <th width="5%">内容</th>
                                <th width="5%">目录</th>
                                 <th width="5%">部分</th>
                                 <th width="5%">父级导航</th>

                             
                                <th width="5%">编辑</th>
                                <th width="5%">删除</th>

                            </tr>

                        </thead>
                        <tbody>
                        <asp:Repeater ID="RepFreeList" runat="server">
                            <ItemTemplate>
                                <tr>
                                    <td><%#Container.ItemIndex+1 %></td>
                                     <td>
                                         <%#Eval("Free_Name") %>
                                     </td>   
                                    <td>
                                        <%#Eval("Free_Title") %>
                                    </td>
                                    <td>
                                        <%#Eval("Free_Price") %>
                                    </td>
                                    <td>
                                        <%#Eval(" Free_Publish") %>
                                    </td>
                                    <td>
                                         <%#Eval("Free_Author") %>
                                     </td>   
                                    <td>
                                         <%#Eval("Free_Content") %>
                                     </td> 
                                    <td>
                                        <%#Eval("Free_Catalohue") %>
                                    </td>
                                    <td>
                                        <%#Eval("Free_Portion") %>
                                    </td>
                                    <td>
                                        <%#Eval("Free_ParentId") %>
                                    </td>
                                   
                                    <td>
                                        <a class="btn btn-warning" href='Free_Edit.aspx?action=<%#Eval("Free_Id") %>'>
                                            <span class="lnr lnr-pencil"></span> 修改
                                        </a>
                                    </td>
                                    <td>
                                        <a class="btn btn-danger" href='Free_Remove.aspx?action=<%#Eval("Free_Id") %>'>
                                            <span class="lnr lnr-trash"></span> 删除
                                        </a>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>

                        </tbody>


                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-10 col-md-offset-1">
            
            <div class="pagin">
                <webdiyer:AspNetPager ID="AspNetPager1" CssClass="pages" CurrentPageButtonClass="cpb"
                                      CustomInfoHTML="共%PageCount%页，当前为第%CurrentPageIndex%页，每页%PageSize%条"  
                                      CustomInfoTextAlign="Left" HorizontalAlign="Right" PageIndexBoxType="TextBox"  
                                      ShowCustomInfoSection="Left" ShowMoreButtons="False" ShowNavigationToolTip="True"
                                      runat="server" AlwaysShow="True" PageSize="8" ShowInputBox="Never"
                                      LayoutType="Table" OnPageChanging="AspNetPager1_PageChanging"
                                      FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" PrevPageText="上一页" 
                                      PagingButtonSpacing="2px" SubmitButtonClass="btngo">
                </webdiyer:AspNetPager>
            </div>


        </div>
    </div>
</asp:Content>
