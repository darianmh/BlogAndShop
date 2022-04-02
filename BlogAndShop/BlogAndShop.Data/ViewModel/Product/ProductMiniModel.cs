namespace BlogAndShop.Data.ViewModel.Product
{
    /// <summary>
    /// مدل کوچک برای نمایش محصول در لیست یاپیشنهادات
    /// </summary>
    public class ProductMiniModel
    {
        public string BannerImage { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public decimal? OffPrice { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}