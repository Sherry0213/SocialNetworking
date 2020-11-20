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
    public partial class PersonalInformation : System.Web.UI.Page
    {
        string social = null,header=null;
        protected void Page_Load(object sender, EventArgs e)
        {
            // ShowPerson();
            // ShowPersonSocial();
            if (!Page.IsPostBack)
            {
                ShowPerson();
                ShowPersonSocial();
            }
        }
        //保存密码
        protected void ButtonOk_Click(object sender, EventArgs e)
        {
            userinfo user = new userinfo();
            if (!(user.savePwd(Session["username"].ToString(), TextBoxPwd.Text, TextBoxRePwd2.Text.Trim())))
            {
                Response.Write("<script>alert('原密码错误!');window.history.go(-1)</script>");
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改密码成功！');window.location.href='indexTrue.aspx'</script>");
            }

        }
        //修改 手机号 邮箱
        protected void Button1_Click(object sender, EventArgs e)
        {
            userinfo user = new userinfo();
            user.saveInfor(Session["username"].ToString(), TextBoxphone.Text.Trim(), TextBoxmail.Text.Trim());
            this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('修改成功！');window.location.href='indexTrue.aspx'</script>");
            //Response.Write("<script>alert('修改成功!');)</script>");
        }
        // 显示 个人信息
        protected void ShowPerson()
        {
            userinfo user = new userinfo();
            DataTable table = user.showPerson(Session["username"].ToString());
            if (table.Rows.Count>0)
            {
                LabelName.Text = table.Rows[0]["id"].ToString();
                LabelSex.Text = table.Rows[0]["sex"].ToString();
                TextBoxphone.Text = table.Rows[0]["pnumber"].ToString();
                TextBoxmail.Text = table.Rows[0]["email"].ToString();
                social = table.Rows[0]["social"].ToString();
                header = table.Rows[0]["header"].ToString();
            }
        }
        // 显示社团信息
        protected void ShowPersonSocial()
        {
            userinfo user = new userinfo();
            DataTable table = user.showPersonSocial(social);
            if (table.Rows.Count>0)
            {
                LabelSocial.Text = table.Rows[0]["socname"].ToString();
            }
            else
            {
                LabelSocial.Text = "无";
                if (!(header.Equals("0")))
                {
                    DataTable table2 = user.showPersonSocial(header);
                    IsYN.Text = table2.Rows[0]["socname"].ToString() + "已拒绝您的申请";
                    user.InSocialYesNo("0", Session["username"].ToString(), 0);
                }

            }
            
        }
        //退出该社团
        protected void ButtonSignOut_Click(object sender, EventArgs e)
        {
            userinfo user = new userinfo();
            string strsoc = LabelSocial.Text;
            if (strsoc == "无")
            {
                Response.Write("<script>alert('您还未加入社团!');window.history.go(-1)</script>");
                return;
            }
            if (user.isManagerOne(Session["username"].ToString()))
            {
                Response.Write("<script>alert('您是团长不能退出!');window.history.go(-1)</script>");
                return;
            }
            else
            {
                user.signOut(Session["username"].ToString(),"0");
                Response.Write("<script>alert('退出成功!');window.location.href='PersonalInformation.aspx'</script>");
            }
        }
        
    }
}
