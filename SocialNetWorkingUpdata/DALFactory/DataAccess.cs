using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Reflection;

namespace SocialNetWorkingUpdata.DALFactory
{
    public class DataAccess
    {
        //以下是连接Access数据库的命名空间路径
        //private static readonly string path = ConfigurationSettings.AppSettings["OleDbDAL"];
        //以下是连接SQLserver数据库的命名空间路径
        private static readonly string path = ConfigurationSettings.AppSettings["SQLDAL"];
        public static SocialNetWorkingUpdata.IDAL.Iuserinfo Createuserinfo()
        {
            string className = path + ".userinfo";
            return (SocialNetWorkingUpdata.IDAL.Iuserinfo)Assembly.Load(path).CreateInstance(className);
        }
    }
}
