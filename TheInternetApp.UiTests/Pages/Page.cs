using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TheInternetApp.UiTests.Pages
{
    internal abstract class Page
    {
        protected IWebDriver Driver { get; set; }

        public abstract string Url { get; set; }
        public abstract string Title { get; }

        protected Page(IWebDriver driver)
        {
            Driver = driver;
        }

        protected Page()
        {
            
        }

        public void WaitForPageToBeLoaded()
        {
            var webDriverWait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));

            webDriverWait.Until(driver => ((IJavaScriptExecutor) driver).ExecuteScript("return document.readyState").Equals("complete"));
        }
        public void Initialize(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
