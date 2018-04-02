using System;
using System.Collections.Generic;
using System.Text;

namespace EntityMapper
{
    public interface IEntityMapperBase<TEntity,TDto>
        where TEntity : class, new()
        where TDto : class, new()
    {
        TDto Map(TEntity entity);
        TEntity Map(TDto dto);
    }
}
