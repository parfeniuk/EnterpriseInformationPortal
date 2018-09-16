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
using Microsoft.Extensions.Logging;
using RepositoryGeneric;

namespace Base2BaseWeb.UI.Areas.Company.Controllers
{
    [Area("Company")]
    [Authorize(Roles ="Admin")]
    public class ClientsController :BaseController
    {
        private IEntityMapperContextBase _entityMapperContextBase;
        private IEntityMapperBase<Point, Client> _clientIndexMapper;
        private IEntityMapperBase<Point, ClientEditViewModel> _clientEditMapper;
        private IEntityMapperBase<Point, ClientContactsEditViewModel> _clientContactsMapper;
        private IEntityMapperBase<Point, ClientPaymentDetailsEditViewModel> _clientPaymentDetailsMapper;
        private IEntityMapperBase<Point, ClientDebtDetailsEditViewModel> _clientDebtDetailsMapper;

        private readonly ILogger _logger;

        public ClientsController(IRepositoryContextBase context, 
            IEntityMapperContextBase entityMapperContextBase, ILogger<ClientsController> logger)
            :base(context)
        {
            _entityMapperContextBase = entityMapperContextBase;
            _logger = logger;
        }

        public IActionResult Index(string searchString="")
        {
            _logger.LogInformation($"Getting Customers' List, search by {searchString}, user: {User.Identity.Name}");
            try
            {
                _clientIndexMapper = _entityMapperContextBase.Set<Point, Client>(cfg =>
                {
                    cfg.CreateMap<Point, Client>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PointNumber))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NamePoint))
                    .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.CliGroup.CliGroupName))
                    .ForMember(dest => dest.ContactName, opt => opt.MapFrom(src => src.ContactPerson))
                    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Telefon))
                    .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Saldo));
                }
                );
            }
            catch (Exception ex)
            {
                _logger.LogError($"Mapping error: {ex.Message}");
            }

            IEnumerable<Client> clients;
            var model = new ClientsIndexViewModel();
            
            if (!string.IsNullOrEmpty(searchString))
            {
                model.SearchString = string.Concat(searchString.ToCharArray().Where(c => !Char.IsWhiteSpace(c)));

                clients = _context.Set<Point>()
                    .GetAll()
                    //.FindBy(p => p.CliGroupNumber == 7 || p.CliGroupNumber == 2)
                    ?.Where(p=>p.NamePoint.ToLower().Contains(searchString.ToLower()))
                    ?.Include(e => e.CliGroup)
                    ?.Select(c => _clientIndexMapper.Map(c))
                    ?.OrderBy(c => c.GroupName)
                    .ThenBy(c => c.Name);
            }
            else
            {
                clients = _context.Set<Point>()
                    .GetAll()
                    //?.FindBy(p => p.CliGroupNumber == 7 || p.CliGroupNumber == 2)
                    ?.Include(e => e.CliGroup)
                    ?.Select(c => _clientIndexMapper.Map(c))
                    ?.OrderBy(c => c.GroupName)
                    .ThenBy(c => c.Name);
            }
            if (clients != null)
            {
                
                model.Clients = clients;
                return View(model);
            }
            else
            {
                _logger.LogWarning("Customers NOT FOUND!");
                return NotFound("Клиенты не найдены");
            }
        }

        public IActionResult ClientsList(string searchString)
        {
            _logger.LogInformation($"Getting Customers' List, search by {searchString}, user: {User.Identity.Name}");
            try
            {
                _clientIndexMapper = _entityMapperContextBase.Set<Point, Client>(cfg =>
                {
                    cfg.CreateMap<Point, Client>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PointNumber))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NamePoint))
                    .ForMember(dest => dest.GroupName, opt => opt.MapFrom(src => src.CliGroup.CliGroupName))
                    .ForMember(dest => dest.ContactName, opt => opt.MapFrom(src => src.ContactPerson))
                    .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Telefon))
                    .ForMember(dest => dest.Balance, opt => opt.MapFrom(src => src.Saldo));
                }
                );
            }
            catch (Exception ex)
            {
                _logger.LogError($"Mapping error: {ex.Message}");
            }

            IEnumerable<Client> clients;
            var model = new ClientsIndexViewModel();
            
            if (!string.IsNullOrEmpty(searchString))
            {
                model.SearchString = string.Concat(searchString.ToCharArray().Where(c => !Char.IsWhiteSpace(c)));

                clients = _context.Set<Point>()
                    .GetAll()
                    //.FindBy(p => p.CliGroupNumber == 7 || p.CliGroupNumber == 2)
                    ?.Where(p=>p.NamePoint.ToLower().Contains(model.SearchString.ToLower()))
                    ?.Include(e => e.CliGroup)
                    ?.Select(c => _clientIndexMapper.Map(c))
                    ?.OrderBy(c => c.GroupName)
                    .ThenBy(c => c.Name);
            }
            else
            {
                clients = _context.Set<Point>()
                    .GetAll()
                    //?.FindBy(p => p.CliGroupNumber == 7 || p.CliGroupNumber == 2)
                    ?.Include(e => e.CliGroup)
                    ?.Select(c => _clientIndexMapper.Map(c))
                    ?.OrderBy(c => c.GroupName)
                    .ThenBy(c => c.Name);
            }
            if (clients != null)
            {
                model.Clients = clients;
                return PartialView(model);
            }
            else
            {
                _logger.LogWarning($"Customers by search pattern: {searchString} NOT FOUND!");
                return NotFound("Клиенты не найдены");
            }
        }

        public IActionResult Edit(int id)
        {
            _logger.LogInformation($"Getting Customer, ID: {id}, user: {User.Identity.Name}");
            try
            {
                _clientEditMapper = _entityMapperContextBase.Set<Point, ClientEditViewModel>(cfg =>
                {
                    cfg.CreateMap<Point, ClientEditViewModel>()
                    .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PointNumber))
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NamePoint));
                }
                );
            }
            catch (Exception ex)
            {
                _logger.LogError($"Mapping error: {ex.Message}");
            }
            var model = _context.Set<Point>()
                ?.FindBy(p => p.PointNumber == id)
                ?.Include(p => p.CliGroup)
                ?.Select(p => _clientEditMapper.Map(p))
                ?.FirstOrDefault();
            if (model != null)
            {
                // Add List of Groups to the Model
                IEnumerable<CliGroup> groups = _context.Set<CliGroup>()
                    ?.FindBy(g => g.CliGroupNumber == 2 || g.CliGroupNumber == 7);
                model.CliGroups = groups?.ToList();
                return View(model);
            }
            else
            {
                _logger.LogWarning($"Customer with ID: {id} NOT FOUND!");
                return NotFound($"Клиент с id: {id} не найден.");
            }
        }

        [HttpPost]
        public IActionResult Edit(ClientEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                ///
                return View(model);
            }
            return View(model);
        }

        public IActionResult ClientContacts(int id)
        {
            _logger.LogInformation($"Getting Customer CONTACT INFO, ID: {id}, user: {User.Identity.Name}");
            try
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
                    .ForMember(dest => dest.ContactPhonesAll, opt => opt.MapFrom(src => src.ContactPhoneInfo))
                    .ForMember(dest => dest.ContactEmailsAll, opt => opt.MapFrom(src => src.ContactEmailInfo));
                }
                );
            }
            catch (Exception ex)
            {
                _logger.LogError($"Mapping error: {ex.Message}");
            }

            var model = _context.Set<Point>()
                .FindBy(p => p.PointNumber == id)
                ?.Include(p=>p.ContactPhoneInfo)
                ?.Include(p=>p.ContactEmailInfo)
                ?.Select(c => _clientContactsMapper.Map(c))
                ?.FirstOrDefault();
            if (model != null)
            {
                model.Id = id;
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
            else
            {
                _logger.LogWarning($"Customer with ID: {id} NOT FOUND!");
                return NotFound($"Клиент с id: {id} не найден.");
            }
        }

        [HttpPost]
        public IActionResult ClientContacts(ClientContactsEditViewModel model)
        {
            _logger.LogInformation($"Editing Customer CONTACT INFO, ID: {model.Id}, user: {User.Identity.Name}");
            if (ModelState.IsValid)
            {
                // Get current Domain Entity object
                Point entity = _context.Set<Point>()
                    ?.FindBy(p=>p.PointNumber==model.Id)
                    ?.Include(p=>p.ContactPhoneInfo)
                    ?.Include(p=>p.ContactEmailInfo)
                    ?.FirstOrDefault();
                if (entity != null)
                {
                    // Update modified properties
                    entity.Address = model.LegalAddress;
                    entity.Telefon = model.PhoneNumber1;
                    entity.ContactPerson = model.ContactFullName1;
                    entity.Email = model.Email1;
                    entity.Name1Person = model.FirstSignatory;
                    entity.Name2Person = model.SecondSignatory;
                    entity.IncludeToMailList = model.IncludeToMailList;
                    entity.ContactPhoneInfo =
                       model.ContactPhonesView.Select(c =>
                       _entityMapperContextBase.Set<ContactPhoneDto, ContactPhoneInfo>().Map(c))
                       .ToList();
                    entity.ContactEmailInfo =
                       model.ContactEmailsView.Select(c =>
                       _entityMapperContextBase.Set<ContactEmailDto, ContactEmailInfo>().Map(c))
                       .ToList();
                    // Update mapped Domain Entity object
                    _context.Set<Point>()
                        .Update(entity);

                    _logger.LogInformation($"UPDATED Customer CONTACT INFO, ID: {model.Id}, user: {User.Identity.Name}");
                    return View(model);
                }
                else
                {
                    _logger.LogWarning($"Customer with ID: {model.Id} NOT FOUND!");
                    ModelState.AddModelError("ClientEdit", $"Клиент с данным id: {model.Id} отсутствует в БД");
                }
            }
            return View(model);
        }

        public IActionResult ClientPaymentDetails(int id)
        {
            _logger.LogInformation($"Getting Customer PAYMENT DETAILS INFO, ID: {id}, user: {User.Identity.Name}");
            try
            {
                _clientPaymentDetailsMapper = _entityMapperContextBase.Set<Point, ClientPaymentDetailsEditViewModel>(cfg =>
                {
                    cfg.CreateMap<Point, ClientPaymentDetailsEditViewModel>()
                    .ForMember(dest => dest.FiscalNumber, opt => opt.MapFrom(src => src.IndNum))
                    .ForMember(dest => dest.Certificate, opt => opt.MapFrom(src => src.SvidNum));
                }
                );
            }
            catch (Exception ex)
            {
                _logger.LogError($"Mapping error: {ex.Message}");
            }

            var model = _context.Set<Point>()
                .FindBy(p => p.PointNumber == id)
                .Select(c => _clientPaymentDetailsMapper.Map(c))
                .FirstOrDefault();

            if (model != null)
            {
                model.Id = id;
                var contractors = _context.Set<Point>()
                    .FindBy(p => p.Post == false)
                    ?.Select(p => new ContractorDto
                    {
                        Id = p.PointNumber,
                        Name = p.NamePoint
                    });
                if (contractors != null)
                {
                    model.Contractors = contractors.ToList();
                }
                return PartialView(model);
            }
            else
            {
                _logger.LogWarning($"Customer with ID: {id} NOT FOUND!");
                return NotFound($"Клиент с id: {id} не найден.");
            }
        }

        [HttpPost]
        public IActionResult ClientPaymentDetails(ClientPaymentDetailsEditViewModel model)
        {
            _logger.LogInformation($"Editing Customer PAYMENT DETAILS INFO, ID: {model.Id}, user: {User.Identity.Name}");
            if (ModelState.IsValid)
            {
                // Get current Domain Entity object
                Point entity = _context.Set<Point>()
                    .FindBy(p => p.PointNumber == model.Id)
                    ?.FirstOrDefault();
                if (entity != null)
                {
                    // Update modified properties
                    entity.BankName = model.BankName;
                    entity.BankAccount = model.BankAccount;
                    entity.Mfo = model.Mfo;
                    entity.Okpo = model.Okpo;
                    entity.SvidNum = model.Certificate;
                    entity.ContractNumber = model.ContractNumber;
                    entity.ContractStartDate = model.ContractStartDate;
                    entity.ContractEndDate = model.ContractEndDate;

                    // Update mapped Domain Entity object
                    _context.Set<Point>()
                        .Update(entity);

                    _logger.LogInformation($"UPDATED Customer PAYMENT DETAILS INFO, ID: {model.Id}, user: {User.Identity.Name}");
                    return View(model);
                }
                else
                {
                    _logger.LogWarning($"Customer with ID: {model.Id} NOT FOUND!");
                    ModelState.AddModelError("ClientEdit", $"Клиент с данным id: {model.Id} отсутствует в БД");
                }
            }
            return View(model);
        }

        public IActionResult ClientDebtDetails(int id)
        {
            _logger.LogInformation($"Getting Customer DEBT DETAILS INFO, ID: {id}, user: {User.Identity.Name}");
            try
            {
                _clientDebtDetailsMapper = _entityMapperContextBase.Set<Point, ClientDebtDetailsEditViewModel>(cfg =>
                {
                    cfg.CreateMap<Point, ClientDebtDetailsEditViewModel>()
                    .ForMember(dest => dest.BillSettings, opt => opt.MapFrom(src => src.BillSettingsInfo))
                    .ForMember(dest => dest.DebtControl, opt => opt.MapFrom(src => src.DebtControlInfo))
                    .ForMember(dest => dest.FranchisingTypeId, opt => opt.MapFrom(src => src.FranchisingInfo.FranchisingTypeId))
                    .ForMember(dest => dest.DebtCalcMethodTypeId, opt => opt.MapFrom(src => src.DebtCalcMethodInfo.DebtCalcMethodTypeId))
                    .ForMember(dest => dest.ClientConnection, opt => opt.MapFrom(src => src.ClientConnectionInfo))
                    .ForMember(dest => dest.BillOptionsAll, opt => opt.MapFrom(src => src.BillOptionsInfo))
                    .ForMember(dest => dest.PrintJobsAll, opt => opt.MapFrom(src => src.PrintJobInfo))
                    .ForMember(dest => dest.BillSettings, opt => opt.Condition(src => src.BillSettingsInfo != null))
                    .ForMember(dest => dest.DebtControl, opt => opt.Condition(src => src.DebtControlInfo != null))
                    .ForMember(dest => dest.FranchisingTypeId, opt => opt.Condition(src => src.FranchisingInfo != null))
                    .ForMember(dest => dest.DebtCalcMethodTypeId, opt => opt.Condition(src => src.DebtCalcMethodInfo != null))
                    .ForMember(dest => dest.ClientConnection, opt => opt.Condition(src => src.ClientConnectionInfo != null))
                    .ForMember(dest => dest.BillOptionsAll, opt => opt.Condition(src => src.BillOptionsInfo != null))
                    .ForMember(dest => dest.PrintJobsAll, opt => opt.Condition(src => src.PrintJobInfo != null))
                    ;
                    cfg.CreateMap<PrintJobInfo, PrintJobDto>();
                    cfg.CreateMap<BillOptionsInfo, BillOptionsDto>();
                });
            }
            catch (Exception ex)
            {
                _logger.LogError($"Mapping error: {ex.Message}");
            }

            var clients = _context.Set<Point>()
                ?.FindBy(p => p.PointNumber == id)
                ?.Include(p=>p.BillSettingsInfo)
                ?.Include(p=>p.BillOptionsInfo)
                ?.Include(p=>p.PrintJobInfo)
                ?.Include(p=>p.DebtControlInfo)
                ?.Include(p=>p.DebtCalcMethodInfo)
                ?.Include(p=>p.FranchisingInfo)
                ?.Include(p=>p.ClientConnectionInfo);
            if (clients?.FirstOrDefault() != null)
            {
                var client = clients.FirstOrDefault();
                var model = _clientDebtDetailsMapper.Map(client);

                model.Id = id;
                // Check all properties for null (i.e not mapped subject to Mapping Condition)
                model.DebtControl = model.DebtControl ?? new DebtControlDto();
                model.BillSettings = model.BillSettings ?? new BillSettingsDto();

                model.ClientConnection = model.ClientConnection ?? new ClientConnectionDto();
                model.BillOptionsAll = model.BillOptionsAll ?? new List<BillOptionsDto>();
                model.PrintJobsAll = model.PrintJobsAll ?? new List<PrintJobDto>();

                // DebtCalc Method Types
                var debtCalcMethodsAll= _context.Set<DebtCalcMethodType>()
                    .GetAll()
                    ?.Select(d => new DebtCalcMethodTypeDto
                    {
                        DebtCalcMethodTypeId = d.DebtCalcMethodTypeId,
                        Name = d.Name
                    })
                    ?.ToList();
                model.DebtCalcMethodsAll = debtCalcMethodsAll??new List<DebtCalcMethodTypeDto>();

                // Add items into PrintJobsAll if its Count < PrintJobsCapacity
                for (int i = 0; i < model.PrintJobsCapacity; i++)
                {
                    if (model.PrintJobsAll.ElementAtOrDefault(i) == null)
                    {
                        model.PrintJobsAll.Add(new PrintJobDto { DocumentToPrintCopies = 0 });
                    }
                    else
                    {
                        model.PrintJobsAll[i].Active = true;
                    }
                }
                // Add items into BillOptionsAll if its Count < BillOptionsCapacity
                for (int i = 0; i < model.BillOptionsCapacity; i++)
                {
                    if (model.BillOptionsAll.ElementAtOrDefault(i) == null)
                    {
                        model.BillOptionsAll.Add(new BillOptionsDto { Limit = 0 });
                    }
                    else
                    {
                        model.BillOptionsAll[i].Active = true;
                    }
                }

                // Franchising Types
                var franchisingTypesAll = _context.Set<FranchisingType>()
                    .GetAll()
                    ?.Select(d => new FranchisingTypeDto
                    {
                        Name=d.Name,
                        FranchisingTypeId=d.FranchisingTypeId
                    })
                    ?.ToList();
                model.FranchisingTypesAll = franchisingTypesAll??new List<FranchisingTypeDto>();

                // Franchising Clients
                if (_context.Set<FranchisingInfo>().GetAll().Count()>0)
                {
                    model.FranchisingClients = _context.Set<Point>()
                        .GetAll()
                        ?.Include(p=>p.FranchisingInfo)
                        ?.Select(d => new FranchisingClientDto
                        {
                            FranchisingClientDtoId = d.FranchisingInfo.PointNumber,
                            Name=d.NamePoint
                        })
                        ?.ToList()
                        ?? model.FranchisingClients;
                }
                // DocumentTemplates
                model.DocumentTemplatesAll = _context.Set<DocumentTemplate>()
                    .GetAll()
                    ?.Select(d => new DocumentTemplateDto
                    {
                        DocumentTemplateId=d.DocumentTemplateId,
                        Name = d.Name
                    })
                    ?.ToList()
                    ?? model.DocumentTemplatesAll;

                //// Check all other properties here.....
                return PartialView(model);
            }
            else
            {
                _logger.LogWarning($"Customer with ID: {id} NOT FOUND!");
                return NotFound($"Клиент с id: {id} не найден.");
            }
        }

        [HttpPost]
        public IActionResult ClientDebtDetails(ClientDebtDetailsEditViewModel model)
        {
            _logger.LogInformation($"Editing Customer DEBT DETAILS INFO, ID: {model.Id}, user: {User.Identity.Name}");
            if (ModelState.IsValid)
            {
                // Get current Domain Entity object
                Point entity = _context.Set<Point>()
                    .FindBy(p => p.PointNumber == model.Id)
                    ?.Include(p=>p.DebtControlInfo)
                    .Include(p=>p.DebtCalcMethodInfo)
                    .Include(p=>p.FranchisingInfo)
                    .Include(p=>p.ClientConnectionInfo)
                    .Include(p=>p.BillSettingsInfo)
                    .Include(p=>p.BillOptionsInfo)
                    .Include(p=>p.PrintJobInfo)
                    ?.FirstOrDefault();
                if (entity != null)
                {
                    // Initialize Nested Properties of Domain Entity if null
                    entity.DebtControlInfo = entity.DebtControlInfo ?? new DebtControlInfo();
                    entity.DebtCalcMethodInfo = entity.DebtCalcMethodInfo ?? new DebtCalcMethodInfo();
                    entity.FranchisingInfo = entity.FranchisingInfo ?? new FranchisingInfo();
                    entity.BillSettingsInfo = entity.BillSettingsInfo ?? new BillSettingsInfo();
                    entity.ClientConnectionInfo = entity.ClientConnectionInfo ?? new ClientConnectionInfo();

                    entity.BillOptionsInfo = entity.BillOptionsInfo?? new List<BillOptionsInfo>();
                    entity.PrintJobInfo = entity.PrintJobInfo?? new List<PrintJobInfo>();

                    // Update modified properties
                    // DebtControlInfo
                    entity.DebtControlInfo.GracePeriod = model.DebtControl.GracePeriod;
                    entity.DebtControlInfo.DebtLimit = model.DebtControl.DebtLimit;
                    entity.DebtControlInfo.NotificationFrequency = model.DebtControl.NotificationFrequency;
                    entity.DebtControlInfo.NotifyByEmail = model.DebtControl.NotifyByEmail;
                    entity.DebtControlInfo.NotifyBySms = model.DebtControl.NotifyBySms;
                    entity.DebtControlInfo.NotifyByViber = model.DebtControl.NotifyByViber;
                    
                    // DebtCalcMethodInfo
                    entity.DebtCalcMethodInfo.DebtCalcMethodTypeId = model.DebtCalcMethodsAll
                        ?.FirstOrDefault(d => d.Active == true)
                        ?.DebtCalcMethodTypeId /*?? default(int)*/;
                    
                    // FranchisingInfo
                    entity.FranchisingInfo.FranchisingTypeId = model.FranchisingTypesAll
                        ?.FirstOrDefault(f => f.Active == true)
                        ?.FranchisingTypeId /*?? default(int)*/;

                    // BillSettingsInfo
                    entity.BillSettingsInfo.AutomaticBilling = model.BillSettings.AutomaticBilling;
                    entity.BillSettingsInfo.SendByEmail = model.BillSettings.SendByEmail;
                    entity.BillSettingsInfo.DocumentTemplateId = model.BillSettings.DocumentTemplateId;
                    entity.BillSettingsInfo.ServicePlaceholderTypeId = model.BillSettings.ServicePlaceholderTypeId;

                    // PrintJobInfo 
                    var modelPrintJobs = model.PrintJobsAll.Where(pj => pj.Active == true);
                    var entityPrintJobs = entity.PrintJobInfo;
                    for (int i=0; i< modelPrintJobs.Count();i++)
                    {
                        if (entityPrintJobs.ElementAtOrDefault(i)==null)
                        {
                            entityPrintJobs.Add(new PrintJobInfo ());
                        }
                        entityPrintJobs.ElementAtOrDefault(i).DocumentToPrintCopies = 
                            modelPrintJobs.ElementAtOrDefault(i).DocumentToPrintCopies;
                        entityPrintJobs.ElementAtOrDefault(i).DocumentTemplateId =
                            modelPrintJobs.ElementAtOrDefault(i).DocumentTemplateId;
                    }

                    // BillOptionsInfo
                    var modelBillOptions = model.BillOptionsAll.Where(bo => bo.Active == true);
                    var entityBillOptions = entity.BillOptionsInfo;
                    for (int i = 0; i < modelBillOptions.Count(); i++)
                    {
                        if (entityBillOptions.ElementAtOrDefault(i) == null)
                        {
                            entityBillOptions.Add(new BillOptionsInfo());
                        }
                        entityBillOptions.ElementAtOrDefault(i).Limit =
                            modelBillOptions.ElementAtOrDefault(i).Limit;
                        entityBillOptions.ElementAtOrDefault(i).DocumentTemplateId =
                            modelBillOptions.ElementAtOrDefault(i).DocumentTemplateId;
                    }

                    // ClientConnectionsInfo
                    entity.ClientConnectionInfo.ServerName = model.ClientConnection.ServerName;
                    entity.ClientConnectionInfo.DatabaseName = model.ClientConnection.DatabaseName;
                    entity.ClientConnectionInfo.Login = model.ClientConnection.Login;
                    entity.ClientConnectionInfo.PasswordHash = model.ClientConnection.PasswordHash;

                    // Update mapped Domain Entity object
                    _context.Set<Point>()
                        .Update(entity);

                    _logger.LogInformation($"UPDATED Customer DEBT DETAILS INFO, ID: {model.Id}, user: {User.Identity.Name}");
                    return View(model);
                }
                else
                {
                    _logger.LogWarning($"Customer with ID: {model.Id} NOT FOUND!");
                    ModelState.AddModelError("ClientEdit", $"Клиент с данным id: {model.Id} отсутствует в БД");
                }
            }
            return View(model);
        }

        public IActionResult ClientProducts(int id)
        {
            _logger.LogInformation($"Getting Customer PRODUCTS, ID: {id}, user: {User.Identity.Name}");
            if (_context.Set<Point>().FindBy(p=>p.PointNumber==id)!=null)
            {
                var model = new ClientProductsEditViewModel();
                model.Id = id;

                var productsAll = _context.Set<Tovar>()
                    ?.FindBy(t => t.KatNumberNavigation.TopKat == 3)
                    ?.Include(t => t.KatNumberNavigation)
                    ?.Select(t => new ProductDto
                    {
                        ProductId = t.TovarNumber,
                        Name = t.TovarName,
                        Active = false
                    });

                var productsClient = _context.Set<ProductClient>()
                    ?.FindBy(pc => pc.PointNumber == model.Id)
                    ?.Select(pc => new ProductDto
                    {
                        ProductId = pc.TovarNumber
                    });

                model.ProductsAll = productsAll?.ToList() ?? model.ProductsAll;
                model.ProductsClient = productsClient?.ToList() ?? model.ProductsClient;

                return PartialView(model);
            }
            else
            {
                _logger.LogWarning($"Customer with ID: {id} NOT FOUND!");
                return NotFound($"Клиент с id: {id} не найден.");
            }
        }

        [HttpPost]
        public IActionResult ClientProducts(ClientProductsEditViewModel model)
        {
            _logger.LogInformation($"Editing Customer PRODUCTS, ID: {model.Id}, user: {User.Identity.Name}");
            if (ModelState.IsValid)
            {
                // Get current Domain Entity object
                Point client = _context.Set<Point>()
                    ?.FindBy(p => p.PointNumber == model.Id)?.FirstOrDefault();
                if (client != null)
                {
                    // Update modified properties
                    using (var transaction = _context.Set<ProductClient>().BeginTransaction())
                    {
                        try
                        {
                            //Delete all existing records in ProductClient database
                            var existingProductClients = _context.Set<ProductClient>()
                                ?.FindBy(pc => pc.PointNumber == model.Id).ToList();
                            if (existingProductClients!=null)
                            {
                                foreach (var productClient in existingProductClients)
                                {
                                    _context.Set<ProductClient>()
                                        .Delete(productClient);
                                }
                            }
                            //Insert new records from posted model
                            var postedProductClients = model.ProductsAll?.Where(p => p.Active == true)?.ToList();
                            if (postedProductClients!=null)
                            {
                                foreach (var product in postedProductClients)
                                {
                                    _context.Set<ProductClient>()
                                        .Add(new ProductClient
                                        {
                                            PointNumber = model.Id,
                                            TovarNumber = product.ProductId
                                        });
                                }
                            }
                            _logger.LogInformation($"UPDATED Customer PRODUCTS, ID: {model.Id}, user: {User.Identity.Name}");
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            _logger.LogError($"ERROR on UPDATING Customer PRODUCTS, ID: {model.Id}, user: {User.Identity.Name}," +
                                $"ERROR: {ex.Message}");
                            transaction.Rollback();
                        }
                    }
                }
                else
                {
                    _logger.LogWarning($"Customer with ID: {model.Id} NOT FOUND!");
                    ModelState.AddModelError("ClientEdit", $"Клиент с данным id: {model.Id} отсутствует в БД");
                }
            }
            return View(model);
        }
    }
}