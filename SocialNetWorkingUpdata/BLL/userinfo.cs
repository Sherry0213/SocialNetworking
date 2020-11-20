using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocialNetWorkingUpdata.IDAL;
using SocialNetWorkingUpdata.DALFactory;
using System.Web;
using System.Data;
namespace SocialNetWorkingUpdata.BLL
{
    public class userinfo
    {
        private static readonly Iuserinfo user = DataAccess.Createuserinfo();
        public bool InserUser(string username, string pwd, string sex,string phone,string mail)
        {
            return user.InserUser(username, pwd, sex,phone,mail);
        }
        public bool validUser(string username, string password)
        {
            return user.validUser(username, password);
        }
        public bool isManagerOne(string name)
        {
            return user.isManagerOne(name);
        }
        public bool isManagerTwo(string name)
        {
            return user.isManagerTwo(name);
        }
        public bool savePwd(string id, string pwd, string newpwd)
        {
            return user.savePwd(id, pwd, newpwd);
        }
        public void saveInfor(string id, string phone, string mail)
        {
            user.saveInfor(id,phone, mail);
        }
        public DataTable showPerson(string id)
        {
            return user.showPerson(id);
        }
        public DataTable showPersonSocial(string id)
        {
            return user.showPersonSocial(id);
        }
        public void signOut(string id, string sid)
        {
            user.signOut(id, sid);
        }
        public DataTable showNews(string author)
        {
            return user.showNews(author);
        }
        public void deleteNews(string id)
        {
            user.deleteNews(id);
        }
        public int InsertNews(string title, string content, string author)
        {
            return user.InsertNews(title, content,author);
        }
        public void modifyNews(string title, string content, string id)
        {
            user.modifyNews(title, content, id);
        }
        public DataTable showNewsPer(string id)
        {
            return user.showNewsPer(id);
        }
        public bool InsertStyleSoc(string[] array)
        {
            return user.InsertStyleSoc(array);
        }
        public DataTable SocialStyle(string author)
        {
            return user.SocialStyle(author);
        }
        public void SocialSDelete(string id)
        {
            user.SocialSDelete(id);
        }
        public DataTable showAssociation()
        {
            return user.showAssociation();
        }
        public bool InsertSocial(string[] array)
        {
            return user.InsertSocial(array);
        }
        public DataTable userSocial(string social)
        {
            return user.userSocial(social);
        }
        public DataTable SocialInfor(string name)
        {
            return user.SocialInfor(name);
        }
        public void modifSoialInfor(string[] array)
        {
            user.modifSoialInfor(array);
        }
        public DataTable InSocial(string social)
        {
            return user.InSocial(social);
        }
        public void InSocialYesNo(string social, string id, int yn)
        {
            user.InSocialYesNo(social, id, yn);
        }
        public void signOut2(string id, string sid)
        {
            user.signOut2(id,sid);
        }
        public DataTable showAllNews()
        {
            return user.showAllNews();
        }
        public DataTable showAllStyle()
        {
            return user.showAllStyle();
        }
        public DataTable styleContent(string id)
        {
            return user.styleContent(id);
        }
    }
}
