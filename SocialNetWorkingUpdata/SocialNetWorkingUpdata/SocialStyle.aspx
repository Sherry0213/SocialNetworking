<%@ Page Language="C#" MasterPageFile="~/HomePageTwo.master" AutoEventWireup="true" CodeFile="SocialStyle.aspx.cs" Inherits="SocialNetWorkingUpdata.SocialStyle" Title="悠悠社团网" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
 #maincontent
 {
 	width:900px; height:797px; background-image:url(images/6666.png);
 }
 #first
 {
 	width:899px; height:50px;  text-align:center; margin-top:3px;padding-top:20px;
 }
 #second
 {
 	float:left;width:899px; height:800px;
 }
  .style1
 {
 	font-size:18pt;
 	font-family:方正舒体;
 	}
 .style4
 {
 	font-size:11pt;
    font-family:@楷体;
 	}
 	.style111
    {
        font-family: 方正舒体;
    }
    #title
{  
	padding-top:20px;
	text-align:center;      
	font-size: 34px;
    color: #66CCFF;
    }
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" Runat="Server">
    <div id="maincontent">
    <div id="title" class="style111">社团活动</div>
    <div id="first">
        <asp:Button ID="Button1" runat="server" Text="<<返回首页"  BackColor="AliceBlue"
             
            onclick="Button1_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="添加活动>>"  BackColor="AliceBlue"
           onclick="Button2_Click" />
     </div>
     <div id="second">
         <asp:DataList ID="DataList1" runat="server"
         RepeatColumns="4"  RepeatDirection="Horizontal" 
         DataKeyField="styleid" CellPadding="4" 
             CellSpacing="6" Height="369px" Width="661px" 
               OnItemCommand = "DataList1_ItemCommand" style="margin-left: 129px" 
             BackColor="#F7FFFF" BorderColor="White" BorderStyle="Double" BorderWidth="0px" 
             Font-Bold="False" Font-Italic="False" Font-Overline="False" 
             Font-Strikeout="False" Font-Underline="False" 
             >
             <FooterStyle BackColor="White" ForeColor="#333333" />
             <ItemStyle BackColor="White" ForeColor="#333333" />
             <SelectedItemStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
         <ItemTemplate>
            <table style="height: 180px; width: 147px;">
                <tr>
                    <td colspan="2" align="center"> 
                     <asp:Image ID="Image1" ImageUrl='<%# Eval("picurl")%>' runat="server" Height="111px" 
              Width="124px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="style1" align="center"> <%# DataBinder.Eval(Container.DataItem,"theme") %>  </td>
                </tr>
                <tr>   
                    <td colspan="2" align="center" class="style4">
                        <asp:LinkButton ID="lnkbtnClass" runat="server" CommandName="apply" ForeColor="blue">☛删除☚</asp:LinkButton>                 
                    </td>                     
            </tr>
            </table>
         </ItemTemplate>
         </asp:DataList>
     </div>


</div>   

</asp:Content>

