<%@ Page Language="C#" MasterPageFile="~/HomePageOne.master" AutoEventWireup="true" CodeFile="indexFalse.aspx.cs" Inherits="SocialNetWorkingUpdata.indexFalse" Title="悠悠社团网" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    #all
{
	float:left;
	width:900px;
	height:597px;
	background-image:url('images/6666.png');
	margin-top:1px;
	}
#news
{
	float:left;
	width:546px;
	height:240px;
	 background-color:White;
 
  
	}
#news2
{
	float:left;
	width:350px;
	height:240px;
	background-color:white;
	}
	#news3
{
	float:left;
	width:897px;
	height:353px;
	 background-color:#f7ffff;
	}
	#newshead
	{
	    margin-top:4px;
	    font-size: 26pt;
            font-family: 方正舒体;
            font-weight: bold;
            color: #99CCFF;
	}
	#news33
	{
	    margin-top:4px;
	    font-size: 26pt;
            font-family: 方正舒体;
            font-weight: bold;
            color: #99CCFF;
        height: 41px;
    }
     #news333
     {
         height: 302px;
         margin-top:9px;
     }
     #style1
 {
 	font-size:18pt;
 	font-family:方正舒体; text-align:center;
 	
 	}#style4
 {
 	font-size:18pt;
    text-align:center;
 	}#style5
 {
 	font-size:14pt;
     text-align:center;
 	}
 	#changeBU
 	{
 		 text-align:right; margin-top:5px;
 	}
 	
 	
 	/*start top*/
			.top{width:400px;height:30px;margin:0px auto;font-size:30px;font-family:"华文行楷";color:#fff;
			<!--background:-webkit-linear-gradient(45deg,#ff0000,#ffcc00,#ffff99,#33ccff,#00ff33,#6600ff,#333399);
			-webkit-background-clip:text;-->}
			/*end top*/



			/*start box*/
			.box{width:260px;height:210px;margin:auto;perspective:800px;/*景深*/}
			.box .pic{position:relative;transform-style:preserve-3d;/*3d环境*/ animation:play 10s linear infinite;/*动画名称 执行时间 匀速 无限执行*/}
			.box ul li{list-style:none;position:absolute;top:0;left:0;}
			/*start box*/

			/*定义一个关键帧*/
			@keyframes play{
				from{transform:rotateY(0deg);}
				to{transform:rotateY(360deg);}
			}
			/*start text*/
			#text{width:500px;height:20px;color:#6fade1;margin:auto;font-size:24px;font-family:"方正喵呜体";}
			/*end text*/
 </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" Runat="Server">
    <div id="all">
   <div id="news">
       <!--start top-->
		
		<!--end top-->
		<!--start box-->
		<div class="box">
			<div class="pic">
				<ul>
					<li><img src="images2/1.png" width="" height="" alt=""/></li>
					<li><img src="images2/2.png" width="" height="" alt=""/></li>
					<li><img src="images2/3.png" width="" height="" alt=""/></li>
					<li><img src="images2/4.png" width="" height="" alt=""/></li>
					<li><img src="images2/5.png" width="" height="" alt=""/></li>
					<li><img src="images2/6.png" width="" height="" alt=""/></li>
				</ul>
			</div>
		</div>
		<!--end box-->
		<!--start text-->
		<div id="text"></div>
		<!--end text-->
           
           
           
           
           
           
           
           
   </div>
   <div id="news2">
            <div id="newshead">最新消息！</div>
              <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" 
                                DataKeyNames="newsid" PageSize="4" onpageindexchanging="GridView1_PageIndexChanging"
            Width="100%" Font-Size="20px" Height="192px" AllowPaging="True" CellPadding="4" 
                                ForeColor="#333333" GridLines="None" style="margin-left: 0px">
                  <RowStyle BackColor="#f7ffff" />
            <Columns>             
                <asp:HyperLinkField DataTextField="head" HeaderText="" SortExpression="head" 
                DataNavigateUrlFields="newsid"  DataNavigateUrlFormatString="NewsContentFalse.aspx?id={0}"
                />       
                            
            </Columns>
                  <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="#f7ffff" ForeColor= "Blue" HorizontalAlign="Center" />
                  <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                 
                  <EditRowStyle BackColor="#2461BF" />
                  <AlternatingRowStyle BackColor="White" />
           </asp:GridView>
   </div>
   <div id="news3">
        <div id="news33">
            社团活动
        </div>
        <div id="news333">
  
         <asp:DataList ID="DataList1" runat="server" 
         RepeatColumns="6"  RepeatDirection="Horizontal" 
          OnItemCommand = "DataList1_ItemCommand" 
         DataKeyField="styleid" 
         Height="233px" Width="894px" CellPadding="4" 
                ForeColor="#333333" style="margin-top: 10px" >
         
             <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
         
          <ItemTemplate>
            <div id="style1">
               <asp:Image ID="Image1" ImageUrl='<%# Eval("picurl")%>' runat="server" Height="111px" 
              Width="124px" />
              <div id="style4">
          <%# DataBinder.Eval(Container.DataItem,"theme") %>  </div>
          <div id="style5">
          <asp:LinkButton ID="lnkbtnClass" runat="server" CommandName="apply" ForeColor="blue">☛查看☚</asp:LinkButton> 
          </div>
          </div>
          </ItemTemplate>
         
             <AlternatingItemStyle BackColor="White" />
             <ItemStyle BackColor="#EFF3FB" />
             <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
             <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
         
         </asp:DataList>
         <div id="changeBU">
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
                 Font-Size="Medium">首页</asp:LinkButton>&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click"
            Font-Size="Medium">上一页</asp:LinkButton>&nbsp;
            <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click"
            Font-Size="Medium">下一页</asp:LinkButton>&nbsp;
            <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click"
            Font-Size="Medium">尾页</asp:LinkButton>&nbsp;
        </div>
        </div>
   </div>
</div>

<script src="js/jquery.min.js"></script>
		<!--雪花-->
		<script src="js/snow.js"></script>
		<script>
			$(".pic ul li").each(function(i){//遍历
				var deg=360/$(".pic ul li").size();//size个数
				//当前的li对象 添加css样式
				$(this).css({"transform":"rotateY("+deg*i+"deg) translateZ(216px)"});
				
				$.fn.snow({
					minSize:10,
					maxSize:15,
					newOn:500,
					flakeColor:"#ffffff"
				});
			});
			
			var i=0;
			var str="";
			
			window.onload=function typing(){
				//获取div
				var mydiv=document.getElementById("text");
				mydiv.innerHTML+=str.charAt(i);
				i++;
				var id=setTimeout(typing,100);
				if(i==str.length){
					clearTimeout(id);
				}
			}
		</script>

</asp:Content>

