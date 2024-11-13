using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace Hooks
{
    [Binding]
    public class Hooks
    {
        private IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Code to set up WebDriver instance
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Code to quit WebDriver instance
        }
    }
}