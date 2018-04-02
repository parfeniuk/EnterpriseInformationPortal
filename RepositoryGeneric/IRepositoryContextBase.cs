using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryGeneric
{
    public interface IRepositoryContextBase:IDisposable
    {
        IRepositoryContext<TEntity> Set<TEntity>()
            where TEntity : class, new();
    }
}
