using OpenQA.Selenium;

namespace POM.Utils
{
    public class DriverHelper
    {
        private IWebDriver _driver;

        public DriverHelper(IWebDriver driver)
        {
            _driver = driver;
        }

        // Add methods for common driver operations like navigating to a URL, maximizing window, etc.
    }
}