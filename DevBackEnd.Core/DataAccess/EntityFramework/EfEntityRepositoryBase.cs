using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DevBackEnd.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevBackEnd.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public EfEntityRepositoryBase(TContext context)
        {
            Context = context;
        }

        protected TContext Context { get; }

        public TEntity Add(TEntity entity)
        {
            return Context.Add(entity).Entity;
        }

        public void  Delete(TEntity entity)
        {
            Context.Update(entity);
        }

        public TEntity Update(TEntity entity)
        {
            Context.Remove(entity);
            return entity;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? Context.Set<TEntity>().ToList() : Context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            return Context.Set<TEntity>().FirstOrDefault(filter);
        }
    }
}