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

        public void Login(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new EmptyException();
            }
            else
            {
                var conPassword = MD5(password);
                List<User> user = new List<User>();
                foreach (var u in user)
                {
                    if (u.Equals(username) && u.Equals(conPassword))
                    {
                       
                    }

                }
            }
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

        public string ResetPassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}
