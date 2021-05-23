using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace TheInternetApp.UiTests
{
    public sealed class ApplicationContext
    {
        #region Sections

        

        #endregion

        #region Settings

        public string IsIncognitoSwitch { get; }
        public string IsStartMaximizedSwitch { get; }
        public string WindowSizeSwitch { get; }
        public string IsUserMobileUserAgent { get; }

        #endregion

        public ApplicationContext()
        {

        }

        private static string GetApplicationSetting([NotNull] string section, [NotNull] string settingKey)
        {
            if (section == null)
            {
                throw new ArgumentNullException(nameof(section));
            }

            if (settingKey == null)
            {
                throw new ArgumentNullException(nameof(settingKey));
            }

            var collection = ConfigurationManager.GetSection(section) as NameValueCollection;

            return collection[settingKey];
        }
    }
}
