using System;
using System.Configuration;
using System.Reflection;

namespace ConfigLogger
{
    public class AssemblySetting
    {
        public static string LogPath => GetAppSetting("pathLog");
        private static string GetAppSetting(string key)
        {
            try
            {
                var asamPath = Assembly.GetExecutingAssembly().Location;
                var config = ConfigurationManager.OpenExeConfiguration(asamPath);
                var setting = config.AppSettings.Settings[key];
                return setting.Value;
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Error reading configuration setting", e);
            }
        }
    }
}
