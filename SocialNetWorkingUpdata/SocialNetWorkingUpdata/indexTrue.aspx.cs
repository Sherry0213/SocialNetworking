using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SocialNetWorkingUpdata.BLL;
namespace SocialNetWorkingUpdata
{
    public partial class indexTrue : System.Web.UI.Page
    {
        userinfo user = new userinfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            showNews();
            //showDataList();
            bang();
        }
          protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
        private void showNews()
        {

            DataTable table = user.showAllNews();
            GridView1.DataSource = table;
            GridView1.DataBind();
        }

        protected int MaxStyle()
        {
            return 1;
        }
        protected void showDataList()
        {
           
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            //页面跳转
            if (e.CommandName == "apply")
            {
                int Soc = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex].ToString());
                //string Soc = DataList1.DataKeys[e.Item.ItemIndex].ToString();
                Session["lyugfjnjdfoh"] = Soc.ToString();
                Server.Transfer("StyleContent.aspx");
                //Response.Write("<script>alert('注册成功!');window.location.href='StyleContent.aspx'</script>");
            }

        }



        static PagedDataSource PDS;
        private void bang()
        {
            DataTable table = user.showAllStyle();
            PDS = new PagedDataSource();

            PDS.DataSource = table.DefaultView;
            PDS.AllowPaging = true;
            PDS.PageSize = 4;
            //Label2.Text = PDS.PageCount.ToString();
            this.DataList1.DataSource = PDS;
            DataList1.DataBind();
        }
        //首页
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            PDS.CurrentPageIndex = 0;
            this.DataList1.DataSource = PDS;
            this.DataList1.DataBind();


        }
        //上一页
        protected void LinkButton2_Click(object sender, EventArgs e)
        {

            PDS.CurrentPageIndex--;
            if (PDS.CurrentPageIndex < 0)
            {
                PDS.CurrentPageIndex = 0;
                this.DataList1.DataSource = PDS;
                this.DataList1.DataBind();
            }
            else
            {
                this.DataList1.DataSource = PDS;
                this.DataList1.DataBind();
            }
        }
        //下一页
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            PDS.CurrentPageIndex++;
            if (PDS.CurrentPageIndex >= PDS.PageCount - 1)
            {
                PDS.CurrentPageIndex = PDS.PageCount - 1;
            }
            this.DataList1.DataSource = PDS;
            this.DataList1.DataBind();
        }
        //尾页
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            PDS.CurrentPageIndex = PDS.PageCount - 1;
            this.DataList1.DataSource = PDS;
            this.DataList1.DataBind();
        }
    }
}
