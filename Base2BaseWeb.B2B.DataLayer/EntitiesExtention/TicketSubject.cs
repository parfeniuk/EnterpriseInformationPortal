using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class TicketSubject
    {
        public TicketSubject()
        {
            Tickets = new HashSet<Ticket>();
        }

        public int TicketSubjectId { get; set; }
        [Required]
        [StringLength(100)]
        public string TicketSubjectName { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
