using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.Controllers.Admin
{
    public class BaseAdminController : Controller
    {
        protected int GetUserId()
        {
            return 5;
        }
    }
}