using NUnit.Framework;
using TechTalk.SpecFlow;
using TheInternetApp.UiTests.Pages;
using TheInternetApp.UiTests.Pages.InternalPages;

namespace TheInternetApp.UiTests.Steps
{
    [Binding]
    [Scope(Feature = "Home")]
    public class HomeSteps : MainSteps
    {
        private HomePage Home { get; set; }
        private AbTestingPage AbTestPage { get; set; }

        [BeforeScenario]
        public void RunBeforeScenario()
        {
            Home = new HomePage(Driver);
        }

        [Given(@"I have opened home page")]
        public void GivenIHaveOpenedHomePage()
        {
            Home.OpenPage();
        }

        [Then(@"Home page title is '(.*)'")]
        public void ThenHomePageTitleIs(string pageTitle)
        {
            Assert.AreEqual(pageTitle, Home.Title, "Home page title is incorrect.");
        }

        [Then(@"Welcome header is '(.*)'")]
        public void ThenWelcomeHeaderIs(string welcomeHeader)
        {
            Assert.AreEqual(welcomeHeader, Home.WelcomeHeader.Text, "Welcome header on home page is incorrect.");
        }

        [Then(@"Links header is '(.*)'")]
        public void ThenLinksHeaderIs(string linksHeader)
        {
            Assert.AreEqual(linksHeader, Home.LinksHeader.Text, "Header of links on home page is incorrect.");
        }

        [When(@"I click on '(.*)' link")]
        public void WhenIClickOnLink(string subPage)
        {
            AbTestPage = Home.NavigateToSubPage<AbTestingPage>(subPage);
        }

        [Then(@"'(.*)' page has been opened")]
        public void ThenPageHasBeenOpened(string pageUrl)
        {
            Assert.AreEqual(AbTestingPage.ExpectedUrl, AbTestPage.Url, "Incorrect URL of A/B Testing page.");
        }
    }
}
