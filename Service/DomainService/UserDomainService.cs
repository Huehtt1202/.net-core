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
        private readonly User _user;
        public UserDomainService(crmDbContext _dbContext, User _user)
        {
            _dbContext = _user;
        }
    }
}
