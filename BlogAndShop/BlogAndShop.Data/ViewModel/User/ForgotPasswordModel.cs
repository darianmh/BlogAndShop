using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAndShop.Data.ViewModel.User
{
    public class ForgotPasswordModel
    {
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
