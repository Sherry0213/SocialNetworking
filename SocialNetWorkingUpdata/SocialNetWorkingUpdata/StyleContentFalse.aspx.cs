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
    public partial class StyleContentFalse : System.Web.UI.Page
    {
        userinfo user = new userinfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable table = user.styleContent(Session["lyugfjnjdfoh"].ToString());
            if (table.Rows.Count> 0)
            {
                this.Label1.Text = table.Rows[0]["theme"].ToString();
                LabelSocial.Text = table.Rows[0]["socname"].ToString();
                Image1.ImageUrl = table.Rows[0]["picurl"].ToString();
                this.Label2.Text = " " + table.Rows[0]["timeplace"].ToString();
                this.Label3.Text = " " + table.Rows[0]["participants"].ToString();
                TextBoxSk.Text = "    " + table.Rows[0]["con"].ToString();
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("indexFalse.aspx");
        }
    }
}
