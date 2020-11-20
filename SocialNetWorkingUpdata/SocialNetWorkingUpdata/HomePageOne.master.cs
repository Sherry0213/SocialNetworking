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

namespace SocialNetWorkingUpdata
{
    public partial class HomePageOne : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("Login.aspx");
        }
        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            Server.Transfer("Register.aspx");
        }
        //个人信息
        protected void PersonButton_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Write("<script>alert('请先登录!');window.location.href='Login.aspx'</script>");
            }
            else
            {
                Server.Transfer("PersonalInformation.aspx");
            }
        }
        //新闻发布
        protected void NewsButton_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Write("<script>alert('请先登录!');window.location.href='Login.aspx'</script>");
            }
            else
            {
                Server.Transfer("PersonalInformation.aspx");
            }
        }
        //社团风采
        protected void StyleButton_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Write("<script>alert('请先登录!');window.location.href='Login.aspx'</script>");
            }
            else
            {
                Server.Transfer("PersonalInformation.aspx");
            }
        }
        //申请社团
        protected void ApplyButton_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Write("<script>alert('请先登录!');window.location.href='Login.aspx'</script>");
            }
            else
            {
                Server.Transfer("PersonalInformation.aspx");
            }
        }
        //首页
        protected void FirstButton_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Server.Transfer("indexFalse.aspx");
            }
            else
            {
                Server.Transfer("indexTrue.aspx");
            }
        }
    }
}
