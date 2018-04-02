using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using Base2BaseWeb.B2B.DataLayer.Entities;
using Base2BaseWeb.B2B.DataLayer.Repository;
using Base2BaseWeb.DataLayer.Entities;
using Base2BaseWeb.DataLayer.Repository;
using Base2BaseWeb.Identity.Models;
using Base2BaseWeb.Identity.Services;
using Base2BaseWeb.Identity.Store;
using Base2BaseWeb.UI.Areas.Company.Models.ClientsViewModel;
using Base2BaseWeb.UI.EntityMappers.CompanyArea;
using Base2BaseWeb.UI.Helpers;
using Base2BaseWeb.UI.Services;
using EntityMapper;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.WebEncoders;
using RepositoryGeneric;

namespace Base2BaseWeb.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //  Add reference to AppIdentityContext in a different Assembly (Base2BaseWeb.Identity)
            services.AddDbContext<AppIdentityContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("Base2BaseWeb.Identity")));

            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<AppIdentityContext>()
                .AddDefaultTokenProviders();

            // Add reference to Base2BaseWebContext in a different Assembly (Base2BaseWeb.DataLayer)
            services.AddDbContext<Base2BaseWebContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Base2BaseWebConnection"),
                b => b.MigrationsAssembly("Base2BaseWeb.DataLayer")));
            services.AddScoped<DbContext, Base2BaseWebContext>();

            // Add reference to b2b_testContext in a different Assembly (Base2BaseWeb.B2B.DataLayer)
            services.AddDbContext<b2b_testContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("B2BTest"),
                b => b.MigrationsAssembly("Base2BaseWeb.B2B.DataLayer")));
            services.AddScoped<DbContext, b2b_testContext>();

            // Add RepositoryContext for base2base DB (site)
            services.AddTransient<IRepositoryContextBase, RepositoryContext>();
            // Add RepositoryContext for b2b DB (clients)
            services.AddTransient<IRepositoryContextBase, B2BRepositoryContext>();
            // Add EntityMapperContext
            services.AddTransient<IEntityMapperContextBase, EntityMapperContextBase>();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 6;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // Signin settings
                options.SignIn.RequireConfirmedEmail = true;
                options.SignIn.RequireConfirmedPhoneNumber = false;

                // User settings
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.Name = "Base2Base.Cookies";
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromMinutes(60);
                options.LoginPath = "/Account/Login"; // If the LoginPath is not set here, ASP.NET Core will default to /Account/Login
                options.LogoutPath = "/Account/Logout"; // If the LogoutPath is not set here, ASP.NET Core will default to /Account/Logout
                options.AccessDeniedPath = "/Account/AccessDenied"; // If the AccessDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenied
                options.SlidingExpiration = true;
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
            });

            // Encode all characters to Unicode
            services.Configure<WebEncoderOptions>(options =>
            {
                options.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });

            services.AddMvc();
            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IHierarchyNavigate, HierarchyNavigate>();
            //services.AddTransient<IEntityMapperBase<Point,ClientsIndexViewModel>, ClientMapper>();

            // Add FilesHelper
            services.AddTransient<IFilesHelper, FilesHelper>();
            // Options Accessors
            services.AddOptions();
            services.Configure<AuthMessageSenderOptions>(Configuration.GetSection("Base2BaseServer"));
            services.Configure<ImageSettings>(Configuration.GetSection("ImageSettings"));
            services.Configure<AdminSettings>(Configuration.GetSection("AdminSettings"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            AppIdentityContext identityContext, Base2BaseWebContext base2BaseWebContext, b2b_testContext b2B_TestContext,
            UserManager<AppUser> userManager, RoleManager<AppRole> roleManager,IOptions<AdminSettings> options)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();

                //app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            // Apply migrations
            AppIdentityContextInitializer.Initialize(identityContext,userManager,roleManager,options);
            Base2BaseWebContextInitializer.Initialize(base2BaseWebContext);
            b2b_testContextInitializer.BypassInitialMigration(b2B_TestContext);

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
