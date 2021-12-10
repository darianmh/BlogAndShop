using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAndShop.Data.ViewModel.Admin
{
    public class NewNotificationModel
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Id { get; set; }
        public NewNotificationType NewNotificationType { get; set; }
    }
}
