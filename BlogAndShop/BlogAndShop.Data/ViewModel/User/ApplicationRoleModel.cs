using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace BlogAndShop.Data.ViewModel.User
{
    public class ApplicationRoleModel /*: IdentityRole<int>*/
    {
        public int Id { get; set; }
        //np
        public virtual List<RoleAccessModel> RoleAccesses { get; set; }
    }
}