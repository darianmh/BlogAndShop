using BlogAndShop.Services.Services.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace BlogAndShop.Controllers.Admin
{
    public class BaseAdminController : MainBaseController
    {
        protected readonly IAdminModelHelper AdminModelHelper;

        public BaseAdminController(IAdminModelHelper adminModelHelper)
        {
            AdminModelHelper = adminModelHelper;
        }

    }
}