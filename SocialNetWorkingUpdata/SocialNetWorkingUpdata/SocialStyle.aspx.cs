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
    public partial class SocialStyle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            userinfo user = new userinfo();
            DataTable table = user.SocialStyle(Session["username"].ToString());
            DataList1.DataSource = table;
            DataList1.DataBind();
        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "apply")
            {
                int Soc = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex].ToString());
                Session["AssocSoc"] = Soc;
                userinfo user = new userinfo();
                user.SocialSDelete(Session["AssocSoc"].ToString());
                //删除成功
                Response.Write("<script>alert('删除成功!');window.location.href='SocialStyle.aspx'</script>");
            }
        }
        //添加活动
        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("modifyStyle.aspx");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("indexTrue.aspx");
        }
    }
}
