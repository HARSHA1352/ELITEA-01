using TechTalk.SpecFlow;
using OpenQA.Selenium;
using POM.Utils;

namespace ELITEA_01.Hooks
{
    [Binding]
    public class Hooks
    {
        private readonly IWebDriver _driver;

        public Hooks(IWebDriver driver)
        {
            _driver = driver;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            // Add setup steps before each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            // Add teardown steps after each scenario
        }
    }
}