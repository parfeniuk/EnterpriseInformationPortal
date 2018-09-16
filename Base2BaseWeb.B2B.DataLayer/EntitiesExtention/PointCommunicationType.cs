using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class PointCommunicationType
    {
        public PointCommunicationType()
        {
            Tickets = new HashSet<Ticket>();
        }
        public int PointCommunicationTypeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
