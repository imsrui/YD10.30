<%@ Page Title="" Language="C#" MasterPageFile="~/Web/LayOut.Master" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="WebApp.Web.order" %>
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
 </div></div>

<div class="xia">
 <div class="xia_1">
 <div class="xia_1_1">
   <h1>业务体系</h1><h2>Welcome to yingding education</h2></div>
 <div class="xia_1_2"><ul>
    <li> 当前位置：</li> <li><a href="#"> 首页</a> > </li><li><a href="#">业务体系</a>   > </li><li class="li_6">&nbsp;在线订购</li>
 </ul></div>
 </div>
 <div class="jieshu"><img src="assets/images1/tu18.jpg" /></div>
 <div class="jieshu_1">
  <div class="dingyue">
  <div class="dingyue_1"><a href="#"><img src="assets/images1/tu19.jpg" /></a></div>
  <div class="dingyue_2">
   <span><a href="#">查看详情</a></span> 
       <asp:Repeater ID="Repeater1" runat="server"><ItemTemplate><h2><a href="#"><%#Eval("Free_Name") %> </a></h2>
      
   <div class="dingyue_2_1"><ul><li class="li_a">标记</li><li class="li_b"><%#Eval("Free_Price")%></li><li>元</li></ul></div>
  <div class="dingyue_3"><%#Eval("Free_Content")%>  </div></ItemTemplate></asp:Repeater></div>
  </div>
           
  </div>
   


     
 <div class="jieshu_1">
  <div class="dingyue">
  <div class="dingyue_1"><a href="#"><img src="assets/images1/tu20.jpg" /></a></div>
  <div class="dingyue_2">
   <span><a href="#">查看详情</a></span> 
       <asp:Repeater ID="Repeater2" runat="server"> <ItemTemplate>
      <h2><a href="#"> <%#Eval("Free_Name") %> </a></h2>
   <div class="dingyue_2_1"><ul><li class="li_a">标记</li>
   <li class="li_c"><%#Eval("Free_Price")%></li><li>元</li></ul></div>
  <div class="dingyue_3"><%#Eval("Free_Content")%>  </div></ItemTemplate></asp:Repeater></div>
      </div>
 
  
 <div class="ye"></div>
     </div>
      </div>
  

<div class="clear"></div>


</asp:Content>
