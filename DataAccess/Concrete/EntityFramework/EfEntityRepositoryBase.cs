using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {

        public List<TEntity> FindAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = new TContext();
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity Find(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new TContext();
            return context.Set<TEntity>().FirstOrDefault(filter);
        }

        public void Save(TEntity entity)
        {
            using var context = new TContext();
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using var context = new TContext();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
