using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowTests
{
    public static class DriverFactory
    {
        public static IWebDriver Driver { get; private set; }

        public static void InitializeDriver()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }

        public static void CloseDriver()
        {
            Driver.Quit();
        }
    }
}
