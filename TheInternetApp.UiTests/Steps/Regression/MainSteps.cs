using TechTalk.SpecFlow;

namespace TheInternetApp.UiTests.Steps.Regression
{
    [Binding]
    internal class MainSteps
    {
        protected static Application TheInternetApplication => new();

        [AfterScenario]
        public void RunAfterScenario()
        {
            TheInternetApplication.CloseApplication();
        }
    }
}
