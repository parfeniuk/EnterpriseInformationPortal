using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class PointContactPhone
    {
        public int PointContactPhoneId { get; set; }

        public int? PointContactPersonId { get; set; }
        public virtual PointContactPerson PointContactPerson { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }
    }
}
