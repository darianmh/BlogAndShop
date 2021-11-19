using System.Collections.Generic;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.Forum;
using BlogAndShop.Data.ViewModel.PaymentInfo;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Data.ViewModel.Product;
using Microsoft.AspNetCore.Identity;

namespace BlogAndShop.Data.ViewModel.User
{
    public class ApplicationUserModel/* : IdentityUser<int>*/
    {
        public int Id { get; set; }

        //np
        public virtual List<PostModel> Posts { get; set; }
        public virtual List<TagModel> Tags { get; set; }
        public virtual List<PaymentModel> Payments { get; set; }
        public virtual List<ForumTitleModel> ForumTitles { get; set; }
        public virtual List<ForumCommentModel> ForumComments { get; set; }
        public virtual List<PostCommentModel> PostComments { get; set; }
        public virtual List<AddressModel> Addresses { get; set; }
        public virtual List<ProductModel> Products { get; set; }
        public virtual List<ProductCommentModel> ProductComments { get; set; }
        public virtual List<UserCartModel> UserCarts { get; set; }
    }
}