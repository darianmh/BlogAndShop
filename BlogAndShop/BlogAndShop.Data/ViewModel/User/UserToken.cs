using System.ComponentModel.DataAnnotations.Schema;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;

namespace BlogAndShop.Data.ViewModel.User
{
    public class UserTokenModel : BaseEntityModel
    {
        [ForeignKey("User")]
        public int UserId { get; set; }
        public UserTokenType UserTokenType { get; set; }
        public string Token { get; set; }

        //np
        public virtual ApplicationUserModel User { get; set; }
    }

}
