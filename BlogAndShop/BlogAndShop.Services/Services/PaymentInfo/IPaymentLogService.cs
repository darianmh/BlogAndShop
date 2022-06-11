using System; using CommonConfiguration.Core.Services.Main;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.PaymentInfo;


namespace BlogAndShop.Services.Services.PaymentInfo
{
    public interface IPaymentLogService : IMainService<PaymentLog>
    {
    }
}
