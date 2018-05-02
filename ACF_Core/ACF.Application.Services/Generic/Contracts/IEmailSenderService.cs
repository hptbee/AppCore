using System.Collections.Generic;
using System.Threading.Tasks;

namespace ACF.Application.Services.Generic.Contracts
{
    public interface IEmailSenderService
    {
        IDictionary<string, string> GetEmailConfiguration();

        Task SendEmailAsync(string email, string subject, string message);
    }
}
