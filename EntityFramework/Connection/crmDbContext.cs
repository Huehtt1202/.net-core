using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EntityFramework.Connection
{
    public class crmDbContext : DbContext
    {
       
        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-J36DFC9Q\MSSQLSERVER01;Initial cataLog=crm ; Encrypt=False; ");
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-J36DFC9Q\MSSQLSERVER01;Initial Catalog=crm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
       
    }
}
