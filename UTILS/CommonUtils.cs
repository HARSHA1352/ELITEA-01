using System;
using OpenQA.Selenium;

namespace UTILS
{
    public class CommonUtils
    {
        private IWebDriver _driver;

        public CommonUtils(IWebDriver driver)
        {
            _driver = driver;
        }

        // Add common utility methods that can be reused across the project
    }
}