using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class PointContactPersonPositionType
    {
        public PointContactPersonPositionType()
        {
            PointContactPeople = new HashSet<PointContactPerson>();
        }

        public int PointContactPersonPositionTypeId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public virtual ICollection<PointContactPerson> PointContactPeople { get; set; }
    }
}
