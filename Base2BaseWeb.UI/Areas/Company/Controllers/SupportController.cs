using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Base2BaseWeb.B2B.DataLayer.Entities;
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

        public SupportController(IRepositoryContextBase context, IEntityMapperContextBase entityMapperContextBase)
            : base(context)
        {
            _entityMapperContextBase = entityMapperContextBase;
        }

        public IActionResult Index(string searchString = "")
        {
            IEnumerable<TicketDto> tickets;
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
                ?.Select(ticket => new TicketDto
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
                    ?.Select(ticket => new TicketDto
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
            IEnumerable<TicketDto> tickets;
            SupportIndexViewModel model = new SupportIndexViewModel();
            

            if (!string.IsNullOrEmpty(searchString))
            {
                model.SearchString = string.Concat(searchString.ToCharArray().Where(c=>!Char.IsWhiteSpace(c)));

                tickets = _context.Set<Ticket>()
                .GetAll()
                .Include(t => t.Point)
                .Include(t => t.TicketSubject)
                .Include(t => t.TicketStatus)
                ?.Where(t => t.Point.NamePoint
                .ToLower()
                .Contains(model.SearchString.ToLower()))
                ?.Select(ticket => new TicketDto
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
                    ?.Select(ticket => new TicketDto
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
    }
}