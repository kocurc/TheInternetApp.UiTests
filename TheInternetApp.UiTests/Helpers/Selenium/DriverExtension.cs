using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TheInternetApp.UiTests.Helpers.Selenium
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
