using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.User;
using BlogAndShop.Services.Services.Common.SenderServices;
using BlogAndShop.Services.Services.Mapper;
using BlogAndShop.Services.Services.User;
using BlogAndShop.Services.Services.User.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BlogAndShop.Controllers
{
    public class AccountController : MainBaseController
    {
        #region Fields

        private readonly ApplicationUserManager _applicationUserManager;
        private readonly ApplicationSigninManager _applicationSigninManager;
        private readonly ISendService _sendService;
        private readonly IUserTokenService _userTokenService;
        private readonly IAddressService _addressService;

        #endregion
        #region Methods

        public IActionResult Index(string ReturnUrl)
        {
            var model = new LoginRegisterViewModel() { RedirectUrl = ReturnUrl, IsLogin = true };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.HasMessage = true;
                return View("Index", model);
            }
            var user = await _applicationUserManager.FindAsync(model.LoginName);
            if (user == null)
            {
                model.HasMessage = true;
                ModelState.AddModelError("", "نام کاربری یا رمز عبور اشتباه است.");
                return View("Index", model);
            }
            var result = await _applicationSigninManager.PasswordSignInAsync(user, model.LoginPassword, false, false);
            if (result.Succeeded)
                return Redirect(model.RedirectUrl ?? "/");
            model.HasMessage = true;
            ModelState.AddModelError("", "نام کاربری یا رمز عبور اشتباه است.");
            return View("Index", model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(LoginRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.HasMessage = true;
                return View("Index", model);
            }
            var user = new ApplicationUser()
            {
                Email = model.Email,
                Family = model.Family,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber,
                UserName = model.Email.Split('@').First()
            };
            var result = await _applicationUserManager.CreateAsync(user, model.Password);
            if (result.Succeeded) return RedirectToAction("Index");
            foreach (var identityError in result.Errors)
            {
                model.HasMessage = true;
                ModelState.AddModelError(identityError.Code, identityError.Description);
            }
            return View("Index", model);
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(LoginRegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.HasMessage = true;
                return View("Index", model);
            }
            var user = await _applicationUserManager.FindAsync(model.ForgetName);
            if (user == null)
            {
                model.HasMessage = true;
                ModelState.AddModelError("", "کاربر یافت نشد.");
                return View("Index", model);
            }

            var token = await _applicationUserManager.GenerateToken(user, UserTokenType.ResetPassword);
            var check = await _sendService.Send(user, $"کد شما برای بازیابی رمز عبور: {token}");
            return View(new ForgotPasswordModel
            {
                UserId = user.Id
            });
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmForgotPassword(ForgotPasswordModel model)
        {
            var user = await _applicationUserManager.FindByIdAsync(model.UserId.ToString());
            if (user == null)
            {
                ModelState.AddModelError("", "کاربر یافت نشد.");
                return View("ForgotPassword", model);
            }

            var check = await _userTokenService.CheckUserToken(user.Id, UserTokenType.ResetPassword, model.Token);
            if (!check)
            {
                ModelState.AddModelError("", "کد وارد شده صحیح نمی باشد.");
                return View("ForgotPassword", model);
            }

            var result = await _applicationUserManager.ResetPasswordAsync(user, model.Password);
            if (result)
            {
                await _userTokenService.RemoveUserToken(user.Id, UserTokenType.ResetPassword);
                return MessagePage("رمز عبور شما با موفقیت تغییر کرد");
            }
            ModelState.AddModelError("", "نام کاربر مورد تایید نمی باشد.");
            return View("ForgotPassword", model);
        }
        [Authorize]
        [HttpPost]
        public IActionResult CreateNewAddress()
        {
            return View();
        }
        [Authorize]
        public IActionResult Orders()
        {
            return View();
        }
        [Authorize]
        public async Task<IActionResult> Profile()
        {
            if (User.Identity == null) return NotFound();
            var user = await _applicationUserManager.FindAsync(User.Identity.Name);
            if (user == null) return NotFound();
            var addresses = await _addressService.GetUserAddresses(user.Id);
            var model = new ProfileViewModel()
            {
                Addresses = addresses.Select(x => x.ToModel()).ToList(),
                User = user.ToModel()
            };
            return View(model);
        }
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _applicationSigninManager.SignOutAsync();
            return RedirectToAction("Index", "Home");

        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        #endregion
        #region Utilities


        #endregion
        #region Ctor

        public AccountController(ApplicationUserManager applicationUserManager, ApplicationSigninManager applicationSigninManager, ISendService sendService, IUserTokenService userTokenService, IAddressService addressService)
        {
            _applicationUserManager = applicationUserManager;
            _applicationSigninManager = applicationSigninManager;
            _sendService = sendService;
            _userTokenService = userTokenService;
            _addressService = addressService;
        }

        #endregion
    }
}
