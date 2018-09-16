using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public Guid UserId { get; set; }

        public int? PointCommunicationTypeId { get; set; }
        public virtual PointCommunicationType PointCommunicationType { get; set; }

        public int? PointContactPersonId { get; set; }
        public virtual PointContactPerson PointContactPerson { get; set; }
    }
}
