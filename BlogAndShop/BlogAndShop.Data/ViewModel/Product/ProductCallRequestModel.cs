using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Data.ViewModel.User;
using CommonConfiguration.Core.Data.Data.User;
using CommonConfiguration.Core.Data.ViewModel.Common;
using CommonConfiguration.Core.Data.ViewModel.User;
using Newtonsoft.Json;

namespace BlogAndShop.Data.ViewModel.Product
{
    public class ProductCallRequestModel : BaseEntityModel
    {
        /// <summary>
        /// محصول
        /// </summary>

        [Display(Name = "محصول")]
        [DbOptionList(typeof(Data.Product.Product), false)]
        [ForeignKey("Product")]
        [Required]
        public int ProductId { get; set; }
        /// <summary>
        /// اگر لاگین بود اطلاعات کاربر
        /// </summary>
        [Display(Name = "کاربر")]
        [DbOptionList(typeof(ApplicationUser), true)]
        [ForeignKey("User")]
        public int? UserId { get; set; }
        /// <summary>
        /// شماره تماس
        /// </summary>
        [Display(Name = "شماره تماس")]
        [AdminShowItem(2)]
        [Required]
        public string PhoneNumber { get; set; }
        /// <summary>
        /// نام
        /// </summary>
        [Display(Name = "نام")]
        [AdminShowItem(1)]
        public string Name { get; set; }
        /// <summary>
        /// توضیحات اضافی
        /// </summary>
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        /// <summary>
        /// وضعیت مشاهده این درخواست
        /// </summary>
        [Display(Name = "وضعیت مشاهده")]
        [EnumList(typeof(MessageStatus))]
        [AdminShowItem(3)]
        public MessageStatus MessageStatus { get; set; }


        //np
        [JsonIgnore]
        [Ignore]
        public virtual ProductModel Product { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual ApplicationUserModel User { get; set; }
    }
}
