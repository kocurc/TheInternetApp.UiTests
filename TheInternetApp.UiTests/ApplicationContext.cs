using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;

namespace TheInternetApp.UiTests
{
    public sealed class ApplicationContext
    {
        public static ExeConfigurationFileMap ExeConfigurationFileMap { get; } = new() { ExeConfigFilename = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "TheInternetApp.UiTests.dll.config") };
        public Configuration Configuration { get; set; } = ConfigurationManager.OpenMappedExeConfiguration(ExeConfigurationFileMap, ConfigurationUserLevel.None);
        public string Browser { get; }

        public ApplicationContext()
        {
            Browser = GetApplicationSetting("browser");

            if (Browser == null)
            {
                throw new KeyNotFoundException("Incorrect browser key in app config file.");
            }
        }
        
        private string GetApplicationSetting([NotNull] string settingKey)
        {
            if (settingKey == null)
            {
                throw new ArgumentNullException(nameof(settingKey));
            }

            return Configuration.AppSettings.Settings[settingKey].Value;
        }
    }
}
