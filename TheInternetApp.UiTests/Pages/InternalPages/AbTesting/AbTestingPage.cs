using System.Reflection;
using OpenQA.Selenium;
using TheInternetApp.UiTests.Pages.HelpPages;
using TheInternetApp.UiTests.Helpers;

namespace TheInternetApp.UiTests.Pages.InternalPages.AbTesting
{
    internal class AbTestingPage : BasePage, ISubPage
    {
        #region Constants

        public const string ExpectedLocalUrl = "http://localhost:7080/abtest";
        public const string ExpectedRemoteUrl = "http://the-internet.herokuapp.com/abtest";

        #endregion

        #region IWebElements

        public IWebElement MainHeader => Driver.FindElement(By.TagName("h3"));
        public IWebElement MainParagraph => Driver.FindElement(By.TagName("p"));

        #endregion

        public string MainParagraphExpectedText => FileHelper.ReadFile(@"./Pages/InternalPages/AbTesting/MainParagraph.txt");

        public AbTestingPage(IWebDriver driver) : base(driver) { }
        public AbTestingPage() { }

        public override void OpenPage()
        {
            Driver.Navigate().GoToUrl(ExpectedRemoteUrl);
        }
    }
}
