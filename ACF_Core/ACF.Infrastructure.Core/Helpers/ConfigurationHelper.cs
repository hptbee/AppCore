using Microsoft.Extensions.Configuration;
using System.IO;

namespace ACF.Infrastructure.Core.Helpers
{
    public static class ConfigurationHelper
    {
        #region Constants

        public const string DEFAULT_CONFIG_FILE = "appsettings.json";
        public const string KEY_DEFAULT_CONNECTION_STRING = "ConnectionStrings:DefaultConnection";

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
        #region Methods

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
        
        public static string GetDefaultConnectionConfig()
        {
            return GetConfigValue(KEY_DEFAULT_CONNECTION_STRING);
        }

        #endregion Methods
    }
}
