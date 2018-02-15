using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using Base2BaseWeb.Identity.Store;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.Identity.Store
{
    public class AppIdentityContextFactory : IDesignTimeDbContextFactory<AppIdentityContext>
    {
        public AppIdentityContext CreateDbContext(string[] args)
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            return new AppIdentityContext(
                new DbContextOptionsBuilder<AppIdentityContext>()
                .UseSqlServer(configBuilder.GetConnectionString("DefaultConnection"))
                .Options);
        }
    }
}
