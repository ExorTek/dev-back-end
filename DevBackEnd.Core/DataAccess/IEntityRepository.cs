﻿using DevBackEnd.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DevBackEnd.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
    }
}