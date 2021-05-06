using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TheInternetApp.UiTests.Pages;

namespace TheInternetApp.UiTests.Steps.UAT
{
    [Binding]
    [Scope(Feature = "HomeUat")]
    public class HomeUatSteps : MainSteps
    {
        private HomePage Home { get; set; }

        [BeforeScenario()]
        public void RunBeforeScenario()
        {
            Home = new HomePage(Driver);
        }

        [Given(@"I have opened home page")]
        public void GivenIHaveOpenedHomePage()
        {
            Home.OpenPage();
        }

        [Then(@"Home page is user accepted")]
        public void ThenHomePageIsUserAccepted()
        {
            ITakesScreenshot takesScreenshot = (ITakesScreenshot) Driver;
            Screenshot screenshot = takesScreenshot.GetScreenshot();

            screenshot.SaveAsFile("homePageTop");
            

        }

    }
}
