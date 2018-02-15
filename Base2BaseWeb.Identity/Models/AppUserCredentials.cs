using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.Identity.Models
{
    public class AppUserCredentials
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
