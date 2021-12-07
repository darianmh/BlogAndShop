using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.Controllers.Admin
{
    public class BaseAdminController : MainBaseController
    {
        protected int GetUserId()
        {
            return 5;
        }
    }
}