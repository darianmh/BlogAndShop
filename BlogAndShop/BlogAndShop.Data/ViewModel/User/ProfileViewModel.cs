using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAndShop.Data.ViewModel.User
{
    public class ProfileViewModel
    {
        public ApplicationUserModel User { get; set; }
        public List<AddressModel> Addresses { get; set; }
    }
}
