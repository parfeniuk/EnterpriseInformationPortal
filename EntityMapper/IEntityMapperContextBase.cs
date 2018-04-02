using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityMapper
{
    public interface IEntityMapperContextBase
    {
        IEntityMapperBase<TEntity, TDto> Set<TEntity, TDto>(Action<IMapperConfigurationExpression> cfg)
            where TEntity : class, new()
            where TDto : class, new();
    }
}
