using System;
using System.Collections.Generic;
using System.Linq;
using BlogAndShop.Data.ViewModel.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BlogAndShop.Data.Data.User
{
    public class ApplicationRole : IdentityRole<int>
    {
        //np
        [JsonIgnore]
        public virtual List<RoleAccess> RoleAccesses { get; set; }


        public MySelectListItem GetSelectListItem(string selected)
        {
            var array = (JArray)JsonConvert.DeserializeObject(selected);
            var selectedValues = array != null ? array.Select(Convert.ToInt32).ToList() : new List<int>();
            return new MySelectListItem(Name, Id.ToString(), selectedValues.Contains(Id));
        }
    }
}