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
    public partial class Default2 : System.Web.UI.Page
    {
        userinfo user = new userinfo();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack){
                DataTable table = user.showAssociation();
                DataList1.DataSource = table;
                DataList1.DataBind();
            }
        }
        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName == "apply")
            {
                //Response.Redirect("GoodsDetail.aspx?GoodsID=" + Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex].ToString()));
                //选择的Social值
                //int Soc =  Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex].ToString());
                string Soc = DataList1.DataKeys[e.Item.ItemIndex].ToString();
                Session["AssocSoc"] = Soc;
                //判断是否是社团创建者
                //判断是否已经加入社团 加入不可重复加 member 的值
                if (IsCreate() == true)
                {
                    // 此处需要改写
                    //需要一个待 同意的
                    //改写完成
                    user.signOut2(Session["username"].ToString(), Soc.ToString().Trim());
                    //加入成功
                    Response.Write("<script>alert('申请已发送!');window.history.go(-1)</script>");
                }
                else
                {
                    //不可以加入 JS 弹出框
                    Response.Write("<script>alert('加入失败，您已有社团归属!');window.history.go(-1)</script>");
                }
            }
        }
        //确认 该账户 是否yi you she tuan
        protected bool IsCreate()
        {
            if (user.isManagerOne(Session["username"].ToString()))
            {
                return false;
            }
            else
            {
                int mem = 1000;
                DataTable table = user.showPerson(Session["username"].ToString());
                if (table.Rows.Count > 0)
                {
                    mem = int.Parse(table.Rows[0]["social"].ToString());
                }
                if (mem == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        //创建社团
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsCreate() == true)
            {
                Server.Transfer("EstablishSocial.aspx");
            }
            else
            {
                Response.Write("<script>alert('创建失败，您已有社团归属!');window.history.go(-1)</script>");
            }
        }
        //社团管理
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (user.isManagerOne(Session["username"].ToString()))
            {
                Server.Transfer("ManagerSocial.aspx");

            }
            else
            {
                Response.Write("<script>alert('您不是团长!');window.history.go(-1)</script>");
            }
        }


    }
}
