using ACF.Application.Contracts.Common;
using ACF.Application.Contracts.UserManagement;
using ACF.Application.Services.UserManagement.Contracts;
using ACF.Infrastructure.Core.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace MyApi.Controllers
{
    [Authorize]
    [Route("api/usermng")]
    public class UserManagementController : Controller
    {
        private readonly IUserManagementService _userMngService;

        public UserManagementController(IUserManagementService userMngService)
        {
            _userMngService = userMngService;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        public async Task<LoginResultDto> Login([FromBody] LoginDto model)
        {
            LoginResultDto result = null;
            try
            {
                result = await _userMngService.Login(model);
                if (result.IsSuccess)
                {
                    DateTime expiredTime = DateTime.MinValue;
                    result.Token = _userMngService.GenerateJwtToken(result.User, out expiredTime);
                    result.ExpiredTimeUTC = expiredTime.ToUniversalTime();
                }
            }
            catch (Exception ex)
            {
                result = new LoginResultDto();
                result.SetInfo(false, ex.Message);
            }
            return result;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("register")]
        public async Task<ActionResultDto> Register([FromBody] RegisterDto model)
        {
            ActionResultDto result = null;
            try
            {
                result = await _userMngService.Register(model, GenerateVerificationLink);
                return result;
            }
            catch (Exception ex)
            {
                result = new LoginResultDto();
                result.SetInfo(false, ex.Message);
            }
            return result;
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("verifyEmail")]
        public async Task<ActionResultDto> VerifyEmail([FromBody] VerifyEmailDto model)
        {
            ActionResultDto result = null;
            try
            {
                result = await _userMngService.VerifyEmail(model);
                return result;
            } catch (Exception ex)
            {
                result = new ActionResultDto();
                result.SetInfo(false, ex.Message);
            }
            return result;
        }

        [HttpGet]
        [Route("test")]
        public async Task<object> Test()
        {
            return "Protected area";
        }

        private string GenerateVerificationLink(string userId, string confirmToken)
        {
            string verifyUrlFormat = ConfigurationHelper.GetConfigValue("VerifyEmailUrlFormat");
            return string.Format(verifyUrlFormat, WebUtility.UrlEncode(userId), WebUtility.UrlEncode(confirmToken));
        }
    }
}
