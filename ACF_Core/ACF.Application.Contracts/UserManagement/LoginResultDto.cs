using ACF.Application.Contracts.Common;
using System;

namespace ACF.Application.Contracts.UserManagement
{
    public class LoginResultDto : ActionResultDto
    {
        /// <summary>
        /// User information
        /// </summary>
        public UserDto User { get; set; }

        /// <summary>
        /// AccessToken used for API OAuth
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Expired time of token in UTC time zone
        /// </summary>
        public DateTime? ExpiredTimeUTC { get; set; }
    }
}
