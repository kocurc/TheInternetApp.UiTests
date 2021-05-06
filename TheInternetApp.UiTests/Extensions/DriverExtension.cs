using System.Linq;
using OpenQA.Selenium;

namespace TheInternetApp.UiTests.Extensions
{
    public static class DriverExtension
    {
        public static void SwitchToLastWindow(this IWebDriver driver)
        {
            var lastOpenWindow = driver.WindowHandles.Last();

            driver.SwitchTo().Window(lastOpenWindow);
        }
    }
}
