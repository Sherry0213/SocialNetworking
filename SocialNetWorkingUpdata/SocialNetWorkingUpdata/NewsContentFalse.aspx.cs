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
    public partial class NewsContentFalse : System.Web.UI.Page
    {
        userinfo user = new userinfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["jgmndnewsid"] = Request.QueryString["id"];
            DataTable table = user.showNewsPer(Session["jgmndnewsid"].ToString());
            if (table.Rows.Count>0)
            {
                this.Label1.Text = table.Rows[0]["head"].ToString();
                this.Label3.Text = " " + table.Rows[0]["author"].ToString();
                TextBox2.Text = "    " + table.Rows[0]["con"].ToString();
            }
        }
    }
}
