using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Data.ViewModel.User;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PaymentInfo;
using BlogAndShop.Services.Services.Product;
using BlogAndShop.Services.Services.User;
using BlogAndShop.Services.Services.User.Identity;
using Microsoft.AspNetCore.Authorization;

namespace BlogAndShop.Controllers
{
    [Authorize]
    public class UserPaymentController : Controller
    {
        #region Fields

        private readonly ApplicationUserManager _applicationUserManager;
        private readonly IUserCartService _userCartService;
        private readonly ICartItemService _cartItemService;
        private readonly IProductService _productService;
        #endregion
        #region Methods

        public async Task<IActionResult> Index()
        {
            if (User.Identity == null) return NotFound();
            var user = await _applicationUserManager.FindAsync(User.Identity.Name);
            if (user == null) return NotFound();
            var model = await _userCartService.GetUserCartModel(user.Id);
            return View(model);
        }

        public IActionResult Info(int id)
        {
            return View();
        }

        #endregion
        #region Utilities

        #endregion
        #region Ctor

        public UserPaymentController(ApplicationUserManager applicationUserManager, IUserCartService userCartService, ICartItemService cartItemService, IProductService productService)
        {
            _applicationUserManager = applicationUserManager;
            _userCartService = userCartService;
            _cartItemService = cartItemService;
            _productService = productService;
        }

        #endregion

    }
}
