using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Insert();
        void Update(T Entity);
        void Delete(T Entity);
        T FindById(string id);
        void Save(T Entity);
    }
}
