using Core.Entity;
using EntityFramework.Connection;
using EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;
using Service.IDomainService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DomainService
{
    public class UserDomainService : Repository<User>, IUserDomainService
    {
        private readonly crmDbContext _dbContext;
        private readonly DbSet<User> _user;
        private readonly Repository<User> _repository;
        public UserDomainService(crmDbContext dbContext, User user, Repository<User> repository)
        {
            _dbContext = dbContext;
            _user = user;
            _repository = repository;
        }

        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public string MD5(string password)
        {
            throw new NotImplementedException();
        }

        public string ResetPassword(string password)
        {
            throw new NotImplementedException();
        }
    }
}
