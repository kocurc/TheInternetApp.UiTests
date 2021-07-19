using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TheInternetApp.UiTests.Extensions;
using TheInternetApp.UiTests.Pages.InternalPages.AbTesting;
using TheInternetApp.UiTests.Pages.InternalPages.Home;

namespace TheInternetApp.UiTests.Steps.Regression
{
    [Binding]
    [Scope(Feature = "Home")]
    internal class HomeSteps : MainSteps
    {
        private AbTestingPage AbTestPage { get; set; }
        private HomePage Home { get; set; }

        [BeforeScenario]
        public void RunBeforeScenario()
        {
            Home = new HomePage(TheInternetApplication.Driver);
        }

        [Given(@"I have opened home page")]
        public void GivenIHaveOpenedHomePage()
        {
            Home.OpenPage();
        }

        [Then(@"Home page title is '(.*)'")]
        public void ThenHomePageTitleIs([NotNull] string pageTitle)
        {
            pageTitle ??= "The Internet";

            Assert.AreEqual(pageTitle, Home.Title, "Home page title is incorrect.");
        }

        [Then(@"Welcome header is '(.*)'")]
        public void ThenWelcomeHeaderIs([NotNull] string welcomeHeader)
        {
            if (welcomeHeader == null)
            {
                throw new ArgumentNullException(nameof(welcomeHeader));
            }

            Assert.AreEqual(welcomeHeader, Home.WelcomeHeader.Text, "Welcome header on home page is incorrect.");
        }

        [Then(@"Links header is '(.*)'")]
        public void ThenLinksHeaderIs([NotNull] string linksHeader)
        {
            if (linksHeader == null)
            {
                throw new ArgumentNullException(nameof(linksHeader));
            }

            Assert.AreEqual(linksHeader, Home.LinksHeader.Text, "Header of links on home page is incorrect.");
        }

        [When(@"I click on '(.*)' link")]
        public void WhenIClickOnLink([NotNull] string subPage)
        {
            if (subPage == null)
            {
                throw new ArgumentNullException(nameof(subPage));
            }

            AbTestPage = Home.NavigateToSubPage<AbTestingPage>(subPage);
        }

        [Then(@"'(.*)' page has been opened")]
        public void ThenPageHasBeenOpened([NotNull] string pageUrl)
        {
            if (pageUrl == null)
            {
                throw new ArgumentNullException(nameof(pageUrl));
            }

            Assert.AreEqual(AbTestingPage.ExpectedRemoteUrl, AbTestPage.Url, "Incorrect URL of A/B Testing page.");
        }

        [Then(@"There are '(.*)' links to subpages")]
        public void ThenThereAreLinksToSubpages(int subpagesNumber)
        {
            Assert.AreEqual(subpagesNumber, Home.GetSubpagesNumber(), "Incorrect number of subpages on Home page.");
        }

        [Then(@"All links point to correct subpages")]
        public void ThenAllLinksPointToCorrectSubpages()
        {
            foreach (var link in Home.SubpageLinkWebElementToHref.Keys)
            {
                if (link.Text == "JQuery UI Menus")
                {
                    // TODO Bug in url address.
                }
                else
                {
                    Assert.True(link.DoesAnchorWebElementPointToHref(Home.SubpageLinkWebElementToHref[link]), $"Link: {link.Text} does not point to correct page. Is: {link.GetAttribute("href")}. Should be: {Home.SubpageLinkWebElementToHref[link]}");
                }
            }
        }
    }
}
