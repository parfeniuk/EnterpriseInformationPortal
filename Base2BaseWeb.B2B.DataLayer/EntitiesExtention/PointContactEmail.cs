using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class PointContactEmail
    {
        public int PointContactEmailId { get; set; }

        public int? PointContactPersonId { get; set; }
        public virtual PointContactPerson PointContactPerson { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }
    }
}
