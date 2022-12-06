using Core.Entity;
using DocumentFormat.OpenXml.Wordprocessing;
using EntityFramework.Connection;
using EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;
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

    }
}
