﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.User
{
    /// <summary>
    /// دسترسی های نقش
    /// </summary>
    public class RoleAccessModel : BaseEntityModel
    {
        /// <summary>
        /// هر اکشنی یک اتریبیوت دارد 
        ///که نام و وظیفه آنرا تعیین می کند
        /// </summary>
        [Display(Name = "نام اتریبیوت")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public string AttrName { get; set; }

        /// <summary>
        /// نقش
        /// </summary>
        [ForeignKey("ApplicationRole")]
        [Display(Name = "نقش")]
        [Required(ErrorMessage = "{0} الزامی است")]
        public int RoleId { get; set; }


        //np
        public virtual ApplicationRoleModel ApplicationRole { get; set; }
    }
}