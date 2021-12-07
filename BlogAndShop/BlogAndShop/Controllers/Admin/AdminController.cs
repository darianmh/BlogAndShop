﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Services.Classes;

namespace BlogAndShop.Controllers.Admin
{
    [AdminFilterName(AdminControllerNames.Dashboard, "داشبرد")]
    public class AdminController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
