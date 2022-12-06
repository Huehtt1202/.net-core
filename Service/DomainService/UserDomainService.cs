using Azure.Identity;
using Core.Entity;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityFramework.Connection;
using EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MyExceptions;
using Service.IDomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Service.DomainService
{
    public class UserDomainService : Repository<User>, IUserDomainService
    {
        private readonly crmDbContext _dbContext;
        private readonly DbSet<User> _user;

        public UserDomainService(crmDbContext dbContext, DbSet<User> user) : base(dbContext, user)
        {
            _dbContext = dbContext;
            _user = user;
        }

        public object GetSession()
        {
            return GetSession;
        }

        public void Login(string username, string conpPassword)
        {
            var conPassword = MD5(conpPassword);
            var dataUser = _dbContext.User.Where(s => s.UserName.Equals(username) && s.Password.Equals(conpPassword));
            if (dataUser.Count() > 0)
            {
                GetSession["DisplayUseraName"] = dataUser.FirstOrDefault().DisplayUserName;
                GetSession["idUser"] = dataUser.FirstOrDefault().Id;
                session["UserName"] = dataUser.FirstOrDefault().UserName;
            }
        }

        public void Logout()
        {
            Login.Clear();
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

        public string ResetPassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}
