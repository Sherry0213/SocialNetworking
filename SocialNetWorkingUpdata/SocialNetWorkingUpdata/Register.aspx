<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SocialNetWorkingUpdata.Register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>UU注册</title>
    <style type="text/css">
    body{
	font-size:16px;
	font-family:"微软雅黑";
    }  
    #mainbody
    {
    	margin-top:50px;
    	margin-left:110px;
    	width:1100px;
    	height:500px;
        background-image:url("images/register.jpg");
    }  
    #content
    {
    padding-left:260px;	
    padding-top:5px;
        }
    .text
    {
    	padding-top:60px;
    	padding-left:520px;
	font-size:80;
	font-family:"黑体";
	
	}
    .style1{
            width: 96px;
        }
    .style2{
            width: 256px;
        }
    
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="mainbody">
    <div class = "text" ><font size="5" color="#FF0000" face="楷体">欢迎注册</font></div>
    <div id="content">
    <table style="width:719px; line-height:30px; height: 370px; padding-left:80px;padding-top:10px;">
                <tr>
                    <td class="style1">
                        用户名：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxName" runat="server" Width="250px" Height="28px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="TextBoxName" Display="Dynamic" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                            ControlToValidate="TextBoxName" Display="Dynamic" ErrorMessage="要求3到16个数字字母" 
                            ValidationExpression="[a-zA-Z0-9_-]{3,16}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        手机号：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxPhone" runat="server" Width="250px" Height="28px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                            ControlToValidate="TextBoxphone" Display="Dynamic" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ControlToValidate="TextBoxphone" Display="Dynamic" ErrorMessage="输入正确手机号" 
                            ValidationExpression="[0-9]{11}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        E-mail：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxmail" runat="server" Width="250px" Height="28px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                            ControlToValidate="TextBoxmail" Display="Dynamic" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                            ControlToValidate="TextBoxmail" Display="Dynamic" ErrorMessage="输入正确邮箱格式" 
                            ValidationExpression="[a-zA-Z0-9@_.-]{8,25}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        密码：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxPwd" runat="server" TextMode="Password" Width="250px" 
                            Height="28px" ></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                            ControlToValidate="TextBoxPwd" Display="Dynamic" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                            ControlToValidate="TextBoxPwd" Display="Dynamic" ErrorMessage="要求3到10个字母、数字" 
                            ValidationExpression="[0-9a-zA-Z]{3,10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        确认密码：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxRePwd" runat="server" TextMode="Password" Width="250px" Height="28px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                            ControlToValidate="TextBoxRePwd" Display="Dynamic" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                            ControlToValidate="TextBoxRePwd" Display="Dynamic" ErrorMessage="要求3到10个字母、数字" 
                            ValidationExpression="[0-9a-zA-Z]{3,10}"></asp:RegularExpressionValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                            ControlToCompare="TextBoxPwd" ControlToValidate="TextBoxRePwd" 
                            Display="Dynamic" ErrorMessage="两次输入的密码不同"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        性别：</td>
                    <td class="style2">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="25px" 
                            RepeatDirection="Horizontal" Width="119px">
                            <asp:ListItem Selected="True">男</asp:ListItem>
                            <asp:ListItem>女</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3" align="left">
                         &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
                         &nbsp; &nbsp;&nbsp;（注意：各项需要全部填写）</td>
                </tr>
                <tr>
                    <td colspan="3" align="left">
                    &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp; 
                    &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
                    &nbsp; &nbsp;&nbsp;&nbsp; 
                        <asp:Button ID="ButtonOk" runat="server" 
                            Text="确认注册" Width="91px" Height="38px" onclick="ButtonOk_Click" />
                            </td>
                </tr>
            </table>
            </div>
    </div>
    </form>
</body>
</html>
