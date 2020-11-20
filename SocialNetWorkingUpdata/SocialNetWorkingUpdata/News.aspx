
<%@ Page Language="C#" MasterPageFile="~/HomePageTwo.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="SocialNetWorkingUpdata.News" Title="悠悠社团网" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type ="text/css">
#all
{
	width:900px;
	height:600px;
	background-image:url(images/6666.png);
	}
#title
{  
	padding-top:20px;
	text-align:center;      
	font-size: 34px;
    color: #66CCFF;
    }
#button
{
	padding-top:20px;
	padding-left:300px;
	}
#content
{
	margin-top:4px;
	}

    .style1
    {
        font-family: 方正舒体;
    }

</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" Runat="Server">
    <div id="all">
    <div id="title" class="style1">新闻发布</div>
    <div id="button">
    <asp:Button ID="Button1" runat="server" Text="返回主页>>" BackColor="AliceBlue" 
            onclick="Button1_Click"/>
    &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="发布新闻>>" BackColor="AliceBlue" 
            onclick="Button2_Click"/>
    </div>
    <div id="content">
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
            CellPadding="4" DataKeyNames="newsid" ForeColor="#333333" GridLines="None"
            Width="61%" Font-Size="20px" onrowdeleting="GridView1_RowDeleting"  
            style="margin-left: 184px" 
            >
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>             
                <asp:BoundField DataField="head" HeaderText="标题" SortExpression="标题"  ItemStyle-HorizontalAlign="NotSet"/>   
                <asp:HyperLinkField DataNavigateUrlFields="newsid" DataNavigateUrlFormatString="modifyNews.aspx?mess=1&newsid={0}" Text="编辑" />   
                <asp:CommandField ShowDeleteButton="True"   />                   
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
    </div>
</div>


</asp:Content>


