using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.UI.Areas.Company.Models.SupportViewModel
{
    public class SupportIndexViewModel
    {
        public SupportIndexViewModel()
        {
            Tickets = new HashSet<TicketDto>();
        }
        public IEnumerable<TicketDto> Tickets { get; set; }
        public string SearchString { get; set; }
    }
}
