using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Data.ViewModel.User;
using BlogAndShop.Data.ViewModel.User.Cart;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.PaymentInfo;
using BlogAndShop.Services.Services.Product;
using BlogAndShop.Services.Services.User;
using CommonConfiguration.Core.Controllers;
using CommonConfiguration.Core.Services.User.Identity;
using Microsoft.AspNetCore.Authorization;

namespace BlogAndShop.Controllers
{
    [Authorize]
    public class UserPaymentController : MainBaseController
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

        public async Task<IActionResult> AddCartItem(int? productId, int qty = 1)
        {
            if (productId == null) return NotFound();
            if (User.Identity == null) return NotFound();
            var user = await _applicationUserManager.FindAsync(User.Identity.Name);
            if (user == null) return NotFound();
            var product = await _productService.GetByIdAsync((int)productId);
            if (product == null) return NotFound();
            var userCart = await _userCartService.GetUserCart(user.Id);
            var checkAdd = await _cartItemService.AddCartItem(userCart, product, quantity: qty);
            if (checkAdd.Check) return RedirectToAction("Index");
            if (checkAdd.CartAddResult == CartAddResult.CartNotFound ||
                checkAdd.CartAddResult == CartAddResult.ProductNotFound)
                return NotFound();
            return MessagePage("موجودی محصول به اتمام رسیده است");
        }

        public async Task<IActionResult> RemoveCartItem(int? productId)
        {
            if (productId == null) return NotFound();
            if (User.Identity == null) return NotFound();
            var user = await _applicationUserManager.FindAsync(User.Identity.Name);
            if (user == null) return NotFound();
            var userCart = await _userCartService.GetUserCart(user.Id);
            await _cartItemService.RemoveCartItem(userCart, (int)productId);
            return RedirectToAction("Index");
        }

        public IActionResult Info(int id)
        {
            return View();
        }

        public IActionResult ConfirmOrder()
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
