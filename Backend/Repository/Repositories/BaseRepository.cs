using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Contexts.HumanCapitalContext;

namespace Repository.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly HumanCapitalContext _HumanCapitalContext;
        public BaseRepository(HumanCapitalContext HumanCapitalContext)
        {
            _HumanCapitalContext = HumanCapitalContext;
        }

        public void Create(T entity)
        {
            _HumanCapitalContext.Add(entity);
        }

        public void Delete(T entity)
        {
            _HumanCapitalContext.Remove(entity);

        }

        public IQueryable<T> FindAll()
        {
            return _HumanCapitalContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindAllByCondition(Expression<Func<T, bool>> condition, bool tracking)
        {
            IQueryable<T> query = _HumanCapitalContext.Set<T>().Where(condition);

            return tracking ? query : query.AsNoTracking();
        }

        public void Update(T entity)
        {
            _HumanCapitalContext.Update(entity);
        }

        public void SaveChanges()
        {
            _HumanCapitalContext.SaveChanges();
        }

        public T FindById(Guid id)
        {
            return _HumanCapitalContext.Find<T>(id);
        }
    }
}
