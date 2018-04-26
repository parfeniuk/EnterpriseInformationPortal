using System;
using System.Collections.Generic;
using System.Text;

namespace EntityMapper
{
    public interface IEntityMapperBase<TSource,TDestination>
        where TSource : class, new()
        where TDestination : class, new()
    {
        TDestination Map(TSource entity);
        TSource Map(TDestination dto);
    }
}
