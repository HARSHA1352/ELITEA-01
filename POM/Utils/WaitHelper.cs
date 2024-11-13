using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace POM.Utils
{
    public class WaitHelper
    {
        private IWebDriver _driver;
        private WebDriverWait _wait;

        public WaitHelper(IWebDriver driver)
        {
            _driver = driver;
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Add methods for explicit wait operations like waiting for an element to be clickable, visible, etc.
    }
}