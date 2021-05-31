using TechTalk.SpecFlow;

namespace TheInternetApp.UiTests.Steps.Regression
{
    [Binding]
    internal class MainSteps
    {
        protected static Application TheInternetApplication => new();
    }
}