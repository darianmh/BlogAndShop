using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;

namespace BlogAndShop.Services.Services.Common.SenderServices
{
    public class SendService : ISendService
    {
        public async Task<bool> Send(ApplicationUser user, string text)
        {
            return true;
        }
    }
}