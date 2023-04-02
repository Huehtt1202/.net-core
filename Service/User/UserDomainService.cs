using Azure.Identity;
using Core.Entity;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityFramework.Connection;
using EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MyExceptions;
using Service.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service.user
{
    public class UserDomainService : Repository<crmDbContext>, IUserDomainService
    {
        private readonly crmDbContext _dbContext;
        private readonly DbSet<Core.Entity.User> _user;

        public UserDomainService(crmDbContext dbContext, DbSet<Core.Entity.User> user) : base(dbContext, user)
        {
            _dbContext = dbContext;
            _user = user;
        }

        public string AddNewAdmin(string username, string password)
        {
            public static List<User> users = new List<Core.Entity.User>();

        }

        public void DeleteAdmin(int id)
        {
            throw new NotImplementedException();
        }

        public void Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
            {
                var conPassword = MD5(password);
                List<Core.Entity.User> user = new List<Core.Entity.User>();
                foreach (var u in user)
                {
                    if(u.Password.Equals(password)&& u.UserName.Equals(user))
                    {
                        //login successfully
                    }
                    //login unsuccessfully
                }
            }
            throw new EmptyException();
        }

        public void Logout()
        {
        }
        public string MD5(string password)
        {
            try
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] fromData = Encoding.UTF8.GetBytes(password);
                byte[] targetData = md5.ComputeHash(fromData);
                string byte2String = null;

                for (int i = 0; i < targetData.Length; i++)
                {
                    byte2String += targetData[i].ToString("x2");

                }
                return byte2String;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
