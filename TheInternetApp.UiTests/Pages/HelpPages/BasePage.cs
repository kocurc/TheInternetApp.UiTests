using OpenQA.Selenium;

namespace TheInternetApp.UiTests.Pages.HelpPages
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
