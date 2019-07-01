using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.IRepository
{
    public interface IRepositoryBase<T> where T:class
    {
        IList<T> Finds(string sql);
        T Get(string id);
        void Create(T t);
        void Modify(T t);
        void Delete(string id);
    }
}
