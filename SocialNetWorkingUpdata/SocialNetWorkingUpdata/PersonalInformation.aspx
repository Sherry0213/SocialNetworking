
<%@ Page Language="C#" MasterPageFile="~/HomePageTwo.master" AutoEventWireup="true" CodeFile="PersonalInformation.aspx.cs" Inherits="SocialNetWorkingUpdata.PersonalInformation" Title="悠悠社团网" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
 #content
 {
 	padding-left:100px;
 	width:1000px;
    height: 800px;
    background-image:url(images/PersonBG.png);     
    } 
 .style1
 {
 	font-size: 14px;
    font-family: 宋体;
 	}  
 .style2
 {
 	}
        .style3
        {
            font-size: medium;
            font-family: 微软雅黑;
        }   
         .style36
        {
            font-size: medium;
            font-family: 微软雅黑;
             text-align:center;
        }     
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" Runat="Server">
 <div id="content" style="text-align:center">
<table style="width:460px; line-height:45px; height: 370px; margin-left:140px;padding-top:90px;">
                <tr>
                <td colspan="2" align="left">
                <div class="style3">基本信息</div></td>
                </tr>
                <tr>
                   <td class="style1">
                    用户ID：</td>
                   <td class="style2">
                   <asp:Label ID="LabelName" runat="server" Text="Label"></asp:Label>
                   </td>
                </tr>
                <tr>
                    <td class="style1">
                    性别：</td>
                    <td class="style2">
                    <asp:Label ID="LabelSex" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
                <tr>
                     <td class="style1">
                    社团：</td>
                    <td class="style2">
                        <asp:Label ID="LabelSocial" runat="server" Text="Label"></asp:Label>
                </tr>
                <tr>
                    <td colspan="2" class="style6">
                        <div class="style36">
                            <asp:Label ID="IsYN" runat="server" Text=" "></asp:Label>
                        </div>
                    </td>
                </tr>
                <tr>
                <td colspan="2" align="left" class="style6">
                <div class="style36">
                    <asp:Button ID="ButtonSignOut" runat="server" Text="退出该社团" 
                        onclick="ButtonSignOut_Click" /></div></td>
                </tr>
                <tr>
                <td colspan="2" align="left" class="style6">
                <div class="style3">修改联系方式</div></td>
                </tr>
                <tr>
                    <td class="style1">
                        手机号：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxphone" runat="server" BorderWidth="1px" Width="250px" Height="28px"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td class="style1">
                        E-mail：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxmail" runat="server" BorderWidth="1px" Width="250px" Height="28px"></asp:TextBox>
                    </td>

                </tr>
                <tr>
                    <td colspan="2" align="left">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" BackColor=AliceBlue Font-size=Medium 
                    Text="保存修改"  Width="99px" Height="30px" onclick="Button1_Click" />
                    </td>
                </tr>
                
                <tr>
                <td colspan="2" align="left">
                <div class="style3">修改密码</div></td>
                </tr>
                
                <tr>
                    <td class="style1">
                        旧密码：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxPwd" runat="server" BorderWidth="1px" TextMode="Password" Width="250px" 
                            Height="28px" style="margin-left: 0px" Text=""></asp:TextBox>
                    </td>
                    <td>
                         <!--
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate="TextBoxPwd" Display="Dynamic"  
                        ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                        -->
                    </td>
                </tr>
                <tr>
                    <td class="style1">
                        新密码：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxRePwd" runat="server" BorderWidth="1px" TextMode="Password" Width="250px" Height="28px"></asp:TextBox>
                    </td>

                </tr>

                <tr>
                    <td class="style1">
                        新密码确认：</td>
                    <td class="style2">
                        <asp:TextBox ID="TextBoxRePwd2" runat="server" BorderWidth="1px" TextMode="Password" Width="250px" Height="28px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="TextBoxRePwd" ControlToValidate="TextBoxRePwd2" 
                            Display="Dynamic" ErrorMessage="两次密码不同"
                        ></asp:CompareValidator>
                        
                    </td>
                </tr>

                <tr>
                    <td colspan="2" align="left">
                     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                     <asp:Button ID="ButtonOk" runat="server" BackColor=AliceBlue Font-size=Medium 
                     Text="保存密码" Width="99px" Height="30px" onclick="ButtonOk_Click" />
                     </td>
                </tr>
            </table>
</div>



</asp:Content>

