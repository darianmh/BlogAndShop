namespace BlogAndShop.Data.ViewModel.Forum
{
    /// <summary>
    /// مدل کوچک برای نمایش انجمن در لیست یاپیشنهادات
    /// </summary>
    public class ForumMiniModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public string Description { get; set; }
        public int CommentsCount { get; set; }
        public int UsersCount { get; set; }
    }
}