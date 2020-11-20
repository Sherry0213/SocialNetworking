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
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using SocialNetWorkingUpdata.BLL;
namespace SocialNetWorkingUpdata
{
    public partial class modifyStyle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowPersonSocial();
            }
        }
        // 显示社团信息
        protected void ShowPersonSocial()
        {
            string socialID = null;
            userinfo user = new userinfo();
            DataTable table = user.showPerson(Session["username"].ToString());
            if (table.Rows.Count > 0)
            {
                //Session["zxcvbnm"] = table.Rows[0]["social"].ToString();
                socialID = table.Rows[0]["social"].ToString();
            }
            DataTable table2 = user.showPersonSocial(socialID);
            if (table2.Rows.Count > 0)
            {
                LabelSocial.Text = table2.Rows[0]["socname"].ToString();
                Session["hdfkiuyr"] = table2.Rows[0]["socname"].ToString();
            }
            else
            {
                LabelSocial.Text = "无";
            }
        }
        //显示图片
        protected void Button1_Click(object sender, EventArgs e)
        {
            Boolean fileOk = false;
            if (FileUpload1.HasFile)//验证是否包含文件
            {
                //取得文件的扩展名,并转换成小写
                string fileExtension = Path.GetExtension(FileUpload1.FileName).ToLower();
                //验证上传文件是否图片格式
                fileOk = IsImage(fileExtension);
                if (fileOk)
                {
                    //对上传文件的大小进行检测，限定文件最大不超过8M
                    if (FileUpload1.PostedFile.ContentLength < 8192000)
                    {
                        string filepath = "./picsoc/";
                        if (Directory.Exists(Server.MapPath(filepath)) == false)//如果不存在就创建file文件夹
                        {
                            Directory.CreateDirectory(Server.MapPath(filepath));
                        }
                        string virpath = filepath + CreatePasswordHash(FileUpload1.FileName, 4) + fileExtension;//这是存到服务器上的虚拟路径
                        string mappath = Server.MapPath(virpath);//转换成服务器上的物理路径
                        FileUpload1.PostedFile.SaveAs(mappath);//保存图片
                        //显示图片
                        Image1.ImageUrl = virpath;
                        Session["pictureStyleURL"] = virpath.ToString();
                    }
                }
            }
        }
        //创建活动
        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            string SocName = TextBoxName.Text;//主题
            string SocSize = TextBoxSize.Text;//时间地点
            string Sk = TextBoxSk.Text;// 内容
            string participants = TextBox1.Text;//参与人员
            string[] array = { SocName, SocSize, Sk, participants, Session["pictureStyleURL"].ToString() ,Session["username"].ToString() ,Session["hdfkiuyr"].ToString()};
            userinfo user = new userinfo();
            if (!(user.InsertStyleSoc(array)))
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('失败,已有该活动！');</script>");
            }
            else
            {
                this.ClientScript.RegisterStartupScript(this.GetType(), "", "<script>alert('创建成功！');window.location.href='SocialStyle.aspx'</script>");
                //Response.Write("<script>alert('创建成功!');window.location.href='indexTrue.aspx'</script>");
            }
        }
        public bool IsImage(string str)
        {
            bool isimage = false;
            string thestr = str.ToLower();
            //限定只能上传jpg和gif图片
            string[] allowExtension = { ".jpg", ".gif", ".bmp", ".png" };
            //对上传的文件的类型进行一个个匹对
            for (int i = 0; i < allowExtension.Length; i++)
            {
                if (thestr == allowExtension[i])
                {
                    isimage = true;
                    break;
                }
            }
            return isimage;
        }
        /// 创建一个指定长度的随机salt值
        public string CreateSalt(int saltLenght)
        {
            //生成一个加密的随机数
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[saltLenght];
            rng.GetBytes(buff);
            //返回一个Base64随机数的字符串
            return Convert.ToBase64String(buff);
        }

        /// 返回加密后的字符串
        public string CreatePasswordHash(string pwd, int saltLenght)
        {
            string strSalt = CreateSalt(saltLenght);
            //把密码和Salt连起来
            string saltAndPwd = String.Concat(pwd, strSalt);
            //对密码进行哈希
            string hashenPwd = FormsAuthentication.HashPasswordForStoringInConfigFile(saltAndPwd, "sha1");
            //转为小写字符并截取前16个字符串
            hashenPwd = hashenPwd.ToLower().Substring(0, 16);
            //返回哈希后的值
            return hashenPwd;
        }


        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("SocialStyle.aspx");
        }
    }
}
