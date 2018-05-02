using ACF.Application.Services.Generic.Contracts;
using ACF.Infrastructure.Core.Helpers;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ACF.Application.Services.Generic.Implementation
{
    public class EmailSenderService : IEmailSenderService
    {
        public const string CONFIG_MAIL_SERVER = "MailServer";
        public const string CONFIG_MAIL_PORT = "MailPort";
        public const string CONFIG_MAIL_ENABLE_SSL = "MailEnableSsl";
        public const string CONFIG_MAIL_ADDRESS = "MailAddress";
        public const string CONFIG_MAIL_USERNAME = "MailUser";
        public const string CONFIG_MAIL_PASSWORD = "MailPassword";

        public IDictionary<string, string> GetEmailConfiguration()
        {
            IDictionary<string, string> emailConfig = new Dictionary<string, string>();
            emailConfig.Add(CONFIG_MAIL_SERVER, ConfigurationHelper.GetConfigValue(CONFIG_MAIL_SERVER));
            emailConfig.Add(CONFIG_MAIL_PORT, ConfigurationHelper.GetConfigValue(CONFIG_MAIL_PORT));
            emailConfig.Add(CONFIG_MAIL_ENABLE_SSL, ConfigurationHelper.GetConfigValue(CONFIG_MAIL_ENABLE_SSL));
            emailConfig.Add(CONFIG_MAIL_ADDRESS, ConfigurationHelper.GetConfigValue(CONFIG_MAIL_ADDRESS));
            emailConfig.Add(CONFIG_MAIL_USERNAME, ConfigurationHelper.GetConfigValue(CONFIG_MAIL_USERNAME));
            emailConfig.Add(CONFIG_MAIL_PASSWORD, ConfigurationHelper.GetConfigValue(CONFIG_MAIL_PASSWORD));
            return emailConfig;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailConfig = GetEmailConfiguration();
            using (var client = new SmtpClient()
            {
                Host = emailConfig[CONFIG_MAIL_SERVER],
                Port = int.Parse(emailConfig[CONFIG_MAIL_PORT]),
                EnableSsl = bool.Parse(emailConfig[CONFIG_MAIL_ENABLE_SSL]),
                Credentials = new NetworkCredential(emailConfig[CONFIG_MAIL_USERNAME], emailConfig[CONFIG_MAIL_PASSWORD])
            })
            {
                using (var mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(emailConfig[CONFIG_MAIL_ADDRESS]);
                    mailMessage.To.Add(email);
                    mailMessage.Body = message;
                    mailMessage.Subject = subject;
                    await client.SendMailAsync(mailMessage);
                }
            }
        }
    }
}
