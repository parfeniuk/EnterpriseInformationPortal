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

        public string CompanyName { get; set; }

        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string AddressLine { get; set; }
                
        public DateTime CreatedDate { get;  set; }
        public DateTime LastVisitDate { get;  set; }

        public bool UserVerified { get; set; }
    }
}
