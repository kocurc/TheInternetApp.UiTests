using OpenQA.Selenium;

namespace TheInternetApp.UiTests.Pages.InternalPages
{
    internal class AbTestingPage : BasePage, ISubPage
    {
        public const string ExpectedUrl = "http://localhost:7080/abtest";

        public AbTestingPage(IWebDriver driver) : base(driver)
        {

        }

        public AbTestingPage()
        {
            
        }
    }
}
