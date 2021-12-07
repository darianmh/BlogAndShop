﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BlogAndShop.Services.Services.User.Identity
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        #region Fields

        public new ApplicationUserStore Store { get; set; }
        private readonly IUserTokenService _userTokenService;
        private readonly IApplicationRoleService _applicationRoleService;
        private readonly IRoleAccessService _roleAccessService;

        #endregion
        #region Methods

        /// <summary>
        ///آیدی نقش های کاربر را بر میگرداند
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<List<int>> GetSelectedRolesByUser(int id)
        {
            var model = await GetRolesByUser(id);
            return model.Select(x => x.Id).ToList();
        }
        ///  <summary>
        /// نقش های کاربر را بر میگرداند
        ///  </summary>
        ///  <param name="id"></param>
        ///  <returns></returns>

        public async Task<List<ApplicationRole>> GetRolesByUser(int id)
        {
            var user = await FindByIdAsync(id.ToString());
            if (user == null) return new List<ApplicationRole>();
            var roles = await GetRolesAsync(user);
            return await _applicationRoleService.GetRolesByNames(roles.ToList());
        }

        /// <summary>
        /// نقش های کاربر را پاک کرده و نقش های جدید را ذخیره می کند
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="selectedRoles"></param>
        /// <returns></returns>
        public async Task SetUserRoles(int userId, List<int> selectedRoles)
        {
            var user = await FindByIdAsync(userId.ToString());
            if (user == null) return;
            var roles = await GetRolesByUser(userId);
            await RemoveFromRolesAsync(user, roles.Select(x => x.Name).ToList());
            await CreateRoles(user, selectedRoles);
            await UpdateAsync(user);
        }



        public async Task<bool> ResetPasswordAsync(ApplicationUser user, string password)
        {
            var passHash = PasswordHasher.HashPassword(user, password);
            user.PasswordHash = passHash;
            var result = await UpdateSecurityStampAsync(user);
            await UpdateAsync(user);
            return true;
        }

        /// <summary>
        /// find user and generates display name
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<string> GetUSerDisplayNameAsync(string user)
        {
            var userModel = await FindAsync(user);
            if (userModel == null) return "";
            return await GenerateDisplayName(userModel);
        }
        public async Task<ApplicationUser> FindAsync(string user)
        {
            return await Store.FindAsync(user);
        }

        public async Task<string> GenerateToken(ApplicationUser user, UserTokenType tokenType)
        {
            return await _userTokenService.GenerateUserToken(user.Id, tokenType);
        }


        /// <summary>
        /// دریافت دسترسی کاربر به کنترلر مربوطه
        /// </summary>
        /// <returns></returns>
        public async Task<bool> UserHasAccess(string user, string accessName)
        {
            var userModel = await FindAsync(user);
            if (user == null) return false;
            var roles = await GetRolesAsync(userModel);
            var rolesModel = await _applicationRoleService.GetRolesByNames(roles.ToList());
            var allAccesses = await _roleAccessService.GetAllAccessesByRoles(rolesModel);
            return allAccesses.Any(x => x.AttrName == accessName);
        }
        #endregion
        #region Utilities

        private async Task CreateRoles(ApplicationUser user, List<int> selectedRoles)
        {
            if (selectedRoles == null) return;
            selectedRoles = selectedRoles.GroupBy(i => i).Select(x => x.First()).ToList();
            var rolesName = await _applicationRoleService.GetRolesByIds(selectedRoles);
            var names = rolesName.Select(applicationRole => applicationRole.Name).Distinct().ToList();
            await AddToRolesAsync(user, names);
        }

        private async Task<string> GenerateDisplayName(ApplicationUser userModel)
        {
            if (!string.IsNullOrEmpty(userModel.Name) || !string.IsNullOrEmpty(userModel.Family))
                return $"{userModel.Name} {userModel.Family}";
            if (!string.IsNullOrEmpty(userModel.UserName))
                return userModel.UserName;
            if (!string.IsNullOrEmpty(userModel.PhoneNumber))
                return userModel.PhoneNumber;
            return userModel.Email;
        }

        #endregion
        #region Ctor

        public ApplicationUserManager(ApplicationUserStore store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<ApplicationUser> passwordHasher, IEnumerable<IUserValidator<ApplicationUser>> userValidators, IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<ApplicationUser>> logger, IUserTokenService userTokenService, IApplicationRoleService applicationRoleService, IRoleAccessService roleAccessService) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            Store = store;
            _userTokenService = userTokenService;
            _applicationRoleService = applicationRoleService;
            _roleAccessService = roleAccessService;
        }
        #endregion

    }
}
