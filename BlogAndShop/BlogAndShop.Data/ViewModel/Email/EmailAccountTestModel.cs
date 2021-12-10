using BlogAndShop.Data.Classes;

namespace BlogAndShop.Data.ViewModel.Email
{
    public class EmailAccountTestModel
    {
        [Hidden]
        public int Id { get; set; }

        public string Email { get; set; }
        public string Text { get; set; }
    }
}