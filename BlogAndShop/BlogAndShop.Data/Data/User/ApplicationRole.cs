using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace BlogAndShop.Data.Data.User
{
    public class ApplicationRole : IdentityRole<int>
    {
        //np
        [JsonIgnore]
        public virtual List<RoleAccess> RoleAccesses { get; set; }
    }
}