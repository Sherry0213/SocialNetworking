<%@ Page Language="C#" MasterPageFile="~/HomePageTwo.master" AutoEventWireup="true" CodeFile="ManagerSocial.aspx.cs" Inherits="SocialNetWorkingUpdata.ManagerSocial" Title="悠悠社团网" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
 <style type="text/css">
    #all
    {
    	width:900px;
    	height:600px;
    	background-image:url(images/6666.png);
    	}
    #title
    {
    	text-align:center;
    	}
    #update
    {
    	padding-left:275px;
    	padding-top:20px;
    	}
    #set
    {
    	padding-left:275px;
    	padding-top:20px;
    	}
    #intro
    {
    	padding-left:275px;
    	padding-top:20px;
    	}
    	 #intro2
    {
    	padding-left:275px;
    	padding-top:20px;
    	}
    	#socialYes
    	{
    		
    	padding-top:20px;
    	}
    	 #intro3
    {
    	padding-left:275px;
    	padding-top:20px;
    	}
    .box
    {
    	padding-left:0px;
    	padding-top:15px;
    	}
    #button
    {
    	text-align:center;
    	padding-top:15px;
    	}
    .style1
    {
        font-size:37pt;
        font-family: 方正舒体;
        color: #3399FF;
    }
        .style2
        {
            font-family: 黑体;
            font-size: 13pt;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" Runat="Server">
<div id="all">
    <div id="title" class="style1">社团管理</div>
    <div id="update">
    <span class="style2">社团名&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></span>
    </div>
    <div id="set">
    <span class="style2">设置管理员 &nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" BorderWidth="1px" Width="190px" Height="25px">
        </asp:DropDownList>
    </span></div>
    <div id="intro3">
        <span class="style2">管理员&nbsp;&nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </span></div>
    <div id="intro2">
        <div class ="style2">社团规模
        
            <asp:TextBox ID="TextBox3" runat="server" Width="62px"></asp:TextBox>&nbsp;人</div>
    </div>
    <div id="socialYes">
    
   <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False"
            CellPadding="4" DataKeyNames="ID" ForeColor="#333333" GridLines="None"
            Width="40%" Font-Size="20px" onrowdeleting="GridView1_RowDeleting"   OnRowEditing="GridView1_RowEditing" 
            
            style="margin-left: 275px" 
            >
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#EFF3FB" />
            <Columns>             
                <asp:BoundField DataField="ID" HeaderText="申请加入" SortExpression="申请加入"  ItemStyle-HorizontalAlign="NotSet"/>   
                <asp:CommandField ShowDeleteButton="True"     DeleteText="同意" 
                    ButtonType="Button" />  
               
                        
                <asp:CommandField ButtonType="Button"  ShowEditButton="True" EditText="不同意" 
                    />
               
                        
            </Columns>
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
   
    
    
    
    
    
    
    
    
    
    
    </div>
    <div id="intro">
       <div class ="style2">社团简述</div>
       <div class="box">
       <asp:TextBox ID="TextBox2" runat="server" BorderWidth="1px" Width="320px"
               Height="188px"></asp:TextBox>
       </div>
    </div>
    <div id="button">
    <asp:Button ID="Button1" runat="server" Text="确认修改" Height="33px" Width="77px" 
    BorderWidth="1px" BackColor=AliceBlue Font-Size=Medium onclick="Button1_Click" />
    </div>
    
</div>
</asp:Content>

