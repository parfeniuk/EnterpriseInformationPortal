using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class PointContactPerson
    {
        public PointContactPerson()
        {
            Tickets = new HashSet<Ticket>();
            PointContactPhones=new HashSet<PointContactPhone>();
            PointContactEmails = new HashSet<PointContactEmail>();
        }

        public int PointContactPersonId { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }
        [StringLength(100)]
        public string MiddleName { get; set; }
        [StringLength(100)]
        public string LastName { get; set; }
        
        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }

        public int? PointContactPersonPositionTypeId { get; set; }
        public virtual PointContactPersonPositionType PointContactPersonPositionType { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<PointContactPhone> PointContactPhones { get; set; }
        public virtual ICollection<PointContactEmail> PointContactEmails { get; set; }
    }
}
