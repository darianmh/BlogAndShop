using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BlogAndShop.Classes;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Services;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Mapper;

using BlogAndShop.Services.Services.Utilities;
using CommonConfiguration.Core;
using CommonConfiguration.Core.Data.Context;
using CommonConfiguration.Core.Data.Data.User;
using CommonConfiguration.Core.Services.User.Identity;
using CommonConfiguration.Core.Services.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using WebMarkupMin.AspNetCore5;

namespace BlogAndShop
{
    public class Startup : BaseStartup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment) : base(configuration, webHostEnvironment)
        {
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //assembly
            AssemblyHelper.BaseSiteAssembly = Assembly.GetExecutingAssembly();
            var x = services.ToList();
            base.BaseConfigureServices(services);
            var x1 = services.ToList();
            string connectionString;
            if (WebHostEnvironment.IsDevelopment())
            {
                connectionString = Configuration.GetConnectionString("DevelopmentDefaultConnection");
            }
            else
            {
                connectionString = Configuration.GetConnectionString("ProductionDefaultConnection");
            }

            AssemblyHelper.ConnectionString = connectionString;
            AssemblyHelper.MigrationAssembly = "BlogAndShop";
            //add db
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(connectionString, b => b.MigrationsAssembly(AssemblyHelper.MigrationAssembly)));

            //add services
            services.AddServices();

            var x2 = services.ToList();
            //identity account
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                //options.Cookie.Expiration

                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.LoginPath = "/Account/Index";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            //identity
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                })
                .AddRoleStore<ApplicationRoleStore>()
                .AddUserStore<ApplicationUserStore>()
                .AddUserManager<ApplicationUserManager>()
                .AddRoleManager<ApplicationRoleManager>()
                .AddSignInManager<ApplicationSigninManager>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            //identity account
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                //options.Cookie.Expiration

                options.ExpireTimeSpan = TimeSpan.FromHours(1);
                options.LoginPath = "/Account/Index";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            //mapper
            AssemblyHelper.MapperServiceType = typeof(MapperService);


            //routing services (registering LinkConstraint)
            services.Configure<RouteOptions>(routeOptions =>
            {
                routeOptions.ConstraintMap.Add("links", typeof(LinkConstraint));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            base.BaseConfigure(app, env);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error?code={0}");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseStaticFiles(new StaticFileOptions()
            {
                OnPrepareResponse = context =>
                {
                    // add time expires header
                    const int durationInSeconds = (60 * 60 * 24) * 200; // Expires time. I set to 7 days
                    context.Context.Response.Headers["Cache-Control"] =
                        "public,max-age=" + durationInSeconds;
                }
            });




            app.UseEndpoints(endpoints =>
            {   //چک کردن لینک هیی که به صورت خطا ایندکس شده اند
                endpoints.MapControllerRoute(
                    name: "links",
                    constraints: new { links = new LinkConstraint() },
                    pattern: "{*links}",
                    defaults: new { controller = "Home", action = "Rout" });
                ////default
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }



    }
}
