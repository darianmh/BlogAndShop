using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.Email;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.Data.HomePage;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Email;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.HomePage;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.User;
using Newtonsoft.Json;

namespace BlogAndShop.Services.Services.Mapper
{
    public static class MapperService
    {
        #region Common


        //BaseEntity
        public static BaseEntityModel ToModel(this BaseEntity item)
        {
            return Map<BaseEntityModel>(item);
        }

        public static BaseEntity ToEntity(this BaseEntityModel item)
        {
            return Map<BaseEntity>(item);
        }

        //HomeBanner
        public static HomeBannerModel ToModel(this HomeBanner item)
        {
            return Map<HomeBannerModel>(item);
        }

        public static HomeBanner ToEntity(this HomeBannerModel item)
        {
            return Map<HomeBanner>(item);
        }

        //HomeBanner
        public static PageViewLogViewModel ToModel(this PageViewLog item)
        {
            return Map<PageViewLogViewModel>(item);
        }

        public static PageViewLog ToEntity(this PageViewLogViewModel item)
        {
            return Map<PageViewLog>(item);
        }


        //HomeBanner
        public static EmailAccountModel ToModel(this EmailAccount item)
        {
            return Map<EmailAccountModel>(item);
        }

        public static EmailAccount ToEntity(this EmailAccountModel item)
        {
            return Map<EmailAccount>(item);
        }

        //ProductCallRequest
        public static ProductCallRequestModel ToModel(this ProductCallRequest item)
        {
            return Map<ProductCallRequestModel>(item);
        }

        public static ProductCallRequest ToEntity(this ProductCallRequestModel item)
        {
            return Map<ProductCallRequest>(item);
        }

        //SocialMedia
        public static SocialMediaModel ToModel(this SocialMedia item)
        {
            return Map<SocialMediaModel>(item);
        }

        public static SocialMedia ToEntity(this SocialMediaModel item)
        {
            return Map<SocialMedia>(item);
        }

        //Media
        public static MediaModel ToModel(this Media item)
        {
            var model = Map<MediaModel>(item);
            //file type
            if (item.Extension.Equals("bmp", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals("jpg", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals("jpeg", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals("gif", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals("png", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals(".bmp", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals(".gif", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals(".WebP", StringComparison.OrdinalIgnoreCase)
                || item.Extension.Equals(".png", StringComparison.OrdinalIgnoreCase))
            {
                model.FileType = FileType.Image;
            }
            else if (item.Extension.Equals("mp4", StringComparison.OrdinalIgnoreCase)
                     || item.Extension.Equals("WMV", StringComparison.OrdinalIgnoreCase)
                     || item.Extension.Equals(".mp4", StringComparison.OrdinalIgnoreCase)
                     || item.Extension.Equals(".WMV", StringComparison.OrdinalIgnoreCase))
            {
                model.FileType = FileType.Video;
            }
            else
            {
                model.FileType = FileType.Document;
            }

            return model;
        }

        public static Media ToEntity(this MediaModel item)
        {
            return Map<Media>(item);
        }

        //SiteConfig
        public static SiteConfigModel ToModel(this SiteConfig item)
        {
            return Map<SiteConfigModel>(item);
        }

        public static SiteConfig ToEntity(this SiteConfigModel item)
        {
            return Map<SiteConfig>(item);
        }

        //Tag
        public static TagModel ToModel(this Tag item)
        {
            return Map<TagModel>(item);
        }

        public static Tag ToEntity(this TagModel item)
        {
            return Map<Tag>(item);
        }


        #endregion

        #region Forum


        //ForumComment
        public static ForumCommentModel ToModel(this ForumComment item)
        {
            return Map<ForumCommentModel>(item);
        }

        public static ForumComment ToEntity(this ForumCommentModel item)
        {
            return Map<ForumComment>(item);
        }

        //ForumComment
        public static ProductForumGroupModel ToModel(this Product_ForumInfo item)
        {
            return Map<ProductForumGroupModel>(item);
        }

        public static Product_ForumInfo ToEntity(this ProductForumGroupModel item)
        {
            return Map<Product_ForumInfo>(item);
        }

        //ForumTitle
        public static ForumTitleModel ToModel(this ForumTitle item)
        {
            return Map<ForumTitleModel>(item);
        }

        public static ForumTitle ToEntity(this ForumTitleModel item)
        {
            return Map<ForumTitle>(item);
        }
        //ForumGroup
        public static ForumGroupModel ToModel(this ForumGroup item)
        {
            return Map<ForumGroupModel>(item);
        }

        public static ForumGroup ToEntity(this ForumGroupModel item)
        {
            return Map<ForumGroup>(item);
        }


        #endregion

        #region PaymentInfo


        //CartItem
        public static CartItemModel ToModel(this CartItem item)
        {
            return Map<CartItemModel>(item);
        }

        public static CartItem ToEntity(this CartItemModel item)
        {
            return Map<CartItem>(item);
        }

        //Payment
        public static PaymentModel ToModel(this Payment item)
        {
            return Map<PaymentModel>(item);
        }

        public static Payment ToEntity(this PaymentModel item)
        {
            return Map<Payment>(item);
        }

        //PaymentItem
        public static PaymentItemModel ToModel(this PaymentItem item)
        {
            return Map<PaymentItemModel>(item);
        }

        public static PaymentItem ToEntity(this PaymentItemModel item)
        {
            return Map<PaymentItem>(item);
        }

        //PaymentLog
        public static PaymentLogModel ToModel(this PaymentLog item)
        {
            return Map<PaymentLogModel>(item);
        }

        public static PaymentLog ToEntity(this PaymentLogModel item)
        {
            return Map<PaymentLog>(item);
        }


        #endregion

        #region PostInfo


        //Post
        public static PostModel ToModel(this Post item)
        {
            return Map<PostModel>(item);
        }

        public static Post ToEntity(this PostModel item)
        {
            return Map<Post>(item);
        }

        //PostComment
        public static PostCommentModel ToModel(this PostComment item)
        {
            return Map<PostCommentModel>(item);
        }

        public static PostComment ToEntity(this PostCommentModel item)
        {
            return Map<PostComment>(item);
        }

        //PostGroup
        public static PostGroupModel ToModel(this PostGroup item)
        {
            return Map<PostGroupModel>(item);
        }

        public static PostGroup ToEntity(this PostGroupModel item)
        {
            return Map<PostGroup>(item);
        }

        //Post_PostGroup
        public static Post_PostGroupModel ToModel(this Post_PostGroup item)
        {
            return Map<Post_PostGroupModel>(item);
        }

        public static Post_PostGroup ToEntity(this Post_PostGroupModel item)
        {
            return Map<Post_PostGroup>(item);
        }

        //Post_Tags
        public static Post_TagsModel ToModel(this Post_Tags item)
        {
            return Map<Post_TagsModel>(item);
        }

        public static Post_Tags ToEntity(this Post_TagsModel item)
        {
            return Map<Post_Tags>(item);
        }


        #endregion

        #region Product


        //Brand
        public static DownloadItemViewModel ToModel(this Data.Data.Product.DownloadItem item)
        {
            return Map<DownloadItemViewModel>(item);
        }

        public static Data.Data.Product.DownloadItem ToEntity(this DownloadItemViewModel item)
        {
            return Map<Data.Data.Product.DownloadItem>(item);
        }

        //Brand
        public static BrandModel ToModel(this Data.Data.Product.Brand item)
        {
            return Map<BrandModel>(item);
        }

        public static Data.Data.Product.Brand ToEntity(this BrandModel item)
        {
            return Map<Data.Data.Product.Brand>(item);
        }

        //Product
        public static ProductModel ToModel(this Data.Data.Product.Product item)
        {
            return Map<ProductModel>(item);
        }

        public static Data.Data.Product.Product ToEntity(this ProductModel item)
        {
            return Map<Data.Data.Product.Product>(item);
        }

        //ProductComment
        public static ProductCommentModel ToModel(this ProductComment item)
        {
            return Map<ProductCommentModel>(item);
        }

        public static ProductComment ToEntity(this ProductCommentModel item)
        {
            return Map<ProductComment>(item);
        }

        //ProductGroup
        public static ProductGroupModel ToModel(this ProductGroup item)
        {
            return Map<ProductGroupModel>(item);
        }

        public static ProductGroup ToEntity(this ProductGroupModel item)
        {
            return Map<ProductGroup>(item);
        }

        //ProductMedia
        public static ProductMediaModel ToModel(this ProductMedia item)
        {
            return Map<ProductMediaModel>(item);
        }

        public static ProductMedia ToEntity(this ProductMediaModel item)
        {
            return Map<ProductMedia>(item);
        }

        //ProductTag
        public static ProductTagModel ToModel(this ProductTag item)
        {
            return Map<ProductTagModel>(item);
        }

        public static ProductTag ToEntity(this ProductTagModel item)
        {
            return Map<ProductTag>(item);
        }


        #endregion

        #region User


        //Address
        public static AddressModel ToModel(this Address item)
        {
            return Map<AddressModel>(item);
        }

        public static Address ToEntity(this AddressModel item)
        {
            return Map<Address>(item);
        }

        //ApplicationRole
        public static ApplicationRoleModel ToModel(this ApplicationRole item)
        {
            return Map<ApplicationRoleModel>(item);
        }

        public static ApplicationRole ToEntity(this ApplicationRoleModel item)
        {
            return Map<ApplicationRole>(item);
        }

        //ApplicationUser
        public static ApplicationUserModel ToModel(this ApplicationUser item)
        {
            return Map<ApplicationUserModel>(item);
        }

        public static ApplicationUser ToEntity(this ApplicationUserModel item)
        {
            return Map<ApplicationUser>(item);
        }

        //RoleAccess
        public static RoleAccessModel ToModel(this RoleAccess item)
        {
            return Map<RoleAccessModel>(item);
        }

        public static RoleAccess ToEntity(this RoleAccessModel item)
        {
            return Map<RoleAccess>(item);
        }

        //UserCart
        public static UserCartModel ToModel(this UserCart item)
        {
            return Map<UserCartModel>(item);
        }

        public static UserCart ToEntity(this UserCartModel item)
        {
            return Map<UserCart>(item);
        }

        //UserRoles
        public static UserRolesModel ToModel(this UserRoles item)
        {
            return Map<UserRolesModel>(item);
        }

        public static UserRoles ToEntity(this UserRolesModel item)
        {
            return Map<UserRoles>(item);
        }


        #endregion



        private static T Map<T>(object obj)
        {
            var txt = JsonConvert.SerializeObject(obj);
            var final = JsonConvert.DeserializeObject<T>(txt);
            return final;
        }
    }
}
