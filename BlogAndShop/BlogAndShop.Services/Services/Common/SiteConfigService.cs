using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Classes;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.Mapper;

namespace BlogAndShop.Services.Services.Common
{
    public class SiteConfigService : MainService<SiteConfig>, ISiteConfigService
    {
        #region Fields


        #endregion
        #region Methods

        public async Task<SiteConfigModel> GetInfo()
        {

            var model = CacheHelper.SiteConfigCache;
            if (model == null)
            {
                var entity = (await GetAllAsync()).FirstOrDefault();
                if (entity == null) entity = await CreateNewConfig();
                model = entity?.ToModel();
                if (model == null) return new SiteConfigModel();
                CacheHelper.SiteConfigCache = model;
            }
            return model;
        }


        public async Task<int> GetProductForumGroup()
        {
            var info = await GetInfo();
            return info?.ProductForumGroup ?? 0;
        }

        public async Task<ShoppingModel> GetShoppingModel()
        {
            var info = await GetInfo();
            return info?.ShoppingModel ?? ShoppingModel.Call;
        }

        public async Task<List<string>> GetAdminPhoneNumbers()
        {
            var info = await GetInfo();
            var email = info.AdminPhones;
            return SplitAdminInfos(email);
        }


        public async Task<List<string>> GetAdminEmails()
        {
            var info = await GetInfo();
            var phoneNumber = info.AdminEmails;
            return SplitAdminInfos(phoneNumber);
        }

        #endregion
        #region Utilities

        private List<string> SplitAdminInfos(string infos)
        {
            if (infos == null) return new List<string>();
            var split = infos.Split(',');
            return split.Select(x => x.Trim()).ToList();
        }

        private async Task<SiteConfig?> CreateNewConfig()
        {
            var entity = new SiteConfig();
            await InsertAsync(entity);
            return entity;
        }
        #endregion
        #region Ctor
        public SiteConfigService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion

    }
}