using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Classes;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.ViewModel.Utilities;
using CommonConfiguration.Core.Data.ViewModel.Utilities;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.LearningSystem
{
    public class LearningSiteConfig : BaseEntity
    {
        /// <summary>
        /// عنوان سایت
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// متن معرفی در شروع
        /// </summary>
        public string AboutText { get; set; }
        /// <summary>
        /// متن فوتر
        /// </summary>
        public string FooterText { get; set; }
        /// <summary>
        /// عنوان متا
        /// </summary>
        public string MetaTitle { get; set; }
        /// <summary>
        /// توضیحات متا
        /// </summary>
        public string MetaDescription { get; set; }
        /// <summary>
        /// آیکون
        /// </summary>
        [ForeignKey("Icon")]
        public int IconId { get; set; }


        //np
        public virtual List<Course> Courses { get; set; }
        [JsonIgnore]
        [Ignore]
        public virtual Media Icon { get; set; }





        public override MySelectListItem GetSelectListItem(string selected)
        {
            return new MySelectListItem(Title, Id.ToString(), Id.ToString().Equals(selected, StringComparison.OrdinalIgnoreCase));
        }
    }
}
