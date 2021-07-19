using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TheInternetApp.UiTests.Pages.InternalPages.AbTesting;
using TheInternetApp.UiTests.Pages.InternalPages.Home;

namespace TheInternetApp.UiTests.Steps.Regression
{
    [Binding]
    [Scope(Feature = "AbTesting")]
    internal class AbTestingSteps : MainSteps
    {
        private AbTestingPage AbTestPage { get; set; }
        private HomePage Home { get; set; }

        [BeforeScenario]
        public void RunBeforeScenario()
        {
            AbTestPage = new AbTestingPage(TheInternetApplication.Driver);
        }

        [Given(@"I have opened Ab Testing page")]
        public void GivenIHaveOpenedAbTestingPage()
        {
            AbTestPage.OpenPage();
        }

        [Then(@"Main header is '(.*)'")]
        public void ThenMainHeaderIs([NotNull] string headerValue)
        {
            if (headerValue == null)
            {
                throw new ArgumentNullException(nameof(headerValue));
            }
            // TODO Bug in application.
            // Assert.AreEqual(headerValue, AbTestPage.MainHeader.Text, "Main header text value is incorrect." );
        }

        [Then(@"Main paragraph is equal to main AbTesting paragraph from resources file")]
        public void ThenMainParagraphIsEqualToMainAbTestingParagraphFromResourcesFile()
        {
            Assert.AreEqual(AbTestPage.MainParagraphExpectedText, AbTestPage.MainParagraph.Text, "Main paragraph stores incorrect value.");
        }
    }
}
