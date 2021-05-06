using System.IO;
using System.Reflection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace TheInternetApp.UiTests.Steps
{
    [Binding]
    public class MainSteps
    {
        protected static IWebDriver Driver { get; set; }

        [BeforeFeature]
        public static void RunBeforeFeature()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        }

        [AfterFeature()]
        public static void RunAfterScenario()
        {
            Driver.Close();
            Driver.Dispose();
        }
    }
}