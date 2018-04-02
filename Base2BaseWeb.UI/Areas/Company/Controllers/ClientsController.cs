using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base2BaseWeb.B2B.DataLayer.Entities;
using Base2BaseWeb.UI.Areas.Company.DTO;
using Base2BaseWeb.UI.Areas.Company.Models.ClientEditViewModel;
using Base2BaseWeb.UI.Areas.Company.Models.ClientsViewModel;
using Base2BaseWeb.UI.BaseControllers;
using Base2BaseWeb.UI.EntityMappers.CompanyArea;
using EntityMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryGeneric;

namespace Base2BaseWeb.UI.Areas.Company.Controllers
{
    [Area("Company")]
    [Authorize(Roles ="Admin")]
    public class ClientsController :BaseController
    {
        //private IEntityMapperBase<Point,ClientsIndexViewModel> _entityMapper;
        private IEntityMapperContextBase _entityMapperContextBase;
        private IEntityMapperBase<Point, ClientsIndexViewModel> _clientIndexMapper;
        private IEntityMapperBase<Point, ClientEditViewModel> _clientEditMapper;
        private IEntityMapperBase<Point, ClientContactsEditViewModel> _clientContactsMapper;
        private IEntityMapperBase<Point, ClientPaymentDetailsEditViewModel> _clientPaymentDetailsMapper;
        private IEntityMapperBase<Point, ClientDebtDetailsEditViewModel> _clientDebtDetailsMapper;

        public ClientsController(IRepositoryContextBase context, IEntityMapperContextBase entityMapperContextBase)
            :base(context)
        {
            _entityMapperContextBase = entityMapperContextBase;
        }

        public IActionResult Index()
        {
            _clientIndexMapper = _entityMapperContextBase.Set<Point, ClientsIndexViewModel>(cfg =>
            {
                cfg.CreateMap<Point, ClientsIndexViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PointNumber))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NamePoint))
                .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.CliGroup.CliGroupName))
                .ForMember(dest => dest.ContactName, opt => opt.MapFrom(src => src.ContactPerson))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Telefon))
                .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Saldo));
            }
            );

            var model = _context.Set<Point>()
                .FindBy(p => p.CliGroupNumber == 7 || p.CliGroupNumber == 2)
                .Include(e => e.CliGroup)
                .Select(c => _clientIndexMapper.Map(c))
                .OrderBy(c => c.GroupName)
                .ThenBy(c => c.Name);
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            _clientEditMapper = _entityMapperContextBase.Set<Point, ClientEditViewModel>(cfg =>
            {
                cfg.CreateMap<Point, ClientEditViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PointNumber))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NamePoint));
            }
            );
            var model = _context.Set<Point>()
                .FindBy(p => p.PointNumber == id)
                .Include(p => p.CliGroup)
                .Select(p => _clientEditMapper.Map(p))
                .FirstOrDefault();
            // Add List of Groups to the Model
            IEnumerable<CliGroup> groups = _context.Set<CliGroup>()
                .FindBy(g=>g.CliGroupNumber==2||g.CliGroupNumber==7);
            model.CliGroups = groups.ToList();
            return View(model);
        }

        public IActionResult ClientContacts(int id)
        {
            _clientContactsMapper = _entityMapperContextBase.Set<Point, ClientContactsEditViewModel>(cfg =>
            {
                cfg.CreateMap<Point, ClientContactsEditViewModel>()
                .ForMember(dest => dest.LegalAddress, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.PhoneNumber1, opt => opt.MapFrom(src => src.Telefon))
                .ForMember(dest => dest.ContactFullName1, opt => opt.MapFrom(src => src.ContactPerson))
                .ForMember(dest => dest.Email1, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.FirstSignatory, opt => opt.MapFrom(src => src.Name1Person))
                .ForMember(dest => dest.SecondSignatory, opt => opt.MapFrom(src => src.Name2Person))
                .ForMember(dest=>dest.ContactPhonesAll,opt=>opt.MapFrom(src=>src.ContactPhoneInfo))
                .ForMember(dest=>dest.ContactEmailsAll,opt=>opt.MapFrom(src=>src.ContactEmailInfo));
            }
            );
            var model = _context.Set<Point>()
                .FindBy(p => p.PointNumber == id)
                .Include(p=>p.ContactPhoneInfo)
                .Include(p=>p.ContactEmailInfo)
                .Select(c => _clientContactsMapper.Map(c))
                .FirstOrDefault();
            // Fill ContactPhonesView
            for (int i = 0; i < model.ContactPhonesCapacity; i++)
            {
                if (model.ContactPhonesAll.ElementAtOrDefault(i) != null)
                    model.ContactPhonesView.Add(model.ContactPhonesAll.ElementAtOrDefault(i));
                else
                    model.ContactPhonesView.Add(new ContactPhoneDto
                    {
                        PhoneNumber = string.Empty,
                        ContactFullName=string.Empty
                    });
            }
            // Fill ContactEmailsView
            for (int i = 0; i < model.ContactEmailsCapacity; i++)
            {
                if (model.ContactEmailsAll.ElementAtOrDefault(i) != null)
                    model.ContactEmailsView.Add(model.ContactEmailsAll.ElementAtOrDefault(i));
                else
                    model.ContactEmailsView.Add(new ContactEmailDto
                    {
                        Email = string.Empty,
                        IncludeToMailList = false
                    });
            }
            return PartialView(model);
        }

        public IActionResult ClientPaymentDetails(int id)
        {
            _clientPaymentDetailsMapper = _entityMapperContextBase.Set<Point, ClientPaymentDetailsEditViewModel>(cfg =>
            {
                cfg.CreateMap<Point, ClientPaymentDetailsEditViewModel>()
                .ForMember(dest => dest.FiscalNumber, opt => opt.MapFrom(src => src.IndNum))
                .ForMember(dest => dest.Certificate, opt => opt.MapFrom(src => src.SvidNum));
            }
            );

            var model = _context.Set<Point>()
                .FindBy(p => p.PointNumber == id)
                .Select(c => _clientPaymentDetailsMapper.Map(c))
                .FirstOrDefault();

            if (model != null)
            {
                var contractors = _context.Set<Point>()
                    .FindBy(p => p.Post == false)
                    ?.Select(p => new ContractorDto
                    {
                        ContractorDtoId = p.PointNumber,
                        ContractorName = p.NamePoint
                    });
                if (contractors != null)
                {
                    model.Contractors = contractors.ToList();
                }
                return PartialView(model);
            }
            else
            {
                return NotFound($"Клиент с id: {id} не найден.");
            }
        }

        public IActionResult ClientDebtDetails(int id)
        {
            _clientDebtDetailsMapper = _entityMapperContextBase.Set<Point, ClientDebtDetailsEditViewModel>(cfg=> 
            {
                cfg.CreateMap<Point, ClientDebtDetailsEditViewModel>()
                .ForMember(dest => dest.DebtControl, opt => opt.MapFrom(src => src.DebtControlInfo))
                .ForMember(dest => dest.DebtCalcMethod, opt => opt.MapFrom(src => src.DebtCalcMethodInfo))
                .ForMember(dest => dest.BillSettings, opt => opt.MapFrom(src => src.BillSettingsInfo))
                .ForMember(dest => dest.Franchising, opt => opt.MapFrom(src => src.FranchisingInfo))
                .ForMember(dest => dest.ClientConnection, opt => opt.MapFrom(src => src.ClientConnectionInfo))
                .ForPath(dest => dest.BillSettings.DocumentTemplate, opt => opt.MapFrom(src => src.BillSettingsInfo.DocumentTemplate))
                .ForPath(dest => dest.BillSettings.PrintJobInfo, opt => opt.MapFrom(src => src.BillSettingsInfo.PrintJobInfo))
                .ForPath(dest => dest.BillSettings.BillSettingsOptionsInfo, opt => opt.MapFrom(src => src.BillSettingsInfo.BillSettingsOptionsInfo))
                .ForMember(dest=>dest.DebtControl,opt=>opt.Condition(src=>src.DebtControlInfo!=null))
                .ForMember(dest => dest.DebtCalcMethod, opt => opt.Condition(src => src.DebtCalcMethodInfo != null))
                .ForMember(dest => dest.BillSettings, opt => opt.Condition(src => src.BillSettingsInfo != null))
                .ForMember(dest => dest.Franchising, opt => opt.Condition(src => src.FranchisingInfo != null))
                .ForMember(dest => dest.ClientConnection, opt => opt.Condition(src => src.ClientConnectionInfo != null))
                .ForPath(dest=>dest.BillSettings.DocumentTemplate,opt=>opt.Condition(src=>src.Source.BillSettingsInfo?.DocumentTemplate!=null))
                .ForPath(dest => dest.BillSettings.DocumentTemplate, opt => opt.Condition(src => src.Source.BillSettingsInfo?.PrintJobInfo != null))
                .ForPath(dest => dest.BillSettings.DocumentTemplate, opt => opt.Condition(src => src.Source.BillSettingsInfo?.BillSettingsOptionsInfo != null))
                ;
            });
            var clients = _context.Set<Point>()
                .FindBy(p => p.PointNumber == id)
                .Include(p=>p.BillSettingsInfo)
                .Include(p=>p.BillSettingsInfo.PrintJobInfo)
                .Include(p=>p.BillSettingsInfo.BillSettingsOptionsInfo)
                .Include(p=>p.BillSettingsInfo.DocumentTemplate)
                .Include(p=>p.DebtControlInfo)
                .Include(p=>p.DebtCalcMethodInfo)
                .Include(p=>p.FranchisingInfo)
                .Include(p=>p.ClientConnectionInfo);
            if (clients?.FirstOrDefault() != null)
            {
                var client = clients.FirstOrDefault();
                var model = _clientDebtDetailsMapper.Map(client);
                // Check all properties for null
                model.DebtControl = model.DebtControl ?? new DebtControlDto();
                model.DebtCalcMethod = model.DebtCalcMethod ?? new DebtCalcMethodDto();
                model.BillSettings = model.BillSettings ?? new BillSettingsDto();
                model.Franchising = model.Franchising ?? new FranchisingDto();
                model.ClientConnection = model.ClientConnection ?? new ClientConnectionDto();

                // Check nested BillSettings Properties for null
                // 1. PrintJob
                if (model.BillSettings.PrintJobInfo==null)
                {
                    model.BillSettings.PrintJobInfo = new HashSet<PrintJobDto>();
                }
                // Add items into PrintJobsView
                for (int i = 0; i < model.PrintJobsCapacity; i++)
                {
                    if (model.BillSettings.PrintJobInfo.ElementAtOrDefault(i) != null)
                    {
                        model.PrintJobsView.Add(model.BillSettings.PrintJobInfo.ElementAtOrDefault(i));
                    }
                    else
                    {
                        model.PrintJobsView.Add(new PrintJobDto {DocumentToPrintCopies=0 });
                    }
                }
                // 2. BillSettingsOptions
                if (model.BillSettings.BillSettingsOptionsInfo==null)
                {
                    model.BillSettings.BillSettingsOptionsInfo = new HashSet<BillSettingsOptionsDto>();
                }
                // Add items into BillSettingsOptionsInfo here
                for (int i = 0; i < model.BillSettingsOptionsCapacity; i++)
                {
                    if (model.BillSettings.BillSettingsOptionsInfo.ElementAtOrDefault(i) != null)
                    {
                        model.BillSettingsOptionsView.Add(model.BillSettings.BillSettingsOptionsInfo.ElementAtOrDefault(i));
                    }
                    else
                    {
                        model.BillSettingsOptionsView.Add(new BillSettingsOptionsDto {Limit=0 });
                    }
                }

                // DocumentTemplates
                model.DocumentTemplates = _context.Set<DocumentTemplate>()
                    .GetAll()
                    ?.Select(d => new DocumentTemplateDto { Name = d.Name })
                    .ToList()
                    ?? model.DocumentTemplates;
                // Print Jobs

                // ServicePlaceholders

                //// Check all other properties here.....
                return PartialView(model);
            }
            else
            {
                return NotFound($"Клиент с id: {id} не найден.");
            }
        }
    }
}