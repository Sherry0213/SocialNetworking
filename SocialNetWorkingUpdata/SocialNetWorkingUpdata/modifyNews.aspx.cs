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
    public partial class modifyNews : System.Web.UI.Page
    {
        private string message;
        protected void Page_Load(object sender, EventArgs e)
        {
            message = Request.QueryString["mess"];
            Session["newsidqwer"] = Request.QueryString["newsid"];
            if (!IsPostBack)
            {
                TextBoxInit();
            }
        }
        protected void TextBoxInit()
        {
            userinfo user = new userinfo();
            switch (message)
            {
                case "0":   //发布新闻
                    {
                        Label1.Text = "发布新闻";
                        break;
                    }
                case "1":  //修改新闻
                    {
                        Label1.Text = "修改新闻";
                        DataTable table = user.showNewsPer(Session["newsidqwer"].ToString());
                        if (table.Rows.Count > 0)
                        {
                            TextBox1.Text = table.Rows[0]["head"].ToString();
                            TextBox2.Text = "    " + table.Rows[0]["con"].ToString();   
                        }
                        else
                        {
                            this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('无此记录！');</script>");
                        }
                        break;
                    }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            userinfo user = new userinfo();
            if (message == "0")   //发布新闻
            {
                if (user.InsertNews(this.TextBox1.Text.Trim(), this.TextBox2.Text.Trim(), Session["userName"].ToString())==100)
                {
                    this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('库中已经有要发布的标题，无法重复发布！');</script>");
                    return;
                }
                else
                {
                    Server.Transfer("News.aspx");
                }
            }
            else if (message == "1")  //修改新闻
            {
                user.modifyNews(this.TextBox1.Text.Trim(), this.TextBox2.Text.Trim(), Session["newsidqwer"].ToString());
                Server.Transfer("News.aspx");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("News.aspx");
        }
    }
}
