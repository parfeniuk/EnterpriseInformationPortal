using Base2BaseWeb.Identity.Models;
using Base2BaseWeb.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base2BaseWeb.Identity.Store
{
    public static class AppIdentityContextInitializer
    {
        public static void Initialize(AppIdentityContext context, UserManager<AppUser> usermgr, RoleManager<AppRole> rolemgr,
            IOptions<AdminSettings> optionsAccessor)
        {
            context.Database.Migrate();
            if (context.Users.Any() || context.Roles.Any())
            {
                return;   // DB has been seeded
            }

            // Create Admin Role if not exists
            if (!rolemgr.RoleExistsAsync("Admin").Result)
            {
                var role1 = new AppRole { Name = "Admin" };
                IdentityResult roleResult = rolemgr.CreateAsync(role1).Result;
            }
            // Add User to Admin Role
            if (usermgr.FindByNameAsync(optionsAccessor.Value.UserName).Result == null)
            {
                var user1 = new AppUser
                {
                    UserName = optionsAccessor.Value.UserName,
                    Email = optionsAccessor.Value.Email,
                    EmailConfirmed = optionsAccessor.Value.EmailConfirmed,
                    PhoneNumber = optionsAccessor.Value.PhoneNumber,
                    PhoneNumberConfirmed = optionsAccessor.Value.PhoneNumberConfirmed
                };

                IdentityResult result = usermgr.CreateAsync(user1, optionsAccessor.Value.Password).Result;

                if (result.Succeeded)
                {
                    usermgr.AddToRoleAsync(user1,"Admin").Wait();
                }
            }
        }
    }
}
