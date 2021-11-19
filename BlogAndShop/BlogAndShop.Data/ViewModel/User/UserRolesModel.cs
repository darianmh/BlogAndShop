using Microsoft.AspNetCore.Identity;

namespace BlogAndShop.Data.ViewModel.User
{
    /// <summary>
    /// ارتباط کاربر و نقش
    /// </summary>
    public class UserRolesModel /*: IdentityUserRole<int>*/
    {
        public int UserId { get; set; }
    }
}