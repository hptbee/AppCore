﻿using ACF.Infrastructure.Core.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;

namespace ACF.DistributedServices.API
{
    public static class SecurityConfiguration
    {
        /// <summary>
        /// Configure OAuth - JWT
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureOAuth(IConfiguration configuration, IServiceCollection services)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear(); // => remove default claims
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

                })
                .AddJwtBearer(cfg =>
                {
                    cfg.RequireHttpsMetadata = false;
                    cfg.SaveToken = true;
                    cfg.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidIssuer = ConfigurationHelper.GetJwtIssuer(),
                        ValidAudience = ConfigurationHelper.GetJwtIssuer(),
                        IssuerSigningKey = new SymmetricSecurityKey(ConfigurationHelper.GetJwtKey()),
                        ClockSkew = TimeSpan.Zero // remove delay of token when expire
                    };
                });
        }
    }
}
