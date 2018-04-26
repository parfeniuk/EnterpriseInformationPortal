using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateFinished { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }

        public int? TicketSubjectId { get; set; }
        public virtual TicketSubject TicketSubject { get; set; }

        public int? TicketStatusId { get; set; }
        public virtual TicketStatus TicketStatus { get; set; }

    }
}
