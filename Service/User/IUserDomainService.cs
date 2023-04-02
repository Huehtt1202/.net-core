using EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.User
{
    public interface IUserDomainService
    {
        string AddNewAdmin(string username, string password);
        void DeleteAdmin(int id);
        void Login(string username, string password);
        void Logout();
        string MD5(string password);
        //string ResetPassword(string password);

    }
}
