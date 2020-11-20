using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SocialNetWorkingUpdata.IDAL
{
    //注册
    public interface Iuserinfo
    {
        bool InserUser(string username, string pwd, string sex,string phone, string mail);
        bool validUser(string username, string password);
        bool isManagerOne(string name);
        bool isManagerTwo(string name);
        bool savePwd(string id, string pwd, string newpwd);
        void saveInfor(string id, string phone, string mail);
        System.Data.DataTable showPerson(string id);
        System.Data.DataTable showPersonSocial(string id);
        void signOut(string id,string sid);
        void signOut2(string id, string sid);
        System.Data.DataTable showNews(string author);
        void deleteNews(string id);
        int InsertNews(string title, string content, string author);
        void modifyNews(string title, string content, string id);
        System.Data.DataTable showNewsPer(string id);
        bool InsertStyleSoc(string[] array);
        System.Data.DataTable SocialStyle(string author);
        void SocialSDelete(string id);
        System.Data.DataTable showAssociation();
        bool InsertSocial(string[] array);
        System.Data.DataTable userSocial(string social);
        DataTable SocialInfor(string name);
        void modifSoialInfor(string[] array);
        DataTable InSocial(string social);
        void InSocialYesNo(string social, string id, int yn);
        DataTable showAllNews();
        DataTable showAllStyle();
        DataTable styleContent(string id);
    }
}
