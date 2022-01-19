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
using BlogAndShop.Services.Services.User.Identity;
using BlogAndShop.Services.Services.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using WebMarkupMin.AspNetCore5;

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
            //compression
            // Configure Compression level
            services.Configure<GzipCompressionProviderOptions>(options => options.Level = CompressionLevel.Optimal);
            services.AddResponseCompression(options =>
            {
                //options.Providers.Add<BrotliCompressionProvider>();
                options.Providers.Add<GzipCompressionProvider>();
                options.EnableForHttps = true;
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(CommonMimeTypes);
            });
            services.AddResponseCaching(options =>
            {
                options.UseCaseSensitivePaths = true;
            });

            services.AddControllersWithViews();


            services.AddWebMarkupMin(
                    options =>
                    {
                        options.AllowMinificationInDevelopmentEnvironment = true;
                        options.AllowCompressionInDevelopmentEnvironment = true;
                    })
                .AddHtmlMinification(
                    options =>
                    {
                        options.MinificationSettings.RemoveRedundantAttributes = true;
                        options.MinificationSettings.RemoveHttpProtocolFromAttributes = true;
                        options.MinificationSettings.RemoveHttpsProtocolFromAttributes = true;
                    })
                .AddHttpCompression();

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


            //routing services (registering LinkConstraint)
            services.Configure<RouteOptions>(routeOptions =>
            {
                routeOptions.ConstraintMap.Add("links", typeof(LinkConstraint));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseResponseCompression();
            app.UseResponseCaching();
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
            app.UseHttpsRedirection();
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
            app.UseWebMarkupMin();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();





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



        public static readonly IEnumerable<string> CommonMimeTypes = new[]
    {
        "application/javascript",
        "application/json",
        "application/ld+json",
        "application/msword",
        "application/octet-stream",
        "application/ogg",
        "application/pdf",
        "application/rtf",
        "application/vnd.apple.installer+xml",
        "application/vnd.mozilla.xul+xml",
        "application/vnd.ms-excel",
        "application/vnd.ms-fontobject",
        "application/vnd.ms-powerpoint",
        "application/vnd.oasis.opendocument.presentation",
        "application/vnd.oasis.opendocument.spreadsheet",
        "application/vnd.oasis.opendocument.text",
        "application/vnd.openxmlformats-officedocument.presentationml.presentation",
        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
        "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
        "application/vnd.visio",
        "application/x-csh",
        "application/x-sh",
        "application/x-shockwave-flash",
        "application/xhtml+xml",
        "application/xml",
        "audio/3gpp",
        "audio/3gpp2",
        "audio/aac",
        "audio/midi",
        "audio/x-midi",
        "audio/mpeg",
        "audio/ogg",
        "audio/opus",
        "audio/wav",
        "audio/webm",
        "font/otf",
        "font/ttf",
        "font/woff",
        "font/woff2",
        "image/bmp",
        "image/gif",
        "image/jpeg",
        "image/png",
        "image/svg+xml",
        "image/tiff",
        "image/vnd.microsoft.icon",
        "image/webp",
        "text/calendar",
        "text/css",
        "text/csv",
        "text/html",
        "text/javascript",
        "text/json",
        "text/plain",
        "text/xml",
        "video/3gpp",
        "video/3gpp2",
        "video/mp2t",
        "video/mpeg",
        "video/ogg",
        "video/webm",
        "video/x-msvideo",
    };
    }
}
