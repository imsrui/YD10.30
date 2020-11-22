<%@ Page Title="" Language="C#" MasterPageFile="~/Web/LayOut.Master" AutoEventWireup="true" CodeBehind="Jieshu1.aspx.cs" Inherits="WebApp.Web.Jieshu1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>无标题文档</title>
<link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bennera">
<div class="benner_1a">
<div class="benner_2a"><img src="assets/images1/tu13.jpg" /></div>
</div>
</div>

<div class="jqq">
 <div class="jqq_1">
  <ul>
    <li class="li_9">在线订购</li>
    <li class="li_7">|</li>
    <li class="li_8"><a href="#">免费借书</a></li>
  </ul>
 </div>
</div>

<div class="xia">
 <div class="xia_1">
 <div class="xia_1_1">
   <h1>业务体系</h1><h2>Welcome to yingding education</h2></div>
 <div class="xia_1_2"><ul>
     <li>当前位置：</li><li><a href="#"> 首页</a> ></li> <li><a href="#">业务体系</a> ></li> <li class="li_6">&nbsp;免费借书</li>
 </ul></div>
 </div>
 <div class="jieshu"><img src="assets/images1/u1.png" /></div>
<div class="jieshu_1">
 <div class="shu_1a">
  <div class="shu_1"><img src="assets/images1/shu2.jpg" /></div>
  <div class="shu_2">
     
          <asp:Repeater ID="Repeater1" runat="server">
              <ItemTemplate>
                  <h2><%#Eval("Free_Name") %></h2>
           <h3><%#Eval("Free_Title") %><span style="color:#333333;">￥</span><span><%#Eval("Free_Price") %></span>  元</h3>
   <ul><li><%#Eval("Free_Publish") %> &nbsp;&nbsp;&nbsp;<%#Eval("Free_Author") %> &nbsp;&nbsp;&nbsp;<%#Eval("Free_Content") %></li></ul>
   <h2 class="h2_1"><%#Eval("Free_Catalohue") %></h2>
   <span><%#Eval("Free_Portion") %></span></ItemTemplate></asp:Repeater> </div>
 
    <div class="shu_3">
    <div class="shu_3_1"><b>目录</b></div>
     <div class="shu_3_2">
     <ul>
    
         <asp:Repeater ID="Repeater2" runat="server">
             <ItemTemplate> <li><%#Eval("Title") %></li></ItemTemplate>
         </asp:Repeater>
         
     </ul>
    <span><a href="#">显示部分信息</a></span>
     </div>
    </div>
    <div class="shu_3a">
    <div class="shu_3_1a"><b>在线试读部分章节</b></div>
     <div class="shu_3_2a">
     <ul>
         <asp:Repeater ID="Repeater3" runat="server"><ItemTemplate>

             <li><%#Eval("Contact") %></li>
                                                     </ItemTemplate></asp:Repeater>
    
     <li>　……P1</li>
     </ul>
     <span><a href="#"><img src="assets/images1/tu17.jpg" /></a></span>
     </div>
    </div>
  </div>
 </div>
</div>
<div class="clear"></div>
</asp:Content>
