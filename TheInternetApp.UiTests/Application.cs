using System;
using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TheInternetApp.UiTests
{
    internal class Application
    {
        private readonly string _binWorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public IWebDriver Driver { get; set; } 
        public ApplicationContext AppContext { get; set; } = new();

        public Application()
        {
            HandleBrowserContext();
        }

        public void CloseApplication()
        {
            Driver.Close();
            Driver.Dispose();
        }
        private void HandleBrowserContext()
        {
            /*Driver = AppContext.Browser switch
            {
                "chrome" => new ChromeDriver(_binWorkingDirectory),
                "firefox" => new FirefoxDriver(_binWorkingDirectory),
                _ => throw new ArgumentOutOfRangeException(nameof(AppContext.Browser), "Browser key in config file is not supported.")
            };*/
            
            Driver = AppContext.Browser switch
            {
                "chrome" => new ChromeDriver(_binWorkingDirectory, GetChromeOptions()),
                "firefox" => new FirefoxDriver(_binWorkingDirectory),
                _ => throw new ArgumentOutOfRangeException(nameof(AppContext.Browser), "Browser key in config file is not supported.")
            };
        }

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions chromeOptions = new();
            chromeOptions.AddArgument("--headless");

            return chromeOptions;
        }
    }
}
