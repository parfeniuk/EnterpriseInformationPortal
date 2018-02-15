using Base2BaseWeb.Identity.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base2BaseWeb.Identity.Store
{
    public static class DbInitializer
    {
        public static void Initialize(AppIdentityContext context, 
            UserManager<AppUser> userManager, RoleManager<AppRole> roleManager,
            AppUserCredentials userCredentials)
        {
            // Ensure DB creation if it wasn't
            context.Database.EnsureCreated();
            // Check if DB had been already seeded before
            if (context.Users.Any()||context.Roles.Any())
            {
                return; 
            }
            // Create initial Administrators Role
            if (!roleManager.RoleExistsAsync(userCredentials.Role).Result)
            {
                roleManager.CreateAsync(new AppRole { Name = userCredentials.Role });
            }
            // Create initial Admin User
            if (userManager.FindByNameAsync(userCredentials.Name).Result == null)
            {
                AppUser appUser = new AppUser
                {
                    UserName=userCredentials.Name,
                    Email=userCredentials.Email
                };
                IdentityResult result = userManager.CreateAsync(appUser, userCredentials.Password).Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(appUser, userCredentials.Role);
                }
            }
        }
    }
}
