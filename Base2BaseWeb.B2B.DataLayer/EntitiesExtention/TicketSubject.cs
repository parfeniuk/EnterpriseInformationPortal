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
            Children = new HashSet<TicketSubject>();
        }

        public int TicketSubjectId { get; set; }
        [Required]
        [StringLength(255)]
        public string TicketSubjectName { get; set; }

        public int? ParentId { get; set; }

        public virtual TicketSubject Parent { get; set; }
        public virtual ICollection<TicketSubject> Children { get; set; }
        
        public virtual ICollection<Ticket> Tickets { get; set; }

        public IEnumerable<TicketSubject> AllSubcategories()
        {
            yield return this;
            foreach (var directChild in Children)
                foreach (var subChild in directChild.AllSubcategories())
                {
                    yield return subChild;
                }
        }
    }
}
