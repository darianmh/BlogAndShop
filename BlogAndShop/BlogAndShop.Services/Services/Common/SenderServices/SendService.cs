using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlogAndShop.Data.Data.User;
using BlogAndShop.Data.ViewModel.Common;
using BlogAndShop.Services.Services.Email;

namespace BlogAndShop.Services.Services.Common.SenderServices
{
    public class SendService : ISendService
    {
        #region Fields

        private readonly IEmailAccountService _emailAccountService;
        private readonly ISiteConfigService _siteConfigService;


        #endregion
        #region Methods
        public async Task<bool> Send(ApplicationUser user, string text, string subject)
        {
            //sms
            var checkSms = await Send(user, text, MessageSendType.Sms, subject);
            //email
            var checkMail = await Send(user, text, MessageSendType.Email, subject);
            return checkMail && checkSms;
        }

        public async Task<bool> Send(ApplicationUser user, string text, MessageSendType sendType, string subject)
        {
            switch (sendType)
            {
                case MessageSendType.Email:
                    return await SendEmailAsync(user.Email, text, subject);
                case MessageSendType.Sms:
                    return await SendSmsAsync(user.PhoneNumber, text);
            }

            return false;
        }

        public async Task<bool> SendNotification(string text, string subject)
        {
            //sms
            var checkSms = await SendNotification(text, subject, MessageSendType.Sms);
            //email
            var checkMail = await SendNotification(text, subject, MessageSendType.Email);
            return checkMail && checkSms;
        }

        public async Task<bool> SendNotification(string text, string subject, MessageSendType sendType)
        {
            switch (sendType)
            {
                case MessageSendType.Email:
                    {
                        var emails = await _siteConfigService.GetAdminEmails();
                        return await SendEmailAsync(emails, text, subject);
                    }
                case MessageSendType.Sms:
                    {
                        var phoneNumbers = await _siteConfigService.GetAdminPhoneNumbers();
                        return await SendSmsAsync(phoneNumbers, text);
                    }
            }

            return false;
        }


        #endregion
        #region Utilities

        private async Task<bool> SendSmsAsync(List<string> phoneNumbers, string text)
        {
            foreach (var phoneNumber in phoneNumbers)
            {
                await SendSmsAsync(phoneNumber, text);
            }

            return true;
        }

        private async Task<bool> SendEmailAsync(List<string> emails, string text, string subject)
        {
            foreach (var email in emails)
            {
                await SendEmailAsync(email, text, subject);
            }

            return true;
        }
        private async Task<bool> SendEmailAsync(string email, string text, string subject)
        {
            var defEmail = _emailAccountService.GetDefaultAccount();
            if (defEmail == null) return false;
            if (string.IsNullOrEmpty(email)) return false;
            return await _emailAccountService.SendEmailAsync(defEmail, email, text, subject, new List<string>());
        }
        private async Task<bool> SendSmsAsync(string phoneNumber, string text)
        {
            return true;
        }

        #endregion
        #region Ctor
        public SendService(IEmailAccountService emailAccountService, ISiteConfigService siteConfigService)
        {
            _emailAccountService = emailAccountService;
            _siteConfigService = siteConfigService;
        }

        #endregion


    }
}