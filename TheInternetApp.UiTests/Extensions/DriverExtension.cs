using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium;

namespace TheInternetApp.UiTests.Extensions
{
    public static class DriverExtension
    {
        private const string ChromeProcessName = "chromedriver";

        public static void SwitchToLastWindow(this IWebDriver driver)
        {
            var lastOpenWindow = driver.WindowHandles.Last();

            driver.SwitchTo().Window(lastOpenWindow);
        }

        public static void KillChromeDriverProcess(this IWebDriver driver)
        { 
            Process.GetProcessesByName(ChromeProcessName).ToList().ForEach(chromeProcess => chromeProcess.Kill());
        }
    }
}
