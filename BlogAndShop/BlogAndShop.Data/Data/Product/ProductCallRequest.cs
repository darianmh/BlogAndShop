using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Product;
using BlogAndShop.Data.ViewModel.User;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Product
{
    public class ProductCallRequest : BaseEntity
    {
        /// <summary>
        /// محصول
        /// </summary>
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        /// <summary>
        /// اگر لاگین بود اطلاعات کاربر
        /// </summary>
        [ForeignKey("User")]
        public int? UserId { get; set; }
        /// <summary>
        /// شماره تماس
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// توضیحات اضافی
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// وضعیت مشاهده این درخواست
        /// </summary>
        public MessageStatus MessageStatus { get; set; }


        //np
        [JsonIgnore]
        [Ignore]
        public virtual Product Product { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual ApplicationUser User { get; set; }
    }
}
