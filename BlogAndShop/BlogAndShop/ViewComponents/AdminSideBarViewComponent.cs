using System.Reflection;
using System.Threading.Tasks;
using BlogAndShop.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.ViewComponents
{
    public class AdminSideBarViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var adminLinks = AdminPanelService.GetLinks();
            return View(adminLinks);
        }

    }
}