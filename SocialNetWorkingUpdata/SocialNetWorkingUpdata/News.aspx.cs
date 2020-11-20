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
    public partial class News : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBinding();
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            userinfo user = new userinfo();
            user.deleteNews(GridView1.DataKeys[e.RowIndex].Value.ToString());
            DataBinding();
        }

        private void DataBinding()
        {
            userinfo user = new userinfo();
            DataTable table = user.showNews(Session["userName"].ToString());
            GridView1.DataSource = table;
            GridView1.DataBind();
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Server.Transfer("modifyNews.aspx?mess=0");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("indexTrue.aspx");
        }
 
}
}
