using System.Reflection;
using BlogAndShop.Data.Context;
using BlogAndShop.Services.Services.Common.Search;
using BlogAndShop.Services.Services.Common.SenderServices;
using BlogAndShop.Services.Services.Utilities.SiteMap;
using CommonConfiguration.Core.Data.Context;
using CommonConfiguration.Core.Services.Classes;
using Microsoft.Extensions.DependencyInjection;

namespace BlogAndShop.Services.Classes
{
    public static class TransientServicesHelper
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<BaseApplicationDbContext, ApplicationDbContext>();
            services.AddTransient<ApplicationDbContext, ApplicationDbContext>();

            //services
            BaseTransientServicesHelper.AddServices(Assembly.GetExecutingAssembly(), ref services);


            //other
            services.AddTransient<ISendService, SendService>();
            services.AddTransient<ISiteMapService, SiteMapService>();
            services.AddTransient<ISearchService, SearchService>();



            return services;
        }
    }
}
