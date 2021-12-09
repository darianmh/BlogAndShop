using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Services;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.User.Identity;
using BlogAndShop.Services.Services.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        {
            Configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
        }

        public IConfiguration Configuration { get; }
        private IWebHostEnvironment _webHostEnvironment;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            string connectionString;
            if (_webHostEnvironment.IsDevelopment())
            {
                connectionString = Configuration.GetConnectionString("DevelopmentDefaultConnection");
            }
            else
            {
                connectionString = Configuration.GetConnectionString("ProductionDefaultConnection");
            }

            //add db
            services.AddDbContext<ApplicationDbContext>(opt =>
                opt.UseSqlServer(connectionString, b => b.MigrationsAssembly("BlogAndShop")));

            //add services
            services.AddServices();

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

                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/Account/Index";
                options.LogoutPath = "/Account/Logout";
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
                //options.ReturnUrlParameter=""
            });

            //assembly
            AssemblyHelper.BaseSiteAssembly = Assembly.GetExecutingAssembly();

            //admin controllers
            AdminPanelService.GetAllController(AssemblyHelper.BaseSiteAssembly);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //if (env.IsDevelopment())
            //{
            app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Home/Error");
            //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //    app.UseHsts();
            //}
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
