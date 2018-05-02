using ACF.Application.Contracts.Common;
using ACF.Application.Contracts.UserManagement;
using System;
using System.Threading.Tasks;

namespace ACF.Application.Services.UserManagement.Contracts
{
    public interface IUserManagementService
    {
        Task<LoginResultDto> Login(LoginDto loginInfo);

        Task<ActionResultDto> Register(RegisterDto registrationInfo, Func<string, string, string> funcGenVerLink);

        Task<ActionResultDto> VerifyEmail(VerifyEmailDto verifyEmailInfo);

        string GenerateJwtToken(UserDto user, out DateTime expiredTime);
    }
}
