using System;
using AutoMapper;
using System.Collections.Generic;
using System.Text;

namespace EntityMapper
{
    public class EntityMapperBase<TSource,TDestination> : IEntityMapperBase<TSource,TDestination>
        where TSource:class,new()
        where TDestination:class,new()
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
                    cfg.CreateMap<TSource, TDestination>();
                    cfg.CreateMap<TDestination, TSource>();
                });
            }
            else
            {
                return new MapperConfiguration(_cfg);
            }
        }

        public TSource Map(TDestination dto)
        {
            return _mapper.Map<TDestination,TSource>(dto);
        }

        public TDestination Map(TSource entity)
        {
            return _mapper.Map<TSource,TDestination>(entity);
        }
    }
}
