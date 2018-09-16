using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public partial class ContactPhoneInfo
    {
        public int ContactPhoneInfoId { get; set; }
        [StringLength(200)]
        public string ContactFullName { get; set; }
        [StringLength(50)]
        public string PhoneNumber { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}