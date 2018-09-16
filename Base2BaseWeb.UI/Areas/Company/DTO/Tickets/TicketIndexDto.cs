using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.SupportViewModel
{
    public class TicketIndexDto
    {
        public int TicketId { get; set; }
        public string ClientName { get; set; }
        public string TicketSubjectName { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateFinished { get; set; }
        public int TimeElapsed { get; set; }
        public string TicketStatusName { get; set; }
    }
}
