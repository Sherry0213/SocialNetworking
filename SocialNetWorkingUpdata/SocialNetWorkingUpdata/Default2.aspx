<%@ Page Language="C#" MasterPageFile="~/HomePageTwo.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="SocialNetWorkingUpdata.Default2" Title="悠悠社团网" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    #maincontent
 {
 	width:900px; height:670px; background-image:url(images/6666.png);
 }
 #first
 {
 	width:899px; height:50px;  text-align:center; margin-top:3px;padding-top:20px;
 }
 #second
 {
 	float:left;width:899px; height:522px;
 }
  .style1
 {
 	font-size:18pt;
 	font-family:方正舒体;
 	}
 .style2
 {
 	font-size:10pt;
 	font-family:@黑体;
 	}
 	
 .style3
 {
    font-size:9pt;
 	}
 .style4
 {
 	font-size:11pt;
    font-family:@楷体;
 	}
 	  #title
{  
	padding-top:20px;
	text-align:center;      
	font-size: 34px;
    color: #66CCFF;
    }.style111
    {
        font-family: 方正舒体;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" Runat="Server">
    <div id="maincontent">
     <div id="title" class="style111">申请社团</div>
    <div id="first">
        <asp:Button ID="Button1" runat="server" Text="创建社团>>" 
           BackColor="AliceBlue"
            onclick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="社团管理>>" BackColor="AliceBlue"
         onclick="Button2_Click" />
     </div>
     <div id="second">
         <asp:DataList ID="DataList1" runat="server"
         RepeatColumns="5"  RepeatDirection="Horizontal" 
         DataKeyField="social" 
         BackColor="#F7FFFF"  BorderColor="#F7FFFF" BorderStyle="Double" 
             BorderWidth="0px" CellPadding="4" GridLines="Horizontal" Height="520px" Width="899px" 
               OnItemCommand = "DataList1_ItemCommand" Font-Bold="False" 
             Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False"
             >
             <FooterStyle BackColor="White" ForeColor="#333333" />
             <ItemStyle BackColor="White" ForeColor="#333333" />
             <SelectedItemStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
         <ItemTemplate>
            <table style="height: 180px; width: 147px;">
                <tr>
                    <td colspan="2" align="center"> 
                     <asp:Image ID="Image1" ImageUrl='<%# Eval("pic")%>' runat="server" Height="111px" 
              Width="124px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="style1" align="center"> <%# DataBinder.Eval(Container.DataItem,"socname") %>  </td>
                </tr>
                <tr>
                    <td  align="center"  class="style2">社团团长：</td>
                    <td align="left"><%# Eval("joker")%></td>
                </tr>
                <tr>
                    <td  align="center" class="style2">社团规模：</td>
                    <td align="left"><%# Eval("size")%>人</td>
                </tr>
                <tr>
                    <td  align="center" class="style2">社团简述：</td>
                    
                </tr>
                <tr>
                    <td  colspan="2" class="style3">&nbsp;&nbsp;<%# Eval("sketch")%></td>
                </tr>
                <tr>   
                    <td colspan="2" align="center" class="style4">
                        <asp:LinkButton ID="lnkbtnClass" runat="server" CommandName="apply" ForeColor="blue">☛加入社团☚</asp:LinkButton>                 
                    </td>                     
            </tr>
            </table>
         </ItemTemplate>
         </asp:DataList>
     </div>


</div>
</asp:Content>

