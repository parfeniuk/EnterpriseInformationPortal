using Base2BaseWeb.UI.Areas.Company.DTO.Tickets;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.SupportViewModel
{
    public class TicketCreateViewModel
    {
        public TicketCreateViewModel()
        {
            TicketCreateDto = new TicketCreateDto();
            Groups = new List<GroupDto>();
            Clients = new List<ClientDto>();
            Branches = new List<BranchDto>();
            PointCommunicationTypes = new List<PointCommunicationTypeDto>();
            PointContactPhones = new List<PointContactPhoneDto>();
            TicketSubjectParents = new List<TicketSubjectDto>();
            TicketSubjectFirstChildren = new List<TicketSubjectDto>();
            TicketSubjectLastChildren = new List<TicketSubjectOptionDto>();
        }
        public TicketCreateDto TicketCreateDto { get; set; }
        // Collections for SelectLists
        public List<GroupDto> Groups { get; set; }
        public List<ClientDto> Clients { get; set; }
        public List<BranchDto> Branches { get; set; }
        public List<PointCommunicationTypeDto> PointCommunicationTypes { get; set; }
        public List<PointContactPhoneDto> PointContactPhones { get; set; }
        public List<TicketSubjectDto> TicketSubjectParents { get; set; }
        public List<TicketSubjectDto> TicketSubjectFirstChildren { get; set; }
        // Collections for CheckLists
        public List<TicketSubjectOptionDto> TicketSubjectLastChildren { get; set; }
        //[Display(Name ="Клиенты")]
        //public int ClientId { get; set; }
    }
}
