using OpenQA.Selenium;
using TheInternetApp.UiTests.Pages.HelpPages;

namespace TheInternetApp.UiTests.Pages
{
    internal class BasePage : Page
    {
        public override string Url
        {
            get => Driver.Url;
            set => Driver.Url = value;
        }

        public override string Title => Driver.Title;

        public BasePage(IWebDriver driver) : base(driver)
        {

        }

        protected BasePage()
        {

        }
    }
}
