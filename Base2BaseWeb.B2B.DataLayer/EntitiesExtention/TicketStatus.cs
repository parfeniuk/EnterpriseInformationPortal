using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class TicketStatus
    {
        public TicketStatus()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int TicketStatusId { get; set; }
        [Required]
        [StringLength(100)]
        public string TicketStatusName { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
