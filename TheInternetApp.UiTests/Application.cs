using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TheInternetApp.UiTests.Extensions;

namespace TheInternetApp.UiTests
{
    internal class Application
    {
        private readonly string _binWorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public IWebDriver Driver { get; set; }
        public ApplicationContext AppContext { get; init; } = new();

        public Application()
        {
            HandleBrowserContext();
        }

        public void CloseApplication()
        {
            Driver.Close();
            Driver.Dispose();
            Driver.KillChromeDriverProcess();
        }

        private void HandleBrowserContext()
        {
            Driver = AppContext.Browser switch
            {
                "chrome" => new ChromeDriver(_binWorkingDirectory),
                "firefox" => new FirefoxDriver(_binWorkingDirectory),
                _ => throw new ArgumentOutOfRangeException(nameof(AppContext.Browser), "Browser key in config file is not supported.")
            };
        }
    }
}
