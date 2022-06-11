using System; using CommonConfiguration.Core.Services.Main;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Email;

using MailMessage = System.Net.Mail.MailMessage;

namespace BlogAndShop.Services.Services.Email
{
    public class EmailAccountService : MainService<EmailAccount>, IEmailAccountService
    {

        #region Fields


        #endregion

        #region Methodes

        public EmailAccount GetDefaultAccount()
        {
            return Run(x => x.UserDefaultCredentials).FirstOrDefault();
        }


        public bool SendEmail(EmailAccount emailAccount, string receiver, string body, string subject, List<string> filePathes)
        {
            try
            {
                //   body = GetTemplate(body);
                var mail = new MailMessage(emailAccount.Email, receiver)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                var client = new SmtpClient
                {
                    Port = emailAccount.Port,
                    Host = emailAccount.Host,
                    EnableSsl = emailAccount.EnableSsl,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailAccount.Email, emailAccount.Password),
                };
                foreach (var temp in filePathes)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + temp;
                    var attach = new Attachment(path);
                    mail.Attachments.Add(attach);
                }

                client.Send(mail);
                return true;
            }
            catch (Exception exp)
            {
                // AddError(exp.Message + " " + exp.InnerException?.Message, ErrorType.RunTimeError, "EmailAccountService");
                return false;
            }
        }

        public bool SendEmailNoTemplate(EmailAccount emailAccount, string reciever, string body, string subject, List<string> filePathes)
        {
            try
            {
                var mail = new MailMessage(emailAccount.Email, reciever)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                var client = new SmtpClient
                {
                    Port = emailAccount.Port,
                    Host = emailAccount.Host,
                    EnableSsl = emailAccount.EnableSsl,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailAccount.Email, emailAccount.Password),
                };
                foreach (var temp in filePathes)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + temp;
                    var attach = new Attachment(path);
                    mail.Attachments.Add(attach);
                }

                client.Send(mail);
                return true;
            }
            catch (Exception exp)
            {
                //AddError(exp.Message + " " + exp.InnerException?.Message, ErrorType.RunTimeError, "EmailAccountService");
                return false;
            }
        }

        public async Task<bool> SendToManyAsync(EmailAccount emailAccount, List<string> recievers, string body, string subject, List<string> filePathes)
        {
            try
            {
                return await Task.Run(async () =>
                {
                    //body = await GetTemplateAsync(body);
                    var mail = new MailMessage()
                    {
                        Subject = subject,
                        Body = body,
                        IsBodyHtml = true,
                    };
                    foreach (var reciever in recievers)
                    {
                        mail.To.Add(reciever);
                    }
                    mail.From = new MailAddress(emailAccount.Email);
                    var client = new SmtpClient
                    {
                        Port = emailAccount.Port,
                        Host = emailAccount.Host,
                        EnableSsl = emailAccount.EnableSsl,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(emailAccount.Email, emailAccount.Password),

                    };
                    foreach (var temp in filePathes)
                    {
                        string path = AppDomain.CurrentDomain.BaseDirectory + temp;
                        var attach = new Attachment(path);
                        mail.Attachments.Add(attach);
                    }
                    client.Send(mail);
                    return true;
                });

            }
            catch (Exception exp)
            {
                //AddError(exp.Message + " " + exp.InnerException?.Message, ErrorType.RunTimeError, "EmailAccountService");
                return await Task.Run(() => false);
            }
        }



        public async Task<bool> SendEmailAsync(EmailAccount emailAccount, string reciever, string body, string subject, List<string> filePathes)
        {
            try
            {
                // body = await GetTemplateAsync(body);
                var from = new MailAddress(emailAccount.Email, emailAccount.DisplayName, System.Text.Encoding.UTF8);
                var to = new MailAddress(reciever);
                var mail = new MailMessage(from, to)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                    BodyEncoding = System.Text.Encoding.UTF8,
                    SubjectEncoding = System.Text.Encoding.UTF8
                };
                var client = new SmtpClient
                {
                    Port = emailAccount.Port,
                    Host = emailAccount.Host,
                    EnableSsl = emailAccount.EnableSsl,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailAccount.Email, emailAccount.Password)
                };
                foreach (var temp in filePathes)
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + temp;
                    var attach = new Attachment(path);
                    mail.Attachments.Add(attach);
                }
                await client.SendMailAsync(mail);
                return true;
            }
            catch (Exception exp)
            {
                // AddError(exp.Message + " " + exp.InnerException?.Message, ErrorType.RunTimeError, "EmailAccountService");
                TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
                tcs.SetResult(false);
                return false;
            }
        }

        public void RemoveDefault()
        {
            var def = GetDefaultAccount();
            def.UserDefaultCredentials = false;
            Update(def);
        }

        #endregion

        #region Utilities
        //private async Task<string> GetTemplateAsync(string text)
        //{
        //    var count = 0;
        //    var fileService = new FileService();
        //    Get:
        //    var path = await Directory.Directory.ReadSettingAsync("EmailTemplatePath");
        //    if (path != null)
        //    {
        //        var domain = AppDomain.CurrentDomain.BaseDirectory;
        //        var file = fileService.ReadFile(domain + path);
        //        if (!string.IsNullOrEmpty(file))
        //        {
        //            file = file.Replace("{{CONTENT}}", text);
        //            return file;
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        count++;
        //        var templateService = new TemplatesService();
        //        var domain = await Directory.Directory.ReadSettingAsync("DomainUrl");
        //        await templateService.SaveEmailNewFileAsync();
        //        goto Get;
        //    }
        //    return text;
        //}
        //private string GetTemplate(string text)
        //{
        //    var count = 0;
        //    var fileService = new FileService();
        //    Get:
        //    var path = Directory.Directory.ReadSetting("EmailTemplatePath");
        //    if (path != null)
        //    {
        //        var domain = AppDomain.CurrentDomain.BaseDirectory;
        //        var file = fileService.ReadFile(domain + path);
        //        if (!string.IsNullOrEmpty(file))
        //        {
        //            file = file.Replace("{{CONTENT}}", text);
        //            return file;
        //        }
        //    }
        //    if (count == 0)
        //    {
        //        count++;
        //        var templateService = new TemplatesService();
        //        var domain = Directory.Directory.ReadSetting("DomainUrl");
        //        templateService.SaveEmailNewFile();
        //        goto Get;
        //    }
        //    return text;
        //}


        #endregion

        #region Ctor
        public EmailAccountService(ApplicationDbContext db) : base(db)
        {
        }



        #endregion



    }
}