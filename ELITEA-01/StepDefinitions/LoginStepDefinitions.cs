using TechTalk.SpecFlow;
using OpenQA.Selenium;
using POM.Pages;
using POM.Utils;

namespace ELITEA_01.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private readonly LoginPage _loginPage;
        private readonly DriverHelper _driverHelper;
        private readonly WaitHelper _waitHelper;
        private readonly IWebDriver _driver;

        public LoginStepDefinitions(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(driver);
            _driverHelper = new DriverHelper(driver);
            _waitHelper = new WaitHelper(driver);
        }

        // Step definitions for the login feature scenarios
    }
}