using EntityFramework.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly crmDbContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public Repository(crmDbContext dbContext, DbSet<T> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = dbSet;
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsEnumerable();
        }
        public T FindById(string id)
        {
            return _dbSet.FirstOrDefault();
        }
        public void Delete(T Entity)
        { 
            _dbSet.Remove(Entity);
        }
        public void Insert(T Entity)
        {
            _dbSet.Add(Entity);
        }
        public void Update(T Entity)
        {
            _dbSet.Update(Entity);
        }
        public void Save(T Entity)
        {
            _dbSet.SaveChange()
        }
    }
}
