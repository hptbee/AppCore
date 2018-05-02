using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Text;

namespace ACF.Infrastructure.Core.Helpers
{
    public static class ConfigurationHelper
    {
        #region Constants

        public const string DEFAULT_CONFIG_FILE = "appsettings.json";
        public const string KEY_DEFAULT_CONNECTION_STRING = "ConnectionStrings:DefaultConnection";

        public const string KEY_JWT_ISSUER = "JwtIssuer";
        public const string KEY_JWT_KEY = "JwtKey";
        public const string KEY_JWT_EXPIRE_IN_MINUTES = "JwtExpireInMinutes";

        #endregion Constants
        #region Members

        private static IConfigurationRoot _configurationRoot;

        #endregion Members
        #region Constructors

        static ConfigurationHelper()
        {
            _configurationRoot = LoadConfigFile(DEFAULT_CONFIG_FILE);
        }

        #endregion Constructors
        #region Generic Methods

        public static IConfigurationRoot LoadConfigFile(string configFile)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(configFile);
            var configuration = builder.Build();
            return configuration;
        }
        
        public static string GetConfigValue(string configKey)
        {
            string connString = _configurationRoot[configKey];
            return connString;
        }

        public static int GetIntConfigValue(string configKey)
        {
            return int.Parse(GetConfigValue(configKey));
        }

        #endregion Generic Methods
        #region Get-Config Methods

        public static string GetDefaultConnectionConfig()
        {
            return GetConfigValue(KEY_DEFAULT_CONNECTION_STRING);
        }

        public static string GetJwtIssuer()
        {
            return GetConfigValue(KEY_JWT_ISSUER);
        }

        public static double GetJwtExpireInMinutes()
        {
            return Convert.ToDouble(GetConfigValue(KEY_JWT_EXPIRE_IN_MINUTES));
        }

        public static byte[] GetJwtKey()
        {
            return Encoding.UTF8.GetBytes(GetConfigValue(KEY_JWT_KEY));
        }

        #endregion Get-Config Methods
    }
}
