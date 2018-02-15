using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.Identity.Models
{
    public class AppUser:IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }

        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
                
        public DateTime CreatedDate { get; private set; }
        public DateTime LastVisitDate { get; private set; }

        public bool UserVerified { get;private set; }
    }
}
