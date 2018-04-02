using System;
using AutoMapper;
using System.Collections.Generic;
using System.Text;

namespace EntityMapper
{
    public class EntityMapperBase<TEntity,TDto> : IEntityMapperBase<TEntity,TDto>
        where TEntity:class,new()
        where TDto:class,new()
    {
        private IMapper _mapper;
        protected Action<IMapperConfigurationExpression> _cfg;

        public EntityMapperBase(Action<IMapperConfigurationExpression> cfg=null)
        {
            _cfg = cfg;
            _mapper=MapConfigurate().CreateMapper();
        }
        protected virtual MapperConfiguration MapConfigurate()
        {
            if (_cfg == null)
            {
                return new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<TEntity, TDto>();
                    cfg.CreateMap<TDto, TEntity>();
                });
            }
            else
            {
                return new MapperConfiguration(_cfg);
            }
        }

        public TEntity Map(TDto dto)
        {
            return _mapper.Map<TDto,TEntity>(dto);
        }

        public TDto Map(TEntity entity)
        {
            return _mapper.Map<TEntity,TDto>(entity);
        }
    }
}
