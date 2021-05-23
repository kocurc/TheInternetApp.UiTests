using System.Diagnostics.CodeAnalysis;
using OpenQA.Selenium;

namespace TheInternetApp.UiTests.Pages.HelpPages
{
    public class PageBehaviour
    {
        private IWebDriver Driver { get; set; }

        public void Initialize(IWebDriver driver)
        {
            Driver = driver;
        }

        #region IJavaScriptExecutor

        public void ScrollToTheBottom()
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight");
        }

        #endregion

        #region ElementsBehaviour

        public bool IsPageElementVisible([NotNull] IWebElement element)
        {
            return element.Displayed;
        }

        public bool IsElementActive([NotNull] IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        #endregion
    }
}
