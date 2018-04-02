using AutoMapper;
using Base2BaseWeb.B2B.DataLayer.Entities;
using Base2BaseWeb.UI.Areas.Company.Models.ClientsViewModel;
using EntityMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.EntityMappers.CompanyArea
{
    public class ClientMapper:EntityMapperBase<Point,ClientsIndexViewModel>
    {

        public ClientMapper():base
            (/*cfg =>*/
            //{
            //    cfg.CreateMap<Point, ClientsIndexViewModel>()
            //    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PointNumber))
            //    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NamePoint))
            //    .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.CliGroupNumberNavigation.CliGroupName))
            //    .ForMember(dest => dest.ContactName, opt => opt.MapFrom(src => src.ContactPerson))
            //    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Telefon))
            //    .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Saldo));
            //}
            )
        {
        }

        //protected override MapperConfiguration MapConfigurate()
        //{
        //    return new MapperConfiguration(cfg=> 
        //    {
        //        cfg.CreateMap<Point, ClientsIndexViewModel>()
        //        .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PointNumber))
        //        .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NamePoint))
        //        .ForMember(dest=>dest.GroupName,opt=>opt.MapFrom(src=>src.CliGroupNumberNavigation.CliGroupName))
        //        .ForMember(dest => dest.ContactName, opt => opt.MapFrom(src => src.ContactPerson))
        //        .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Telefon))
        //        .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Saldo));
        //    });
        //}
    }
}
