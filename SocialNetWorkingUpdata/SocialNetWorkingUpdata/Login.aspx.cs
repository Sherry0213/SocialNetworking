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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                labCode.Text = RandomNum(4);
               
                // Session["userName"] = null;
            }
        }

        public string RandomNum(int n) //
        {
            string strchar = "0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] VcArray = strchar.Split(',');
            string VNum = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 1; i < n + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(61);
                if (temp != -1 && temp == t)
                {
                    return RandomNum(n);
                }
                temp = t;
                VNum += VcArray[t];
            }
            return VNum;
        }
        //看不清
        protected void ButtonLook_Click(object sender, EventArgs e)
        {
            labCode.Text = RandomNum(4);
            txtAdminCode.Text = "";
        }
        //注册按钮
        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            Server.Transfer("Register.aspx");
        }
        //登录按钮
        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (this.username.Text.Trim() == "" || this.password.Text.Trim() == "")
            {
                Response.Write("<script>alert('用户名和密码不能为空!');window.history.go(-1)</script>");
                return;
            }
            if (txtAdminCode.Text != labCode.Text)
            {
                Response.Write("<script>alert('验证码不匹配,请重新填写!');window.history.go(-1)</script>");
                txtAdminCode.Text = "";
                return;
            }
            userinfo user = new userinfo();
            if (user.validUser(this.username.Text.Trim().ToString(), this.password.Text.Trim().ToString()))
            {
                Session["userName"] = this.username.Text.Trim().ToString();
                if (CheckBox1.Checked)    //是否记住用户名
                {
                    Response.Cookies["username"].Value = username.Text;
                    Response.Cookies["username"].Expires = DateTime.Now.AddDays(1);
                }
                this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登录成功!');</script>");
                Server.Transfer("index.aspx");          
            }
            else
            {
                Session["userName"] = "";
                this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('登录失败,无此用户名或密码不正确!');window.history.go(-1)</script>");       
            }      
        }

    }
}
