using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BlogAndShop.Classes
{
    public class AdminFilterNameAttribute : AuthorizeAttribute, IAsyncAuthorizationFilter
    {
        public string Name { get; }
        public string Group { get; }
        public AdminFilterNameAttribute(string group, string name)
        {
            Name = name;
            Group = group;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            if (user.Identity != null && !user.Identity.IsAuthenticated)
            {
                var url = new
                {
                    ReturnUrl = $"{context.HttpContext.Request.GetDisplayUrl()}"
                };
                context.Result = new RedirectToActionResult("Login", "Account", url);
                return;
            }

            // you can also use registered services
            //var someService = context.HttpContext.RequestServices.GetService<iuseo>();


            //context.Result = new StatusCodeResult((int)System.Net.HttpStatusCode.Forbidden);
            return;
        }
    }
}