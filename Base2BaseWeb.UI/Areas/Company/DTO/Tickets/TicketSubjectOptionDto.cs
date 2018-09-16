using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.DTO.Tickets
{
    public class TicketSubjectOptionDto
    {
        public int TicketSubjectId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
