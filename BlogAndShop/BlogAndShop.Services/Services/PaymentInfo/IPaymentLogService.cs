using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PaymentInfo;
using BlogAndShop.Services.Services.Main;

namespace BlogAndShop.Services.Services.PaymentInfo
{
    public interface IPaymentLogService : IMainService<PaymentLog>
    {
    }
}
