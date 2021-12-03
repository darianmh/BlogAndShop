using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;

namespace BlogAndShop.Services.Services.Common.SenderServices
{
    /// <summary>
    /// send messaged with sms and email
    /// </summary>
    public interface ISendService
    {
        /// <summary>
        /// ارسال پیام به کاربر از طریق اس ام اس و ایمیل
        /// </summary>
        /// <param name="user"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        Task<bool> Send(ApplicationUser user, string text);
    }
}