using OpenQA.Selenium;

namespace TheInternetApp.UiTests.Pages
{
    public interface ISubPage
    {
        void Initialize(IWebDriver driver);
    }
}