using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.Product
{
    public class DownloadItem : BaseEntity
    {
        [ForeignKey("DownloadPath")]
        public int DownloadPathId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Keywords { get; set; }
        [ForeignKey("BannerImage")]
        public int BannerImageId { get; set; }


        //np
        [JsonIgnore]
        public virtual Media DownloadPath { get; set; }
        [JsonIgnore]
        public virtual Media BannerImage { get; set; }
    }
}