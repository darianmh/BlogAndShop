using System;
using System.Collections.Generic;
using System.Linq;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.Data.Product;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.User
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Family { get; set; }



        //np
        [JsonIgnore]
        public virtual List<Post> Posts { get; set; }
        [JsonIgnore]
        public virtual List<UserToken> UserTokens { get; set; }
        [JsonIgnore]
        public virtual List<Tag> Tags { get; set; }
        [JsonIgnore]
        public virtual List<Payment> Payments { get; set; }
        [JsonIgnore]
        public virtual List<ForumTitle> ForumTitles { get; set; }
        [JsonIgnore]
        public virtual List<ForumComment> ForumComments { get; set; }
        [JsonIgnore]
        public virtual List<PostComment> PostComments { get; set; }
        [JsonIgnore]
        public virtual List<Address> Addresses { get; set; }
        [JsonIgnore]
        public virtual List<Product.Product> Products { get; set; }
        [JsonIgnore]
        public virtual List<ProductComment> ProductComments { get; set; }
        [JsonIgnore]
        public virtual List<UserCart> UserCarts { get; set; }
        [JsonIgnore]
        public virtual List<ProductCallRequest> ProductCallRequests { get; set; }

        public bool IsSuperAdmin { get; set; }


        public SelectListItem GetSelectListItem(string selected)
        {
            try
            {
                //اگر لیستی از محصولات باشد
                var allSelected = (List<int>)JsonConvert.DeserializeObject(selected);

                return new SelectListItem(Email, Id.ToString(), selected: allSelected.Any(x => Id.ToString().Equals(x.ToString(), StringComparison.OrdinalIgnoreCase)));
            }
            catch
            {
                //اگر تک باشد
                return new SelectListItem(Email, Id.ToString(),selected: Id.ToString().Equals(selected.ToString(), StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}