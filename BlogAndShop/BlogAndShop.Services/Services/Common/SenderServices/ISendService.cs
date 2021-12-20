using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;

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
        /// <param name="subject"></param>
        /// <returns></returns>
        Task<bool> Send(ApplicationUser user, string text, string subject);

        /// <summary>
        /// ارسال پیام به کاربر از طریق اس ام اس یا ایمیل
        /// </summary>
        /// <param name="user"></param>
        /// <param name="text"></param>
        /// <param name="sendType"></param>
        /// <param name="subject"></param>
        /// <returns></returns>
        Task<bool> Send(ApplicationUser user, string text, MessageSendType sendType, string subject);
        /// <summary>
        /// ارسال اعلانات برای ادمین
        /// از طریق ایمیل و پیامک
        /// </summary>
        /// <param name="text"></param>
        /// <param name="subject"></param>
        /// <returns></returns>
        Task<bool> SendNotification(string text, string subject);

        /// <summary>
        /// ارسال اعلانات برای ادمین
        /// از طریق ایمیل یا پیامک
        /// </summary>
        /// <param name="text"></param>
        /// <param name="subject"></param>
        /// <param name="sendType"></param>
        /// <returns></returns>
        Task<bool> SendNotification(string text, string subject, MessageSendType sendType);
    }
}