using System;
using System.Collections.Generic;

namespace BlogAndShop.Data.ViewModel.PostInfo
{
    public class CommentModel
    {
        public string Text { get; set; }
        public string OwnerName { get; set; }
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public List<CommentModel> ChildrenComments { get; set; }

    }
}