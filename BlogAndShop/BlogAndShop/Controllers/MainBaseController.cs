using System;
using BlogAndShop.Data.ViewModel.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.Controllers
{
    public class MainBaseController : Controller
    {
        protected IActionResult MessagePage(string message)
        {
            return View("MessageShowPage", new MessageShowPageViewModel() { Message = message });
        }

        protected int GetUserId()
        {
            if (User.Identity.IsAuthenticated) return Convert.ToInt32(User.Identity.Name);
            return 0;
        }
    }
}