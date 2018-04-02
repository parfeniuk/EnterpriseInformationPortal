using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace RepositoryGeneric
{
    public interface IRepositoryContext<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity Find(object key);
        IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity,object key);
        TEntity Delete(TEntity entity);
        int Save();
    }
}
