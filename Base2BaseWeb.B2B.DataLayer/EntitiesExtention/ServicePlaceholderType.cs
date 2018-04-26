using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class ServicePlaceholderType
    {
        public int ServicePlaceholderTypeId { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual BillSettingsInfo BillSettingsInfo { get; set; }
    }
}
