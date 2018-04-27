using log4net;
using System;
using System.Linq;
using System.Reflection;

namespace ACF.Infrastructure.Core
{
    public static class Check
    {
        private static readonly ILog _logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static void NotNull<T>(T argument, string paramName) where T : class
        {
            if (argument == null)
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static void NotNull<T>(Nullable<T> argument, string paramName) where T : struct
        {
            if (argument == null)
            {
                var message = $"{paramName} cannot be null.";
                _logger.Error(message);
                throw new ArgumentNullException(message);
            }
        }

        public static void NotEmpty(string argument, string paramName)
        {
            if (string.IsNullOrEmpty(argument))
            {
                var message = $"{paramName} cannot be null or empty.";
                _logger.Error(message);
                throw new ArgumentException(message, paramName);
            }
        }

        public static void NotEmpty(Guid argument, string paramName)
        {
            if (argument == Guid.Empty)
            {
                var message = $"{paramName} cannot be empty.";
                _logger.Error(message);
                throw new ArgumentException(message, paramName);
            }
        }

        public static void NotEmpty<T>(T[] argument, string paramName)
        {
            if (argument == null || !argument.Any())
            {
                var message = $"{paramName} cannot be null or empty.";
                _logger.Error(message);
                throw new ArgumentException(message, paramName);
            }
        }
    }
}
