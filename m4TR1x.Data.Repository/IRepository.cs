using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace m4TR1x.Data.Repository
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> Table { get; }

        IQueryable<T> TableNoTracking { get; }

        IEnumerable<T> GetSql(string sql);

        T Add(T entity);

        T Update(T entity);

        IQueryable<T> GetAll();

        IQueryable<T> Where(Expression<Func<T, bool>> expression, List<string> Includes = null);

        T Get(Expression<Func<T, bool>> expression);

        EntityEntry<T> Remove(T entity);

        int Save();
    }
}
