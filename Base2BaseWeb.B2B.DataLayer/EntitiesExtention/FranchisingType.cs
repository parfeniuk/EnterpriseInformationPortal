using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class FranchisingType
    {
        public int FranchisingTypeId { get; set; }
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public ICollection<FranchisingInfo> FranchisingInfo { get; set; }
    }
}
