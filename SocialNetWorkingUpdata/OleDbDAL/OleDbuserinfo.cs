using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SocialNetWorkingUpdata.DBUtility;
using System.Data;
using System.Data.OleDb;

namespace SocialNetWorkingUpdata.OleDbDAL
{
    public class userinfo : SocialNetWorkingUpdata.IDAL.Iuserinfo
    {
        public bool InserUser(string username, string pwd, string sex, string phone, string mail){return false;  }
        public bool validUser(string username, string password){return false;}
        public bool isManagerOne(string name) {return false;}
        public bool isManagerTwo(string name){return false;}
        public bool savePwd(string id, string pwd, string newpwd) { return false; }
        public void saveInfor(string id, string phone, string mail) { }
        public DataTable showPerson(string id){DataTable table = new DataTable("aeneag"); return table;}
        public DataTable showPersonSocial(string id) { DataTable table = new DataTable("aeneag"); return table; }
        public void signOut(string id, string sid) { }
        public void signOut2(string id, string sid) { }
        public DataTable showNews(string author) { DataTable table = new DataTable("aeneag"); return table; }
        public void deleteNews(string id) { }
        public int InsertNews(string title, string content, string author) { return 1; }
        public void modifyNews(string title, string content, string id) { }
        public DataTable showNewsPer(string id) { DataTable table = new DataTable("aeneag"); return table; }
        public bool InsertStyleSoc(string[] array) { return false; }
        public DataTable SocialStyle(string author) { DataTable table = new DataTable("aeneag"); return table; }
        public void SocialSDelete(string id) { }
        public DataTable showAssociation() { DataTable table = new DataTable("aeneag"); return table; }
        public bool InsertSocial(string[] array) { return false; }
        public DataTable userSocial(string social) { DataTable table = new DataTable("aeneag"); return table; }
        public DataTable SocialInfor(string name) { DataTable table = new DataTable("aeneag"); return table; }
        public void modifSoialInfor(string[] array) { }
        public DataTable InSocial(string social) { DataTable table = new DataTable("aeneag"); return table; }
        public void InSocialYesNo(string social, string id, int yn) { }
        public DataTable showAllNews() { DataTable table = new DataTable("aeneag"); return table; }
        public DataTable showAllStyle() { DataTable table = new DataTable("aeneag"); return table; }
        public DataTable styleContent(string id) { DataTable table = new DataTable("aeneag"); return table; }
    }
}
