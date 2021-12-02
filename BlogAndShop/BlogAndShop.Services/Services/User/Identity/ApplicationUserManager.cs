using System;
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

        #endregion
        #region Methods

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
        #endregion
        #region Utilities

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

        public ApplicationUserManager(ApplicationUserStore store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<ApplicationUser> passwordHasher, IEnumerable<IUserValidator<ApplicationUser>> userValidators, IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<ApplicationUser>> logger, IUserTokenService userTokenService) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            Store = store;
            _userTokenService = userTokenService;
        }
        #endregion


    }
}
