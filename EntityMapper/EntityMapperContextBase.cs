using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityMapper
{
    public class EntityMapperContextBase : IEntityMapperContextBase
    {
        public IEntityMapperBase<TEntity, TDto> Set<TEntity, TDto>(Action<IMapperConfigurationExpression> cfg)
            where TEntity : class, new()
            where TDto : class, new()
        {
            return new EntityMapperBase<TEntity,TDto>(cfg);
        }
    }
}