using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base2BaseWeb.B2B.DataLayer.Entities;
using Base2BaseWeb.UI.Areas.Company.DTO.Tickets;
using Base2BaseWeb.UI.Areas.Company.Models.SupportViewModel;
using Base2BaseWeb.UI.BaseControllers;
using EntityMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryGeneric;

namespace Base2BaseWeb.UI.Areas.Company.Controllers
{
    [Area("Company")]
    [Authorize(Roles = "Admin")]
    public class SupportController : BaseController
    {
        private IEntityMapperContextBase _entityMapperContextBase;
        private IEntityMapperBase<Point, ClientDto> _clientMapper;

        public SupportController(IRepositoryContextBase context, IEntityMapperContextBase entityMapperContextBase)
            : base(context)
        {
            _entityMapperContextBase = entityMapperContextBase;
        }

        public IActionResult Index(string searchString = "")
        {
            IEnumerable<TicketIndexDto> tickets;
            SupportIndexViewModel model = new SupportIndexViewModel();
            //model.SearchString = searchString;

            if (!string.IsNullOrEmpty(searchString))
            {
                model.SearchString = string.Concat(searchString.ToCharArray().Where(c => !Char.IsWhiteSpace(c)));

                tickets = _context.Set<Ticket>()
                .GetAll()
                .Include(t => t.Point)
                .Include(t => t.TicketSubject)
                .Include(t => t.TicketStatus)
                ?.Where(t => t.Point.NamePoint.ToLower().Contains(model.SearchString.ToLower()))
                ?.Select(ticket => new TicketIndexDto
                {
                    ClientName = ticket.Point.NamePoint,
                    TicketStatusName = ticket.TicketStatus.TicketStatusName,
                    TicketSubjectName = ticket.TicketSubject.TicketSubjectName,
                    DateCreated = ticket.DateCreated,
                    DateFinished = ticket.DateFinished,
                    TimeElapsed = ticket.DateFinished.Value.Subtract(ticket.DateCreated.Value).Minutes
                })
                .OrderBy(t => t.DateCreated)
                .ThenBy(t => t.ClientName);
                model.Tickets = tickets;
            }
            else
            {
                tickets = _context.Set<Ticket>()
                    .GetAll()
                    .Include(t => t.Point)
                    .Include(t => t.TicketSubject)
                    .Include(t => t.TicketStatus)
                    ?.Select(ticket => new TicketIndexDto
                    {
                        ClientName = ticket.Point.NamePoint,
                        TicketStatusName = ticket.TicketStatus.TicketStatusName,
                        TicketSubjectName = ticket.TicketSubject.TicketSubjectName,
                        DateCreated = ticket.DateCreated,
                        DateFinished = ticket.DateFinished,
                        TimeElapsed = ticket.DateFinished.Value.Subtract(ticket.DateCreated.Value).Minutes
                    })
                    .OrderBy(t => t.DateCreated)
                    .ThenBy(t => t.ClientName);
                model.Tickets = tickets;
            }
            return View(model);
        }

        public IActionResult ClientsList(string searchString)
        {
            IEnumerable<TicketIndexDto> tickets;
            SupportIndexViewModel model = new SupportIndexViewModel();

            if (!string.IsNullOrEmpty(searchString))
            {
                model.SearchString = string.Concat(searchString.ToCharArray().Where(c => !Char.IsWhiteSpace(c)));

                tickets = _context.Set<Ticket>()
                .GetAll()
                .Include(t => t.Point)
                .Include(t => t.TicketSubject)
                .Include(t => t.TicketStatus)
                ?.Where(t => t.Point.NamePoint
                .ToLower()
                .Contains(model.SearchString.ToLower()))
                ?.Select(ticket => new TicketIndexDto
                {
                    ClientName = ticket.Point.NamePoint,
                    TicketStatusName = ticket.TicketStatus.TicketStatusName,
                    TicketSubjectName = ticket.TicketSubject.TicketSubjectName,
                    DateCreated = ticket.DateCreated,
                    DateFinished = ticket.DateFinished,
                    TimeElapsed = ticket.DateFinished.Value.Subtract(ticket.DateCreated.Value).Minutes
                })
                .OrderBy(t => t.DateCreated)
                .ThenBy(t => t.ClientName);
                model.Tickets = tickets;
            }
            else
            {
                tickets = _context.Set<Ticket>()
                    .GetAll()
                    .Include(t => t.Point)
                    .Include(t => t.TicketSubject)
                    .Include(t => t.TicketStatus)
                    ?.Select(ticket => new TicketIndexDto
                    {
                        ClientName = ticket.Point.NamePoint,
                        TicketStatusName = ticket.TicketStatus.TicketStatusName,
                        TicketSubjectName = ticket.TicketSubject.TicketSubjectName,
                        DateCreated = ticket.DateCreated,
                        DateFinished = ticket.DateFinished,
                        TimeElapsed = ticket.DateFinished.Value.Subtract(ticket.DateCreated.Value).Minutes
                    })
                    .OrderBy(t => t.DateCreated)
                    .ThenBy(t => t.ClientName);
                model.Tickets = tickets;
            }
            return PartialView(model);
        }

        public IActionResult CreateTicket()
        {
            _clientMapper = _entityMapperContextBase.Set<Point, ClientDto>(cfg =>
            {
                cfg.CreateMap<Point, ClientDto>()
                .ForMember(dest => dest.ClientId, opt => opt.MapFrom(src => src.PointNumber))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.NamePoint));
            });
            var clients = _context.Set<Point>()
                ?.FindBy(p => p.CliGroupNumber == 7 || p.CliGroupNumber == 2)
                ?.Include(c => c.CliGroup)
                ?.OrderBy(c => c.NamePoint)
                ?.Select(enity => _clientMapper.Map(enity));
            if (clients != null)
            {
                TicketCreateViewModel model = new TicketCreateViewModel();
                // Clients
                model.Clients = clients.ToList();
                // Communication types
                var communicationTypes = _context.Set<PointCommunicationType>()
                    ?.GetAll()
                    ?.Select(pct => new PointCommunicationTypeDto
                    {
                        PointCommunicationTypeId = pct.PointCommunicationTypeId,
                        Name = pct.Name
                    });
                model.PointCommunicationTypes = communicationTypes?.ToList() ?? model.PointCommunicationTypes;
                //додавання типу заявок (категорія)
                IQueryable<TicketSubjectDto> subjectsParents = _context.Set<TicketSubject>()
                    ?.GetAll()
                    ?.Where(t => t.ParentId == null)
                    ?.Select(t => new TicketSubjectDto
                    {
                        Name = t.TicketSubjectName,
                        TicketSubjectId = t.TicketSubjectId
                    });
                //підкатегорія (тема)
                //IQueryable<TicketSubjectDto> subjectFirstChildren = _context.Set<TicketSubject>()
                //    ?.GetAll()
                //    ?.Where(t => t.ParentId != null)
                //    ?.Select(t => new TicketSubjectDto
                //    {
                //        Name = t.TicketSubjectName,
                //        TicketSubjectId = t.TicketSubjectId
                //    });

                //model.TicketSubjectFirstChildren = subjectFirstChildren?.ToList() ?? model.TicketSubjectFirstChildren;
                model.TicketSubjectParents = subjectsParents?.ToList() ?? model.TicketSubjectParents;


                //TMP!
                model.TicketSubjectLastChildren = _context.Set<TicketSubject>()
                    ?.GetAll()
                    ?.Where(i => i.ParentId == 16)
                    ?.Select(s => new TicketSubjectOptionDto
                    {
                        Active = false,
                        Name = s.TicketSubjectName,
                        TicketSubjectId = s.TicketSubjectId
                    }).ToList();
                //END TMP

                return View(model);
            }
            return NotFound("Ticket Subjects are not found!");
        }

        [HttpPost]
        public IActionResult CreateTicket(TicketCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                ///
                ///
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        public IActionResult GetBranchesById(int id)
        {
            int? groupId = _context.Set<CliGroup>()
                ?.FindBy(g => g.PointNumber == id)
                ?.Select(g => g.CliGroupNumber)
                ?.FirstOrDefault();
            if (groupId != null)
            {
                var branches = _context.Set<Point>()
                    ?.FindBy(p => p.CliGroupNumber == groupId && p.ChildId > 0)
                    ?.Select(p => new BranchDto
                    {
                        BranchId = p.PointNumber,
                        Name = p.NamePoint
                    });
                if (branches != null)
                {
                    return Json(branches.ToList());
                }
                else
                {
                    return NotFound("Branches are not found!");
                }
            }
            else
            {
                return NotFound("Branches are not found!");
            }
        }

        public IActionResult GetPhonesById(int? id)
        {
            if (id != null)
            {
                //int personId = _context.Set<PointContactPerson>()
                //    .FindBy(person => person.PointNumber == id)
                //    .Select(p => p.PointContactPersonId)
                //    .FirstOrDefault();
                // Phones List
                var phones = _context.Set<PointContactPhone>()
                    ?.GetAll()
                    ?.Include(phone => phone.PointContactPerson)
                    ?.Where(p => p.PointContactPerson.PointNumber == id)
                    ?.Select(p => new PointContactPhoneDto
                    {
                        PointContactPhoneId = p.PointContactPhoneId,
                        Phone = p.Phone
                    });
                if (phones != null)
                {
                    return Json(phones.ToList());
                }
                else
                {
                    return NotFound("Phones are not found!");
                }
            }
            else
            {
                return NotFound("Phones are not found!");
            }
        }

        public IActionResult GetSubCategoryById(int? id)
        {
            if (id == null)
                return NotFound("SubCategories are not found!");

            List<TicketSubjectDto> SubCategories = _context.Set<TicketSubject>()
                   ?.GetAll()
                   ?.Where(t => t.ParentId == id)
                   ?.Select(t => new TicketSubjectDto
                   {
                       Name = t.TicketSubjectName,
                       TicketSubjectId = t.TicketSubjectId
                   })?.ToList();

            if (SubCategories.Count == 0)
                return NotFound("SubCategories are not found!");

            ///TMP!!
          // var test = GetSubjectTree(id);
            ///end TMP



            return Json(SubCategories);
        }

        public IActionResult GetSubjectTree(int? id)
        {
            if (id == null)
                return NotFound("Parrent category are not found!");


            SubjectTreeDto model = RecursionTree(id);

            if (model == null)
            {
                return NotFound("Parrent category are not found!");
            }

            JsonResult TMP = Json(model);
            JsonResult tmp2 = TMP;
            List<SubjectTreeDto> modelList = new List<SubjectTreeDto> { model };

            return Json(modelList);
        }
        private SubjectTreeDto RecursionTree(int? id)
        {            
            TicketSubject rootE = _context.Set<TicketSubject>()?.Find(id);

            if (rootE == null)
                return null;

            SubjectTreeDto root = new SubjectTreeDto
            { ParentId = rootE.ParentId, Text = rootE.TicketSubjectName };

            List<int> children =
            _context.Set<TicketSubject>()
               ?.GetAll()
               ?.Where(t => t.ParentId == id)
               ?.Select(s=> s.TicketSubjectId)
               ?.ToList();

            if (children.Count() > 0)
                for (int i = 0; i < children.Count(); i++)
                {
                    root.nodes.Add(RecursionTree(children.ElementAtOrDefault(i)));
                }
            else
                root.nodes = null;



            return root;
        }
    }
}

