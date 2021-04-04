using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace m4TR1x.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private bool _isDisposed = false;

        private readonly DbContext _context;
        private DbSet<T> _dbSet;
        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetSql(string sql)
        {
            return Entities.FromSqlRaw(sql);
        }
        public virtual IQueryable<T> Table => Entities;

        public virtual IQueryable<T> TableNoTracking => Entities.AsNoTracking();

        protected virtual DbSet<T> Entities => _dbSet ??= _context.Set<T>();

        public T Add(T entity)
        {
            var entityEntry = Entities.Add(entity);
            return entityEntry.Entity;
        }

        public T Get(Expression<Func<T, bool>> expression)
        {
            var result = Entities.FirstOrDefault(expression);
            return result;
        }

        public IQueryable<T> GetAll()
        {
            return Entities.AsQueryable();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression, List<string> includes)
        {
            var query = Entities.Where(expression);

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return query;
        }

        public T Update(T entity)
        {
            var entityEntry = Entities.Update(entity);
            return entityEntry.Entity;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public EntityEntry<T> Remove(T entity)
        {
            return Entities.Remove(entity);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    //_dbSet
                }

                _isDisposed = true;
            }
        }
    }
}
