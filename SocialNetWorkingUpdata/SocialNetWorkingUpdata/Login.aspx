<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SocialNetWorkingUpdata.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>登录</title>
        <style type="text/css">

    body
    {
	font-size:18px;
	font-family:"微软雅黑";
    }
    #container
    {
    	width:1017px;
    	height:auto;
    	}
#left{
width:567px;
float:left;
margin-top:120px;
margin-left:160px;
background-image:url('images/login.png');
height: 362px;
}
#right{
float:left;
width:450px;
height: 362px;
margin-top:120px;
background-color:#FBFBFF;
}
.head
{
	font-size:18;
	font-family:"宋体";
	text-align:center;
	padding-top:10px;
	}
.user
{
padding-top:35px;
padding-left:60px;
}
.paswd
{
padding-top:20px;
padding-left:60px;
	}
.code
{
padding-top:20px;
padding-left:60px;
	}
.choice
{
padding-top:25px;
padding-left:60px;
	}
.button
{
padding-top:37px;
padding-left:115px;
	}
</style>
</head>
<body>
    <form id="form1" runat="server">
      <div id="#container" style="height: 513px; width: 1326px">
        <div id="left" style="float:left;">
       
        </div>
        <div id="right">
        
         <div class="head"><strong><font size="5" color="#FF0000" face="楷体">欢迎登录</font></strong></div>
    
         <div class="user">用户名&nbsp;&nbsp;<asp:TextBox ID="username" runat="server" 
         BorderWidth="1px" Height="30px" Width="263px"></asp:TextBox></div>
    
         <div class="paswd"> &nbsp;&nbsp;密 码&nbsp;&nbsp;<asp:TextBox ID="password" runat="server" 
         BorderWidth="1px"  TextMode="Password" Height="30px" Width="260px" style="margin-left: 5px"></asp:TextBox></div>
         
         <div class ="code">验证码&nbsp;&nbsp;
         <asp:TextBox ID="txtAdminCode" runat="server" 
         BorderWidth="1px" Height="30px" Width="106px" style="margin-left: 3px"></asp:TextBox>&nbsp;&nbsp;
         <asp:Label ID="labCode" runat="server" Text="Label"></asp:Label>
          <asp:Button ID="ButtonLook" runat="server" Text="看不清" Height="36px" 
         style="margin-left: 20px" Width="68px" onclick="ButtonLook_Click"/>
         </div>
         
         <div class="choice">
         <asp:CheckBox ID="CheckBox1" runat="server" Text="是否记住密码" 
                 />
     
        
         </div>
    
         <div class="button">
         <asp:Button ID="ButtonLogin" runat="server" Text="登录"
         Height="40px" style="margin-left: 0px" Width="83px" onclick="ButtonLogin_Click"  />
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="ButtonRegister" runat="server" Text="注册"
         Height="40px" style="margin-left: 0px" Width="83px" 
                 onclick="ButtonRegister_Click" /></div>

        </div>
     </div>
    </form>
</body>
</html>
