using System.Threading.Tasks;

namespace ACF.Application.Services.Generic.Contracts
{
    public interface ISmsSenderService
    {
        Task SendSmsAsync(string number, string message);
    }
}
