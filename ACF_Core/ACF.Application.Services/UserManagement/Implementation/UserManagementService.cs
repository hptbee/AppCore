using ACF.Application.Contracts.Common;
using ACF.Application.Contracts.UserManagement;
using ACF.Application.Services.Generic.Contracts;
using ACF.Application.Services.UserManagement.Contracts;
using ACF.Infrastructure.Core.Helpers;
using AutoMapper;
using log4net;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ACF.Application.Services.UserManagement.Implementation
{
    public class UserManagementService : IUserManagementService
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(UserManagementService));

        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IEmailSenderService _emailSender;
        private readonly IMapper _mapper;

        public UserManagementService(UserManager<IdentityUser> userManager,
           SignInManager<IdentityUser> signInManager,
           IEmailSenderService emailSender,
           IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            _mapper = mapper;
        }

        public async Task<LoginResultDto> Login(LoginDto model)
        {
            var result = new LoginResultDto();
            try
            {
                var signInResult = await _signInManager.PasswordSignInAsync(model.Username, model.Password, false, true);
                if (signInResult.Succeeded)
                {
                    var appUser = _userManager.Users.SingleOrDefault(r => r.UserName == model.Username);
                    if (appUser.EmailConfirmed)
                    {
                        result.SetInfo(true, "Login successfully");
                        result.User = _mapper.Map<IdentityUser, UserDto>(appUser);
                    }
                    else
                    {
                        result.SetInfo(false, "Email not confirmed yet");
                    }
                }
                else
                {
                    if (!signInResult.IsLockedOut)
                    {
                        result.SetInfo(false, "Username or password is incorrect");
                    }
                    else
                    {
                        result.SetInfo(false, "User has been locked out");
                    }
                }
            }
            catch (Exception ex)
            {
                result.SetInfo(false, ex.Message);
            }
            return result;
        }

        public async Task<ActionResultDto> Register(RegisterDto registerInfo, Func<string, string, string> funcGenVerLink)
        {
            var result = new ActionResultDto();
            try
            {
                var user = new IdentityUser
                {
                    UserName = registerInfo.Username,
                    Email = registerInfo.Email,
                    EmailConfirmed = false
                };
                var createResult = await _userManager.CreateAsync(user, registerInfo.Password);
                result.IsSuccess = createResult.Succeeded;
                if (createResult.Succeeded)
                {
                    var confirmToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = funcGenVerLink(user.Id, confirmToken);
                    await _emailSender.SendEmailAsync(registerInfo.Email, "Confirm your account",
                        $"Please confirm your account by clicking this link: <a href='{callbackUrl}'>Confirm Link</a>");
                    result.Message = "Please check your email and confirm your registration";
                }
                else
                {
                    result.Message = string.Join(" ", createResult.Errors.Select(e => e.Description));
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                result.SetInfo(false, ex.Message);
            }
            return result;
        }

        public async Task<ActionResultDto> VerifyEmail(VerifyEmailDto verifyEmailInfo)
        {
            var result = new ActionResultDto();
            try
            {
                var user = await _userManager.FindByIdAsync(verifyEmailInfo.Id);
                if (user != null)
                {
                    var confirmEmailResult = await _userManager.ConfirmEmailAsync(user, verifyEmailInfo.Token);
                    result.IsSuccess = confirmEmailResult.Succeeded;
                    if (confirmEmailResult.Succeeded)
                    {
                        result.Message = "Email has been confirmed";
                    }
                    else
                    {
                        result.Message = string.Join(" ", confirmEmailResult.Errors.Select(e => e.Description));
                    }
                }
                else
                {
                    result.SetInfo(false, $"User with Id: {verifyEmailInfo.Id} not found");
                }
            } catch (Exception ex)
            {
                _logger.Error(ex);
                result.SetInfo(false, ex.Message);
            }
            return result;
        }

        public string GenerateJwtToken(UserDto user, out DateTime expiredTime)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            var key = new SymmetricSecurityKey(ConfigurationHelper.GetJwtKey());
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            expiredTime = DateTime.Now.AddMinutes(ConfigurationHelper.GetJwtExpireInMinutes());

            var token = new JwtSecurityToken(
                ConfigurationHelper.GetJwtIssuer(),
                ConfigurationHelper.GetJwtIssuer(),
                claims,
                expires: expiredTime,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
