using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> FindAll(Expression<Func<T, bool>> filter = null);
        T Find(Expression<Func<T, bool>> filter);
        void Save(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
