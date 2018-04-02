using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryGeneric
{
    public class RepositoryBase<TEntity> : IRepositoryContext<TEntity>
        where TEntity : class, new()
    {
        private DbContext _context;
        private DbSet<TEntity> _set;

        public RepositoryBase(DbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _set=_context.Set<TEntity>()?? throw new ArgumentNullException(nameof(_set));
        }

        public TEntity Find(object key)
        {
            return _set.Find(key);
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _set.Where(predicate);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _set;
        }

        public TEntity Add(TEntity entity)
        {
            _set.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            _set.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Update(TEntity entity, object key)
        {
            if(entity==null)return null;
            TEntity existed = _set.Find(key);
            if (existed != null)
            {
                _context.Entry(existed).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
            return existed;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
