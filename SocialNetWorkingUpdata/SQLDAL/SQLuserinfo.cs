using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SocialNetWorkingUpdata.DBUtility;
using System.Data;
using System.Data.SqlClient;
namespace SocialNetWorkingUpdata.SQLDAL
{
    public class userinfo : SocialNetWorkingUpdata.IDAL.Iuserinfo
    {
        public DataTable styleContent(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from stylesocial where styleid=@id ");
            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"id",id)
                                  };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            return table;
        }
        public DataTable showAllStyle()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from stylesocial order by styleid desc");
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString());
            return table;
        }
        public DataTable showAllNews()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from news order by newsid desc");
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString());
            return table;
        }
        public void InSocialYesNo(string social,string id,int yn)
        {
            if (yn == 1)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("update userlogin set member=@num,social=@soc where id=@id");
                SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@num",SqlDbType.Int,30,"username",0),
                                        SQLDbHelper.GetParameter("@soc",SqlDbType.NVarChar,30,"rrrr",social)  ,
                                        SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"rffrr",id)  
                                    };
                SQLDbHelper.ExecuteSql(sb.ToString(), param);
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("update userlogin set member=@num,header=@soc where id=@id");
                SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@num",SqlDbType.Int,30,"username",0),
                                        SQLDbHelper.GetParameter("@soc",SqlDbType.NVarChar,30,"rrrr",social)  ,
                                        SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"rffrr",id)  
                                    };
                SQLDbHelper.ExecuteSql(sb.ToString(), param);
            }
        }
        public DataTable InSocial(string social)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from userlogin where member = @mem ");
            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@mem",SqlDbType.NVarChar,30,"id",social)
                                  };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            return table;
        }
        public void modifSoialInfor(string[] array){
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("update association set size=@siz,sketch=@sk,manager=@man where joker=@username");

            SqlParameter[] param2 ={
                                      SQLDbHelper.GetParameter("@siz",SqlDbType.NVarChar,30,"username",array[0]),
                                      SQLDbHelper.GetParameter("@sk",SqlDbType.NVarChar,30,"usernamef",array[1]),
                                      SQLDbHelper.GetParameter("@man",SqlDbType.NVarChar,30,"username1",array[2]),
                                      SQLDbHelper.GetParameter("@username",SqlDbType.NVarChar,30,"username2",array[3])
                                  };
            SQLDbHelper.ExecuteSql(sb2.ToString(), param2);
        }
        public DataTable userSocial(string social)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from userlogin where social = @mem ");
            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@mem",SqlDbType.NVarChar,30,"id",social)
                                  };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            return table;
        }
        public bool InsertSocial(string[] array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM association  WHERE socname =@name ");

            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@name",SqlDbType.NVarChar,30,"username",array[0])                     
                                  };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                InsertSocial2(array);
                StringBuilder sb2 = new StringBuilder();
                sb2.Append("SELECT * FROM association  WHERE socname =@name ");

                SqlParameter[] param2 ={
                                      SQLDbHelper.GetParameter("@name",SqlDbType.NVarChar,30,"username",array[0])                     
                                  };
                DataTable table2 = SQLDbHelper.ExecuteDt(sb.ToString(), param2);
                string assocID = "0";
                if (table2.Rows.Count > 0) {assocID = table2.Rows[0]["social"].ToString(); }
                signOut(array[1], assocID);
                return true;
            }
        }
        public void InsertSocial2(string[] array)
        {
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("INSERT INTO association (socname, joker, sketch, size,pic) VALUES (@name,@joker,@sk,@si,@picurl)");

            SqlParameter[] param2 ={
                                      SQLDbHelper.GetParameter("@name",SqlDbType.NVarChar,30,"username",array[0]),
                                      SQLDbHelper.GetParameter("@joker",SqlDbType.NVarChar,30,"usernamef",array[1]),
                                      SQLDbHelper.GetParameter("@sk",SqlDbType.NVarChar,30,"username1",array[2]),
                                      SQLDbHelper.GetParameter("@si",SqlDbType.NVarChar,30,"username2",array[3]),
                                      SQLDbHelper.GetParameter("@picurl",SqlDbType.NVarChar,30,"username3",array[4])
                                      
                                  };
            SQLDbHelper.ExecuteSql(sb2.ToString(), param2);
        }
        public DataTable showAssociation()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from association");
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString());
            return table;
        }
        public void SocialSDelete(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("delete stylesocial where styleid=@id");
            SqlParameter[] param ={
                                       SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"id",id)
                                  };
            SQLDbHelper.ExecuteSql(sb.ToString(), param);
        }
        public DataTable SocialStyle(string author)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from stylesocial where author=@aut order by styleid desc ");
            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@aut",SqlDbType.NVarChar,30,"id",author)
                                  };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            return table;
        }
        public bool InsertStyleSoc(string[] array)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM stylesocial  WHERE theme =@theme ");

            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@theme",SqlDbType.NVarChar,30,"username",array[0])                     
                                  };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                StringBuilder sb2 = new StringBuilder();
                sb2.Append("INSERT INTO stylesocial (theme, con, timeplace, participants,picurl,author,socname) VALUES (@theme,@con,@timep,@par,@picurl,@aut,@socn)");

                SqlParameter[] param2 ={
                                      SQLDbHelper.GetParameter("@theme",SqlDbType.NVarChar,30,"username",array[0]),
                                      SQLDbHelper.GetParameter("@con",SqlDbType.NVarChar,30,"usernamef",array[1]),
                                      SQLDbHelper.GetParameter("@timep",SqlDbType.NVarChar,30,"username1",array[2]),
                                      SQLDbHelper.GetParameter("@par",SqlDbType.NVarChar,30,"username2",array[3]),
                                      SQLDbHelper.GetParameter("@picurl",SqlDbType.NVarChar,30,"username3",array[4]),
                                      SQLDbHelper.GetParameter("@aut",SqlDbType.NVarChar,30,"username4",array[5]),
                                      SQLDbHelper.GetParameter("@socn",SqlDbType.NVarChar,30,"username5",array[6])
                                  };
                SQLDbHelper.ExecuteSql(sb2.ToString(), param2);
                return true;
            }
        }
        public DataTable showNewsPer(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from news where newsid=@id ");
            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"id",id)
                                  };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            return table;
        }
        public void modifyNews(string title, string content, string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("update news set head=@title,con=@content where newsid=@id");
            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@title",SqlDbType.NVarChar,30,"title",title),
                                       SQLDbHelper.GetParameter("@content",SqlDbType.NVarChar,30,"content",content), 
                                       SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"id",id),
                                  };
            SQLDbHelper.ExecuteSql(sb.ToString(), param);
        }
        public int InsertNews(string title, string content, string author)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from news where head=@tit");

            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@tit",SqlDbType.NVarChar,30,"username",title)                     
                                  };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            if (table.Rows.Count > 0)
            {
                return 100;
            }
            else
            {
                StringBuilder sb2 = new StringBuilder();
                sb2.Append("insert into news(head,con,author) values(@title,@content,@author)");

                SqlParameter[] param2 ={
                                      SQLDbHelper.GetParameter("@title",SqlDbType.NVarChar,30,"username",title),
                                      SQLDbHelper.GetParameter("@content",SqlDbType.NVarChar,30,"usernamef",content),
                                      SQLDbHelper.GetParameter("@author",SqlDbType.NVarChar,30,"username",author)
                                  };
                return SQLDbHelper.ExecuteSql(sb2.ToString(), param2);
            }
        }
        public void deleteNews(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("delete news where newsid=@id");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"rffrr",id)  
                                    };
            SQLDbHelper.ExecuteSql(sb.ToString(), param);    
        }
        public DataTable showNews(string author)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from news where author=@Name order by newsid desc");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@Name",SqlDbType.NVarChar,30,"username",author)
                                      
                                    };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            return table;
        }
        public void signOut(string id, string sid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("update userlogin set social=@ssaa where id=@id");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@ssaa",SqlDbType.NVarChar,30,"username",sid),
                                        SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"rffrr",id)  
                                    };
            SQLDbHelper.ExecuteSql(sb.ToString(), param);
        }
        public void signOut2(string id, string sid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("update userlogin set member=@ssaa where id=@id");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@ssaa",SqlDbType.NVarChar,30,"username",sid),
                                        SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"rffrr",id)  
                                    };
            SQLDbHelper.ExecuteSql(sb.ToString(), param);
        }
        public DataTable showPersonSocial(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from association where social=@id");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"username",id)
                                      
                                    };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            return table;
        }
        public DataTable showPerson(string id)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from userlogin where ID=@id");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"username",id)
                                      
                                    };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            return table;
        }
        //modify personal information
        public void saveInfor(string id,string phone,string mail)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("update userlogin set pnumber=@num,email=@email where id=@id");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@num",SqlDbType.NVarChar,30,"username",phone),
                                        SQLDbHelper.GetParameter("@email",SqlDbType.NVarChar,30,"rrrr",mail)  ,
                                        SQLDbHelper.GetParameter("@id",SqlDbType.NVarChar,30,"rffrr",id)  
                                    };
            SQLDbHelper.ExecuteSql(sb.ToString(), param);
        }
        //修改密码
        public bool savePwd(string id, string pwd,string newpwd)
        {
            if (validUser(id, pwd))
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("update userlogin set userpwd=@pwd where ID=@username");
                SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@pwd",SqlDbType.NVarChar,30,"username",newpwd),
                                        SQLDbHelper.GetParameter("@username",SqlDbType.NVarChar,30,"username",id)  
                                    };
                SQLDbHelper.ExecuteSql(sb.ToString(), param);
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public DataTable SocialInfor(string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from association where joker=@social");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@social",SqlDbType.NVarChar,30,"username",name)  
                                    };
            return SQLDbHelper.ExecuteDt(sb.ToString(), param);
        }
        //判断是否为 社团 团长
        public bool isManagerOne(string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from association where joker=@social");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@social",SqlDbType.NVarChar,30,"username",name)  
                                    };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            if (table.Rows.Count > 0){return true;}
            else{ return false; }
        }
        public bool isManagerTwo(string name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select * from association where manager=@social");
            SqlParameter[] param =  {
                                        SQLDbHelper.GetParameter("@social",SqlDbType.NVarChar,30,"username",name)  
                                    };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            if (table.Rows.Count > 0) { return true; }
            else { return false; }
        }
        //登录
        public bool validUser(string username, string password)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM userlogin WHERE ID =@username and userpwd =@password"); 
            SqlParameter[] param = 
                                    {
                                        SQLDbHelper.GetParameter("@username",SqlDbType.NVarChar,30,"username",username),
                                        SQLDbHelper.GetParameter("@password",SqlDbType.VarChar,20,"userpwd",password)
                                    };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //注册 函数
        public bool InserUser(string username, string pwd, string sex, string phone, string mail)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM userlogin  WHERE id =@username ");

            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@username",SqlDbType.NVarChar,30,"username",username)                     
                                  };
            DataTable table = SQLDbHelper.ExecuteDt(sb.ToString(), param);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return InsertUsers(username, pwd, sex,phone,mail);
                
            }
        }
        //注册新用户函数  内部调用
        public bool InsertUsers(string username, string pwd, string sex, string phone, string mail)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO userlogin (id, userpwd, sex, pnumber,email) VALUES (@name,@password,@sex,@pnum,@mail)");
            SqlParameter[] param ={
                                      SQLDbHelper.GetParameter("@name",SqlDbType.NVarChar,30,"username",username) ,
                                      SQLDbHelper.GetParameter("@password",SqlDbType.NVarChar,30,"password",pwd) ,
                                      SQLDbHelper.GetParameter("@sex",SqlDbType.NVarChar,30,"sex",sex) ,
                                      SQLDbHelper.GetParameter("@pnum",SqlDbType.NVarChar,30,"pnum",phone),
                                      SQLDbHelper.GetParameter("@mail",SqlDbType.NVarChar,30,"mail",mail)
                                  };
            SQLDbHelper.ExecuteSql(sb.ToString(), param);
            return true;
        }
    }
}
