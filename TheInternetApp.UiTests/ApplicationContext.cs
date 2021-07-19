using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TheInternetApp.UiTests
{
    public sealed class ApplicationContext
    {
        public static ExeConfigurationFileMap ExeConfigurationFileMap { get; } = new() { ExeConfigFilename = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, "TheInternetApp.UiTests.dll.config") };
        public Configuration Configuration { get; init; } = ConfigurationManager.OpenMappedExeConfiguration(ExeConfigurationFileMap, ConfigurationUserLevel.None);
        public string Browser { get; }

        public ApplicationContext()
        {
            Browser = GetApplicationSetting("browser");
            Console.WriteLine(1.0.GetType());

            if (Browser == null)
            {
                throw new KeyNotFoundException("Incorrect browser key in app config file.");
            }

            string x;
        }
        
        private string GetApplicationSetting([NotNull] string settingKey)
        {
            if (settingKey == null)
            {
                throw new ArgumentNullException(nameof(settingKey));
            }

            return Configuration.AppSettings.Settings[settingKey].Value;
        }

        #region Indexers

        public string this[string key]
        {
            get
            {
                if (!Configuration.AppSettings.Settings.AllKeys.Contains(key))
                {
                    throw new ArgumentOutOfRangeException(nameof(key), $"Dictionary of app.config does not contain key: {key}.");
                }

                return Configuration.AppSettings.Settings[key].Value;
            }
            set
            {
                if (!Configuration.AppSettings.Settings.AllKeys.Contains(key))
                {
                    throw new ArgumentOutOfRangeException(nameof(key), $"Dictionary of app.config does not contain key: {key}.");
                }

                Configuration.AppSettings.Settings[key].Value = value;
            }
        }

        #endregion
    }
}
