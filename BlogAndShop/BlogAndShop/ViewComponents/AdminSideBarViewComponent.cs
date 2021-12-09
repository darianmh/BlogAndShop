using System.Reflection;
using System.Threading.Tasks;
using BlogAndShop.Services;
using BlogAndShop.Services.Services.User.Identity;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class AdminSideBarViewComponent : ViewComponent
    {
        private readonly ApplicationUserManager _applicationUserManager;

        public AdminSideBarViewComponent(ApplicationUserManager applicationUserManager)
        {
            _applicationUserManager = applicationUserManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var adminLinks = await AdminPanelService.GetLinks(_applicationUserManager, User.Identity?.Name, Request.GetEncodedPathAndQuery());
            return View(adminLinks);
        }

    }
}