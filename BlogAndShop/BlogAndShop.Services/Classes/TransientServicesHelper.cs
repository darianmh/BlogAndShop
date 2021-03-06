using System.Linq;
using System.Reflection;
using BlogAndShop.Data.Context;
using BlogAndShop.Services.Services.Common.Search;
using BlogAndShop.Services.Services.Common.SenderServices;
using BlogAndShop.Services.Services.User.Identity;
using BlogAndShop.Services.Services.Utilities;
using BlogAndShop.Services.Services.Utilities.File;
using BlogAndShop.Services.Services.Utilities.SiteMap;
using Microsoft.Extensions.DependencyInjection;

namespace BlogAndShop.Services.Classes
{
    public static class TransientServicesHelper
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            //sign in
            //services.AddTransient<ApplicationUserManager>();
            //services.AddTransient<ApplicationSignInManager>();

            //db
            services.AddTransient<ApplicationDbContext>();
            //services

            var allTypes = assembly.GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract).ToList();
            var interfaces = assembly.GetTypes()
                .Where(myType => myType.IsInterface).ToList();
            foreach (var type in interfaces)
            {
                var typesToRegister = allTypes.Where(z => type.IsAssignableFrom(z)).ToList();
                var typeToRegister = typesToRegister.FirstOrDefault();
                if (typeToRegister != null) services.AddTransient(type, typeToRegister);
            }


            //file
            services.AddTransient<IFileHelperService, FileHelperService>();


            //identity
            services.AddTransient<ApplicationUserManager>();
            services.AddTransient<ApplicationUserStore>();
            services.AddTransient<ApplicationRoleManager>();
            services.AddTransient<ApplicationRoleStore>();
            services.AddTransient<ApplicationSigninManager>();

            //other
            services.AddTransient<ISendService, SendService>();
            services.AddTransient<ISiteMapService, SiteMapService>();
            services.AddTransient<ISearchService, SearchService>();



            return services;
        }
    }
}
