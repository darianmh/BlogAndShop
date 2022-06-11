using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.Email;
using CommonConfiguration.Core.Services.Main;


namespace BlogAndShop.Services.Services.Email
{
    public interface IEmailAccountService : IMainService<EmailAccount>
    {
        EmailAccount GetDefaultAccount();

        bool SendEmail(EmailAccount emailAccount, string receiver, string body, string subject, List<string> filePathes);
        bool SendEmailNoTemplate(EmailAccount emailAccount, string reciever, string body, string subject, List<string> filePathes);
        Task<bool> SendToManyAsync(EmailAccount emailAccount, List<string> recievers, string body, string subject, List<string> filePathes);
        Task<bool> SendEmailAsync(EmailAccount emailAccount, string reciever, string body, string subject, List<string> filePathes);
        void RemoveDefault();
    }
}
