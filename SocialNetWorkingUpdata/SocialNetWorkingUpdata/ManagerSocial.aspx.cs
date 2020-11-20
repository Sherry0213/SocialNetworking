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
    public partial class ManagerSocial : System.Web.UI.Page
    {
        userinfo user = new userinfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["username"] = "123";
            if (!IsPostBack)
            {
                //Session["userName"] = "aeneag";
                ShowSocial();
                GetDataDropDownList();
                showGridview();
               
            }
        }
        //gridview 显示
        public void showGridview()
        {
            DataTable table = user.InSocial(Session["socialNumber"].ToString());
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
        //获取 下拉框 数据
        protected void GetDataDropDownList()
        {
            DataTable table = user.userSocial(Session["socialNumber"].ToString());
            DropDownList1.DataSource = table.DefaultView;
            DropDownList1.DataTextField = "ID";
            DropDownList1.DataValueField = "value";
            DropDownList1.DataBind();
            ListItem li = new ListItem("--请选择--", "0");
           // DataTable table0 = user.showPerson(Session["managerSocial"].ToString());
           // int val = int.Parse(table.Rows[0]["value"].ToString());
            DropDownList1.Items.Insert(0, li);
        }
        // 显示 社团信息
        protected void ShowSocial()
        {
            DataTable table = user.SocialInfor(Session["username"].ToString());
            if (table.Rows.Count>0)
            {
                Label2.Text = table.Rows[0]["socname"].ToString();
                TextBox3.Text = table.Rows[0]["size"].ToString();
                TextBox2.Text = table.Rows[0]["sketch"].ToString();
                Label1.Text = table.Rows[0]["manager"].ToString();

                Session["socialNumber"] = table.Rows[0]["social"].ToString();
                Session["SocialNameQ"] = table.Rows[0]["socname"].ToString();
                Session["managerSocial"] = table.Rows[0]["manager"].ToString();
            }
        }
        //确认修改
        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] str = { TextBox3.Text.ToString().Trim(), TextBox2.Text.ToString().Trim(), DropList(), Session["username"].ToString() };
            user.modifSoialInfor(str);
            Response.Write("<script>alert('修改成功!');window.location.href='Default2.aspx'</script>");
        }
        protected string DropList()
        {
            if (DropDownList1.SelectedItem.Text.ToString().Equals("--请选择--"))
            {
                return " ";
            }
            else
            {
                return DropDownList1.SelectedItem.Text.ToString();
            }
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            user.InSocialYesNo(Session["socialNumber"].ToString(), GridView1.DataKeys[e.RowIndex].Value.ToString(),1);
            showGridview();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            user.InSocialYesNo(Session["socialNumber"].ToString(), GridView1.DataKeys[e.NewEditIndex].Value.ToString(), 0);
            showGridview();
        }

 
}
}
