using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.Data.Email;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.Data.HomePage;
using BlogAndShop.Data.Data.LearningSystem;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.Product;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Email;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.HomePage;
using BlogAndShop.Data.ViewModel.LearningSystem;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.User;
using CommonConfiguration.Core.Data.Data.User;
using CommonConfiguration.Core.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.User;
using CommonConfiguration.Core.Services.Mapper;
using CommonConfiguration.Core.Services.Utilities.File;
using Newtonsoft.Json;

namespace BlogAndShop.Services.Services.Mapper
{
    public static class MapperService
    {
        #region Common


        //HomeBanner
        public static HomeBannerModel ToModel(this HomeBanner item)
        {
            return MainMapperService.Map<HomeBannerModel>(item);
        }

        public static HomeBanner ToEntity(this HomeBannerModel item)
        {
            return MainMapperService.Map<HomeBanner>(item);
        }

        //HomeBanner
        public static PageViewLogViewModel ToModel(this PageViewLog item)
        {
            return MainMapperService.Map<PageViewLogViewModel>(item);
        }

        public static PageViewLog ToEntity(this PageViewLogViewModel item)
        {
            return MainMapperService.Map<PageViewLog>(item);
        }


        //HomeBanner
        public static EmailAccountModel ToModel(this EmailAccount item)
        {
            return MainMapperService.Map<EmailAccountModel>(item);
        }

        public static EmailAccount ToEntity(this EmailAccountModel item)
        {
            return MainMapperService.Map<EmailAccount>(item);
        }

        //ProductCallRequest
        public static ProductCallRequestModel ToModel(this ProductCallRequest item)
        {
            return MainMapperService.Map<ProductCallRequestModel>(item);
        }

        public static ProductCallRequest ToEntity(this ProductCallRequestModel item)
        {
            return MainMapperService.Map<ProductCallRequest>(item);
        }

        //SocialMedia
        public static SocialMediaModel ToModel(this SocialMedia item)
        {
            return MainMapperService.Map<SocialMediaModel>(item);
        }

        public static SocialMedia ToEntity(this SocialMediaModel item)
        {
            return MainMapperService.Map<SocialMedia>(item);
        }

        //Media
        public static MediaModel ToModel(this Media item)
        {
            var model = MainMapperService.Map<MediaModel>(item);

            //file type
            model.FileType = FileHelperService.GetFileType(item.Extension);


            return model;
        }

        public static Media ToEntity(this MediaModel item)
        {
            return MainMapperService.Map<Media>(item);
        }

        //SiteConfig
        public static SiteConfigModel ToModel(this SiteConfig item)
        {
            return MainMapperService.Map<SiteConfigModel>(item);
        }

        public static SiteConfig ToEntity(this SiteConfigModel item)
        {
            return MainMapperService.Map<SiteConfig>(item);
        }

        //Tag
        public static TagModel ToModel(this Tag item)
        {
            return MainMapperService.Map<TagModel>(item);
        }

        public static Tag ToEntity(this TagModel item)
        {
            return MainMapperService.Map<Tag>(item);
        }


        #endregion

        #region Forum


        //ForumComment
        public static ForumCommentModel ToModel(this ForumComment item)
        {
            return MainMapperService.Map<ForumCommentModel>(item);
        }

        public static ForumComment ToEntity(this ForumCommentModel item)
        {
            return MainMapperService.Map<ForumComment>(item);
        }

        //ForumComment
        public static ProductForumGroupModel ToModel(this Product_ForumInfo item)
        {
            return MainMapperService.Map<ProductForumGroupModel>(item);
        }

        public static Product_ForumInfo ToEntity(this ProductForumGroupModel item)
        {
            return MainMapperService.Map<Product_ForumInfo>(item);
        }

        //ForumTitle
        public static ForumTitleModel ToModel(this ForumTitle item)
        {
            return MainMapperService.Map<ForumTitleModel>(item);
        }

        public static ForumTitle ToEntity(this ForumTitleModel item)
        {
            return MainMapperService.Map<ForumTitle>(item);
        }
        //ForumGroup
        public static ForumGroupModel ToModel(this ForumGroup item)
        {
            return MainMapperService.Map<ForumGroupModel>(item);
        }

        public static ForumGroup ToEntity(this ForumGroupModel item)
        {
            return MainMapperService.Map<ForumGroup>(item);
        }


        #endregion

        #region PaymentInfo


        //CartItem
        public static CartItemModel ToModel(this CartItem item)
        {
            return MainMapperService.Map<CartItemModel>(item);
        }

        public static CartItem ToEntity(this CartItemModel item)
        {
            return MainMapperService.Map<CartItem>(item);
        }

        //Payment
        public static PaymentModel ToModel(this Payment item)
        {
            return MainMapperService.Map<PaymentModel>(item);
        }

        public static Payment ToEntity(this PaymentModel item)
        {
            return MainMapperService.Map<Payment>(item);
        }

        //PaymentItem
        public static PaymentItemModel ToModel(this PaymentItem item)
        {
            return MainMapperService.Map<PaymentItemModel>(item);
        }

        public static PaymentItem ToEntity(this PaymentItemModel item)
        {
            return MainMapperService.Map<PaymentItem>(item);
        }

        //PaymentLog
        public static PaymentLogModel ToModel(this PaymentLog item)
        {
            return MainMapperService.Map<PaymentLogModel>(item);
        }

        public static PaymentLog ToEntity(this PaymentLogModel item)
        {
            return MainMapperService.Map<PaymentLog>(item);
        }


        #endregion

        #region PostInfo


        //Post
        public static PostModel ToModel(this Post item)
        {
            return MainMapperService.Map<PostModel>(item);
        }

        public static Post ToEntity(this PostModel item)
        {
            return MainMapperService.Map<Post>(item);
        }

        //PostComment
        public static PostCommentModel ToModel(this PostComment item)
        {
            return MainMapperService.Map<PostCommentModel>(item);
        }

        public static PostComment ToEntity(this PostCommentModel item)
        {
            return MainMapperService.Map<PostComment>(item);
        }

        //PostGroup
        public static PostGroupModel ToModel(this PostGroup item)
        {
            return MainMapperService.Map<PostGroupModel>(item);
        }

        public static PostGroup ToEntity(this PostGroupModel item)
        {
            return MainMapperService.Map<PostGroup>(item);
        }

        //Post_PostGroup
        public static Post_PostGroupModel ToModel(this Post_PostGroup item)
        {
            return MainMapperService.Map<Post_PostGroupModel>(item);
        }

        public static Post_PostGroup ToEntity(this Post_PostGroupModel item)
        {
            return MainMapperService.Map<Post_PostGroup>(item);
        }

        //Post_Tags
        public static Post_TagsModel ToModel(this Post_Tags item)
        {
            return MainMapperService.Map<Post_TagsModel>(item);
        }

        public static Post_Tags ToEntity(this Post_TagsModel item)
        {
            return MainMapperService.Map<Post_Tags>(item);
        }


        #endregion

        #region Product


        //Brand
        public static DownloadItemViewModel ToModel(this Data.Data.Product.DownloadItem item)
        {
            return MainMapperService.Map<DownloadItemViewModel>(item);
        }

        public static Data.Data.Product.DownloadItem ToEntity(this DownloadItemViewModel item)
        {
            return MainMapperService.Map<Data.Data.Product.DownloadItem>(item);
        }

        //Brand
        public static BrandModel ToModel(this Data.Data.Product.Brand item)
        {
            return MainMapperService.Map<BrandModel>(item);
        }

        public static Data.Data.Product.Brand ToEntity(this BrandModel item)
        {
            return MainMapperService.Map<Data.Data.Product.Brand>(item);
        }

        //Product
        public static ProductModel ToModel(this Data.Data.Product.Product item)
        {
            return MainMapperService.Map<ProductModel>(item);
        }

        public static Data.Data.Product.Product ToEntity(this ProductModel item)
        {
            return MainMapperService.Map<Data.Data.Product.Product>(item);
        }

        //ProductComment
        public static ProductCommentModel ToModel(this ProductComment item)
        {
            return MainMapperService.Map<ProductCommentModel>(item);
        }

        public static ProductComment ToEntity(this ProductCommentModel item)
        {
            return MainMapperService.Map<ProductComment>(item);
        }

        //ProductGroup
        public static ProductGroupModel ToModel(this ProductGroup item)
        {
            return MainMapperService.Map<ProductGroupModel>(item);
        }

        public static ProductGroup ToEntity(this ProductGroupModel item)
        {
            return MainMapperService.Map<ProductGroup>(item);
        }

        //ProductMedia
        public static ProductMediaModel ToModel(this ProductMedia item)
        {
            return MainMapperService.Map<ProductMediaModel>(item);
        }

        public static ProductMedia ToEntity(this ProductMediaModel item)
        {
            return MainMapperService.Map<ProductMedia>(item);
        }

        //ProductTag
        public static ProductTagModel ToModel(this ProductTag item)
        {
            return MainMapperService.Map<ProductTagModel>(item);
        }

        public static ProductTag ToEntity(this ProductTagModel item)
        {
            return MainMapperService.Map<ProductTag>(item);
        }


        #endregion

        #region User


        //Address
        public static AddressModel ToModel(this Address item)
        {
            return MainMapperService.Map<AddressModel>(item);
        }

        public static Address ToEntity(this AddressModel item)
        {
            return MainMapperService.Map<Address>(item);
        }

        //ApplicationRole
        public static ApplicationRoleModel ToModel(this ApplicationRole item)
        {
            return MainMapperService.Map<ApplicationRoleModel>(item);
        }

        public static ApplicationRole ToEntity(this ApplicationRoleModel item)
        {
            return MainMapperService.Map<ApplicationRole>(item);
        }

        //ApplicationUser
        public static ApplicationUserModel ToModel(this ApplicationUser item)
        {
            return MainMapperService.Map<ApplicationUserModel>(item);
        }

        public static ApplicationUser ToEntity(this ApplicationUserModel item)
        {
            return MainMapperService.Map<ApplicationUser>(item);
        }

        //RoleAccess
        public static RoleAccessModel ToModel(this RoleAccess item)
        {
            return MainMapperService.Map<RoleAccessModel>(item);
        }

        public static RoleAccess ToEntity(this RoleAccessModel item)
        {
            return MainMapperService.Map<RoleAccess>(item);
        }

        //UserCart
        public static UserCartModel ToModel(this UserCart item)
        {
            return MainMapperService.Map<UserCartModel>(item);
        }

        public static UserCart ToEntity(this UserCartModel item)
        {
            return MainMapperService.Map<UserCart>(item);
        }

        //UserRoles
        public static UserRolesModel ToModel(this UserRoles item)
        {
            return MainMapperService.Map<UserRolesModel>(item);
        }

        public static UserRoles ToEntity(this UserRolesModel item)
        {
            return MainMapperService.Map<UserRoles>(item);
        }


        #endregion

        #region LearningSystem


        public static CourseRegisterRequestViewModel ToModel(this CourseRegisterRequest item)
        {
            return MainMapperService.Map<CourseRegisterRequestViewModel>(item);
        }

        public static CourseRegisterRequest ToEntity(this CourseRegisterRequestViewModel item)
        {
            return MainMapperService.Map<CourseRegisterRequest>(item);
        }

        public static CourseViewModel ToModel(this Course item)
        {
            return MainMapperService.Map<CourseViewModel>(item);
        }

        public static Course ToEntity(this CourseViewModel item)
        {
            return MainMapperService.Map<Course>(item);
        }


        public static LearningSiteConfigViewModel ToModel(this LearningSiteConfig item)
        {
            return MainMapperService.Map<LearningSiteConfigViewModel>(item);
        }

        public static LearningSiteConfig ToEntity(this LearningSiteConfigViewModel item)
        {
            return MainMapperService.Map<LearningSiteConfig>(item);
        }
        public static LearningSystemFooterLinkViewModel ToModel(this LearningSystemFooterLink item)
        {
            return MainMapperService.Map<LearningSystemFooterLinkViewModel>(item);
        }

        public static LearningSystemFooterLink ToEntity(this LearningSystemFooterLinkViewModel item)
        {
            return MainMapperService.Map<LearningSystemFooterLink>(item);
        }

        #endregion

    }
}
