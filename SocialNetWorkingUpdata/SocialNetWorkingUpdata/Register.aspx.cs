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
using System.Data.SqlClient;
using SocialNetWorkingUpdata.BLL;
namespace SocialNetWorkingUpdata
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonOk_Click(object sender, EventArgs e)
        {
            userinfo user = new userinfo();
            if (user.InserUser(TextBoxName.Text.Trim(), TextBoxPwd.Text.Trim(), RadioButtonList1.SelectedItem.Text, TextBoxPhone.Text.Trim(), TextBoxmail.Text.Trim()))
            {
                //this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册成功!');</script>");
                Session["userName"] = TextBoxName.Text.Trim();
                Response.Write("<script>alert('注册成功!');window.location.href='indexTrue.aspx'</script>");
            }
            else
            {
                Session["userName"] = "";
                this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('注册失败,已有该用户名!');</script>");
            }
        }
    }
}
