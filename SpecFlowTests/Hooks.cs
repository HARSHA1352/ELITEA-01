using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            DriverFactory.InitializeDriver();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            DriverFactory.CloseDriver();
        }
    }
}
