using log4net;
using System;
using System.Reflection;

namespace ACF.Infrastructure.Core
{
    public static class Logger
    {
        private readonly static ILog Log;

        static Logger()
        {
            var loggerName = string.Empty;
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                loggerName = declaringType.Name;
            }
            Log = LogManager.GetLogger(loggerName);

            log4net.Config.XmlConfigurator.Configure();
        }

        public static void Error(object msg)
        {
            Log.Error(msg);
        }

        public static void Error(object msg, Exception ex)
        {
            Log.Error(msg, ex);
        }

        public static void Error(Exception ex)
        {
            Log.Error(ex.Message, ex);
        }

        public static void Info(object msg)
        {
            Log.Info(msg);
        }

        public static void Debug(object msg)
        {
            Log.Debug(msg);
        }
    }
}