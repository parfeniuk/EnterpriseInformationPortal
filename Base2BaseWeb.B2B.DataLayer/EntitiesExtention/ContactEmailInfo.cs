using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class ContactEmailInfo
    {
        public int ContactEmailInfoId { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        public bool IncludeToMailList { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
