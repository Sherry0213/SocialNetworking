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
    public partial class HomePageTwo : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Redirect("indexFalse.aspx");
            }
            else
            {
                LabelName.Text = Session["userName"].ToString();
            }
        }
        protected void SignoutButton_Click(object sender, EventArgs e)
        {
            Session["userName"] = null;
            Server.Transfer("indexFalse.aspx");
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
        //新闻发布
        protected void NewsButton_Click(object sender, EventArgs e)
        {
            if (Session["userName"] == null)
            {
                Response.Write("<script>alert('请先登录!');window.location.href='Login.aspx'</script>");
            }
            else
            {
                //Response.Write("<script>alert('社团风采!!');window.location.href='indexTrue.aspx'</script>");
                //Server.Transfer("SocialStyle.aspx");
                if (IsManagerOne() || IsManagerTwo())
                {
                    Server.Transfer("News.aspx");
                }
                else
                {
                    Response.Write("<script>alert('您不是社团管理人员!');window.history.go(-1)</script>");
                }
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
                //Response.Write("<script>alert('社团风采!!');window.location.href='indexTrue.aspx'</script>");
                //Server.Transfer("SocialStyle.aspx");
                if (IsManagerOne() || IsManagerTwo())
                {
                    Server.Transfer("SocialStyle.aspx");
                }
                else
                {
                    Response.Write("<script>alert('您不是社团管理人员!');window.history.go(-1)</script>");
                }
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
                Server.Transfer("Default2.aspx");
            }
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

        protected bool IsManagerOne()
        {
            userinfo user = new userinfo();
            return user.isManagerOne(Session["username"].ToString());
        }
        protected bool IsManagerTwo()
        {
            userinfo user = new userinfo();
            return user.isManagerTwo(Session["username"].ToString());
        }
    }
}
