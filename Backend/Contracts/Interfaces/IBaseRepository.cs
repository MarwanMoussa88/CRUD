using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> FindAll();
        T FindById(Guid id);
        IQueryable<T> FindAllByCondition(Expression<Func<T, bool>> condition, bool tracking);
        void Create(T entity);
        void Update(T entity);
        void Delete(T Entity);
    }
}
