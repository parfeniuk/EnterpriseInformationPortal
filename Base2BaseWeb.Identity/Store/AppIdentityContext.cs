using Base2BaseWeb.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.Identity.Store
{
    public class AppIdentityContext:IdentityDbContext<AppUser,AppRole,Guid>
    {
        public AppIdentityContext(DbContextOptions<AppIdentityContext> options):base(options)
        {
        }
    }
}
