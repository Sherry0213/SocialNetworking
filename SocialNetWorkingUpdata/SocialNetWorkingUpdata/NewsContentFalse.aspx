<%@ Page Language="C#" MasterPageFile="~/HomePageOne.master" AutoEventWireup="true" CodeFile="NewsContentFalse.aspx.cs" Inherits="SocialNetWorkingUpdata.NewsContentFalse" Title="悠悠社团网" %>

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
    	#Div1
    {
    	padding-left:180px;
    	padding-top:30px;
    	}
    #content
    {
    	padding-left:180px;
    	padding-top:20px;
    	margin-top:5px;
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
        </div>
    <div id="title">
    <span class="style1">标题&nbsp;&nbsp;&nbsp;&nbsp;</span>
    <asp:Label ID="Label1" runat="server" Text="Label" Font-Bold="True" 
            Font-Size="Large"></asp:Label>
    </div>
    <div id="Div1">
    <span class="style1">作者&nbsp;&nbsp;&nbsp;&nbsp;</span>
    <asp:Label ID="Label3" runat="server" Text="Label" Font-Bold="True" 
            Font-Size="Large"></asp:Label>
    </div>
    <div id="content">
       <div class="text"><span class="style1">内容</span></div>
       <div class="box">
       <asp:TextBox ID="TextBox2" runat="server" Width="571px" Height="366px" 
                    TextMode="MultiLine" BorderStyle="None" style="margin-left: 0px" 
               Font-Bold="True" Font-Size="X-Large"></asp:TextBox>
       </div>
    </div>
    
</div>
</asp:Content>

