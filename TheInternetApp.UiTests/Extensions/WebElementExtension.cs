using OpenQA.Selenium;

namespace TheInternetApp.UiTests.Extensions
{
    public static class WebElementExtension
    {
        public static bool DoesAnchorWebElementPointToHref(this IWebElement webElement, string hrefValue)
        {
            return webElement.GetAttribute("href").Equals(hrefValue);
        }
    }
}
