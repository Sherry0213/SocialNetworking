<%@ Page Language="C#" MasterPageFile="~/HomePageTwo.master" AutoEventWireup="true" CodeFile="EstablishSocial.aspx.cs" Inherits="SocialNetWorkingUpdata.EstablishSocial" Title="悠悠社团网" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <style type="text/css">
    #all
    {
    	width:900px;
    	height:1000px;
    	background-image:url(images/6666.png);
    	}
    #title
    {
    	padding-top:25px;
    	margin-left:260px;
    	}
    #text
    {
    	padding-top:25px;
    	margin-left:260px;
    	}
    #name
    {
    	padding-top:30px;
    	margin-left:260px;
    	}  
    #logo
    {
    	padding-top:0px;
    	margin-left:373px;
    	} 
    #count
    {
    	padding-top:50px;
    	margin-left:260px;
    	} 
    #intro
    {
    	padding-top:50px;
    	margin-left:260px;
    	}
    .up
    {
    	padding-top:20px;
    	}	
    .box
    {
    	padding-top:20px;
    	}
    #button
    {
    	padding-top:50px;
    	padding-left:380px;
    	}

    .text2
    {
    	}
    .image
    {
    	}

        .style1
        {
            font-size: medium;
            font-family: 微软雅黑;
        }

        .style3
        {
            font-size: 39pt;
            font-family: 方正舒体;
            font-weight: bold;
            color: #99CCFF;
        }
    

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" Runat="Server">
<div id="all">
    <div id="butt">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button3" runat="server" Text="<<返回上页" BackColor=AliceBlue 
            Height="21px" Width="101px" onclick="Button3_Click"/><div/>
    <div id="title" class="style3">创&nbsp;&nbsp;&nbsp;建&nbsp;&nbsp;&nbsp;社&nbsp;&nbsp;&nbsp;团</div>
    <div id="name">
    <span class="style1">社团名称：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </span>
        <asp:TextBox ID="TextBoxName" runat="server" BorderWidth="1" 
        Height="27px" Width="198px"></asp:TextBox>
    </div>
    <div id="text">
    <span class="style1">社团logo：&nbsp;&nbsp;</span>
    </div>
    <div id="logo">
      <div class="image">       
      <asp:Image ID="Image1" runat="server" BorderWidth="1px" Height="111px" 
              Width="124px" />
      </div>
      <div class="up">
      <asp:FileUpload ID="FileUpload1" runat="server" Height="27px" Width="192px" />
      <asp:Button ID="Button1" runat="server" BorderWidth="1px" Text="显示图片" Height="20px" 
              Width="54px" BackColor="#e6e7e4" onclick="Button1_Click"/>
      </div>
    </div>
    <div id="count">
    <span class="style1">社团规模:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
    <asp:TextBox ID="TextBoxSize" 
            runat="server" BorderWidth="1" 
        Height="27px" Width="49px"></asp:TextBox><span class="style1">&nbsp;&nbsp;&nbsp;人数</span>
    </div>
    <div id="intro">
    <div class="text">
    <span class="style1">社团简述:&nbsp;&nbsp;</span></div>
    <div class="box">
    <asp:TextBox ID="TextBoxSk" 
            runat="server" BorderWidth="1" TextMode="MultiLine"
        Height="97px" Width="372px"></asp:TextBox></div>
    </div>
    <div id="button">
        <asp:Button ID="ButtonCreate" runat="server" Text="创建社团" Height="32px" 
            Font-Size="Medium" BackColor="AliceBlue" Font-Bold=true BorderWidth=1
            Width="118px" onclick="ButtonCreate_Click" />
    </div>
</div>        
</asp:Content>

