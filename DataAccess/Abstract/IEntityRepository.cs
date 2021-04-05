﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstract
{
    public interface IEntityRepository<T> where T:class , IEntity , new()
    {
        List<T> GetByAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetCarsByBrandId(Expression<Func<T, bool>> filter);
        T GetCarsByColorId(Expression<Func<T, bool>> filter);
    }
}
