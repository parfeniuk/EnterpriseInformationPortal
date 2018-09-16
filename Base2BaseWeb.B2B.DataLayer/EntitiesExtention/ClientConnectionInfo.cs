using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Entities
{
    public class ClientConnectionInfo
    {
        public int ClientConnectionInfoId { get; set; }
        [StringLength(100)]
        public string ServerName { get; set; }
        [StringLength(100)]
        public string DatabaseName { get; set; }
        [StringLength(50)]
        public string Login { get; set; }
        [StringLength(100)]
        public string PasswordHash { get; set; }

        public int? PointNumber { get; set; }
        public virtual Point Point { get; set; }
    }
}
