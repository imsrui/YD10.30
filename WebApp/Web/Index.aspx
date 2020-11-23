<%@ Page Title="" Language="C#" MasterPageFile="~/Web/LayOut.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApp.Web.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>无标题文档</title>
<link href="assets/css1/style.css" rel="stylesheet" type="text/css" />
<script src="assets/js1/jquery-1.9.1.min.js" type="text/javascript"></script>
<script src="assets/js1/jquery.foucs.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    



 <div id="main">
    <div id="index_b_hero">
        <div class="hero-wrap">
                <ul class="heros clearfix">
                    <li class="hero">
                        <a href="#">
                            <img src="assets/images1/banner_1.jpg" />
                        </a>
                    </li>
                    <li class="hero">
                        <a href="#">
                            <img src="assets/images1/3.jpg" />
                        </a>
                    </li>
                    <li class="hero">
                        <a href="#">
                           <img src="assets/images1/2.jpg" />
                        </a>
                    </li>
                </ul>
            </div>
            <div class="helper">
                <div class="mask-left">
                </div>
                <div class="mask-right">
                </div>
                <a href="#" class="prev icon-arrow-a-left"></a>
                <a href="#" class="next icon-arrow-a-right"></a>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $.foucs({ direction: 'right' });
    </script>
    <!-- 代码 结束 -->


<div class="main">
<div class="main_1">
<div class="main_1_1">
<div class="main_1_2"><span><a href="#"><img src="assets/images1/tiao_2.jpg" /></a></span><h3><a href="#">新闻中心</a></h3></div>
<div class="main_1_3"><div class="main_1_3_1"><a href="#"><img src="assets/images1/tu1.jpg" /></a></div>
<div class="main_1_3_2">
<div class="main_1_3_2_1">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
   <h3><a href="#"><%#Eval("Title") %></a></h3></div>
<div class="main_1_3_2_2"><a class="zi_3"" href="#"><%#Eval ("content") %></a> <a class="zi_2" href="#"> [ 查看详情 ]</a></div>
<div class="main_1_3_2_3"><%#Eval("CreateTime") %></div></ItemTemplate></asp:Repeater>
</div></div>
<div class="main_2"><div class="main_2_1">
  <div class="main_2_1_1"><h3><a href="#">2014.05.06</a></h3></div>
  <div class="main_2_1_2"><h3><a href="#">全国各地高考志愿填报指南</a></h3></div></div>
  <div class="main_2_1a">
  <div class="main_2_1_1a"><h3><a href="#">2014.05.06</a></h3></div>
  <div class="main_2_1_2a"><h3><a href="#">全国各地高考志愿填报指南</a></h3></div></div>
</div>
<div class="main_2"><div class="main_2_1">
  <div class="main_2_1_1"><h3><a href="#">2014.05.06</a></h3></div>
  <div class="main_2_1_2"><h3><a href="#">全国各地高考志愿填报指南</a></h3></div></div>
  <div class="main_2_1a">
  <div class="main_2_1_1a"><h3><a href="#">2014.05.06</a></h3></div>
  <div class="main_2_1_2a"><h3><a href="#">全国各地高考志愿填报指南</a></h3></div></div>
</div>
</div>
<div class="main_3"><div class="main_3_1"><span><a href="#"><img src="assets/images1/tiao_2.jpg" /></a></span><h3><a href="#">近期活动</a></h3></div>
<div class="main_3_2"><div class="main_3_2_1">
  <div class="main_3_2_1_1"><a href="#"><img src="assets/images1/tu4.jpg" /></a></div>
  <div class="main_3_2_1_2"> <h3><a href="#">民政部发文要求全国推广中</a></h3><ul><li><a href="#">为贯彻落实党的十八届三中全会精神，进一步转……</a></li></ul>
</div>
 </div>
 <div class="main_3_2_1">
  <div class="main_3_2_1_1"><a href="#"><img src="assets/images1/tu5.jpg" /></a></div>
  <div class="main_3_2_1_2"> <h3><a href="#">民政部发文要求全国推广中</a></h3><ul><li><a href="#">为贯彻落实党的十八届三中全会精神，进一步转……</a></li></ul>
</div>
 </div>
</div>
</div>
</div> 
<div class="main_4">
<div class="main_4_1"><span><a href="#"><img src="assets/images1/tiao_2.jpg" /></a></span><h3><a href="#">放映厅</a></h3></div>
</div>
<div class="main_5">
<div class="main_5_1">
<div class="main_5_1_1">
<div class="main_5_1_1_1"><a href="#"><img src="assets/images1/tu6.jpg" /></a></div>
<div class="main_5_1_1_2"><h3><a href="#">【资料】职业生涯规划国际研讨会</a></h3></div> 
</div>
<div class="main_6">
<div class="main_6_1"> <h3>July 15,2014</h3></div> 
<div class="main_6_2"><a href="#">点击查看详情</a></div>
</div>
</div>
<div class="main_5_1">
<div class="main_5_1_1">
<div class="main_5_1_1_1"><a href="#"><img src="assets/images1/tu7.jpg" /></a></div>
<div class="main_5_1_1_2"><h3><a href="#">关于我们，关于赢鼎教育</a></h3>
</div> 
</div>
<div class="main_6">
<div class="main_6_1"> <h3>July 15,2014</h3></div> 
<div class="main_6_2"><a href="#">点击查看详情</a></div>
</div>
</div>
<div class="main_5_1a">
<div class="main_5_1_1">
<div class="main_5_1_1_1"><a href="#"><img src="assets/images1/tu8.jpg" /></a></div>
<div class="main_5_1_1_2"><h3><a href="#">【资料】新书《大学毕业年薪十万》</a></h3>
</div> 
</div>
<div class="main_6">
<div class="main_6_1"> <h3>July 15,2014</h3></div> 
<div class="main_6_2"><a href="#">点击查看详情</a></div>
</div>
</div>
</div>

</div>
    </div>

<div class="clear"></div>
</asp:Content>
