<%@ Page Language="C#" MasterPageFile="~/HomePageTwo.master" AutoEventWireup="true" CodeFile="modifyStyle.aspx.cs" Inherits="SocialNetWorkingUpdata.modifyStyle" Title="悠悠社团网" %>

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
    	#emna
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
    	#count22
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
    <div id="title" class="style3">社&nbsp;&nbsp;&nbsp;团&nbsp;&nbsp;&nbsp;活&nbsp;&nbsp;&nbsp;动</div>
    <div id="emna">
        <span class="style1">社团：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelSocial" runat="server" Text="Label" Font-Size="Large"></asp:Label>
    </div>
    <div id="name">
    <span class="style1">活动主题：&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </span>
        <asp:TextBox ID="TextBoxName" runat="server" BorderWidth="1" 
        Height="27px" Width="198px"></asp:TextBox>
    </div>
    <div id="text">
    <span class="style1">活动logo：&nbsp;&nbsp;</span>
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
    <span class="style1">活动地点时间:&nbsp;&nbsp;</span>
    <asp:TextBox ID="TextBoxSize" 
            runat="server" BorderWidth="1" 
        Height="27px" Width="192px"></asp:TextBox><span class="style1"></span>
    </div>
     <div id="count22">
    <span class="style1">参与人员:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>
    <asp:TextBox ID="TextBox1" 
            runat="server" BorderWidth="1" 
        Height="27px" Width="192px"></asp:TextBox><span class="style1"></span>
    </div>
    
    <div id="intro">
    <div class="text">
    <span class="style1">活动内容:&nbsp;&nbsp;</span></div>
    <div class="box">
    <asp:TextBox ID="TextBoxSk" 
            runat="server" BorderWidth="1" TextMode="MultiLine"
        Height="97px" Width="372px"></asp:TextBox></div>
    </div>
    <div id="button">
        <asp:Button ID="ButtonCreate" runat="server" Text="发布活动" Height="32px" 
            Font-Size="Medium" BackColor="AliceBlue" Font-Bold=true BorderWidth=1
            Width="118px" onclick="ButtonCreate_Click" />
    </div>
</div> 
</asp:Content>

