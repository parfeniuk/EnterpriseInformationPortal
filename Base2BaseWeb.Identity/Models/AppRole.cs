using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.Identity.Models
{
    public class AppRole:IdentityRole<Guid>
    {
        public AppRole() { }
        public AppRole(string name) : base(name) { }
    }
}
