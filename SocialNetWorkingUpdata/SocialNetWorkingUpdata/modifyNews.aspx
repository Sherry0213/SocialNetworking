<%@ Page Language="C#" MasterPageFile="~/HomePageTwo.master" AutoEventWireup="true" CodeFile="modifyNews.aspx.cs" Inherits="SocialNetWorkingUpdata.modifyNews" Title="悠悠社团网" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<style type="text/css">
    #all
    {
    	width:900px;
    	height:600px;
    	background-image:url(6666.png);
    	}
    #title
    {
    	padding-left:180px;
    	padding-top:30px;
    	}
    #content
    {
    	padding-left:180px;
    	padding-top:20px;
    	}
    .box
    {
    	padding-top:0px;
    	padding-left:50px;
    	}
    #button
    {
    	padding-top:40px;
    	padding-left:300px;
    	}
    .style1
    {
        font-size: medium;
        font-family: 微软雅黑;
    }
    #title2
    {
        height: 28px;
    }
    #titlelp
    {
        height: 39px;
    }
    #titlelp
    {
    	text-align:center;padding-top:20px;
    }
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" Runat="Server">
<div id="all">
    <div id="titlelp">
        <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" 
            Font-Size="Large"></asp:Label></div>
    <div id="title">
    <span class="style1">标题&nbsp;&nbsp;&nbsp;&nbsp;</span><asp:TextBox ID="TextBox1" runat="server" 
    BorderWidth="1px" Height="24px" Width="458px" BorderStyle="None" Font-Bold="True" Font-Size="Large"></asp:TextBox>
    </div>
    <div id="content">
       <div class="text"><span class="style1">内容</span></div>
       <div class="box">
       <asp:TextBox ID="TextBox2" runat="server" BorderWidth="1px" Height="270px"  BorderStyle="None"
              TextMode="MultiLine" Width="458px" Font-Size="Large" Font-Bold="True"></asp:TextBox>
       </div>
    </div>
    <div id="button">
        <asp:Button ID="Button1" runat="server" Text="发布新闻>>" BackColor=AliceBlue 
            onclick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回上页>>" BackColor=AliceBlue 
            onclick="Button2_Click" />
    </div>
</div>


</asp:Content>

