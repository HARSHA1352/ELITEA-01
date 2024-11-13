using POM.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowTests
{
    [Binding]
    public class LoginSteps
    {
        private readonly LoginPage loginPage;
        private string errorMessage;

        public LoginSteps()
        {
            loginPage = new LoginPage(DriverFactory.Driver);
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            loginPage.NavigateToLoginPage("https://www.saucedemo.com");
        }

        [When("I enter the correct username and password")]
        public void WhenIEnterTheCorrectUsernameAndPassword()
        {
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
        }

        [When("I enter incorrect username or password")]
        public void WhenIEnterIncorrectUsernameOrPassword()
        {
            loginPage.EnterUsername("invalid_user");
            loginPage.EnterPassword("invalid_password");
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            Assert.IsTrue(loginPage.IsLoginSuccessful(), "Login was not successful");
        }

        [Then("I should see an error message indicating unsuccessful login")]
        public void ThenIShouldSeeAnErrorMessageIndicatingUnsuccessfulLogin()
        {
            errorMessage = loginPage.GetErrorMessage();
            Assert.AreEqual("Epic sadface: Username and password do not match any user in this service", errorMessage, "Error message is incorrect");
        }

        [Then("I should see a validation message to enter the password")]
        public void ThenIShouldSeeAValidationMessageToEnterThePassword()
        {
            errorMessage = loginPage.GetErrorMessage();
            Assert.AreEqual("Epic sadface: Password is required", errorMessage, "Error message for password validation is incorrect");
        }

        [Then("I should see a validation message to enter the username")]
        public void ThenIShouldSeeAValidationMessageToEnterTheUsername()
        {
            errorMessage = loginPage.GetErrorMessage();
            Assert.AreEqual("Epic sadface: Username is required", errorMessage, "Error message for username validation is incorrect");
        }

        [Then("I should see a validation message to enter both username and password")]
        public void ThenIShouldSeeAValidationMessageToEnterBothUsernameAndPassword()
        {
            errorMessage = loginPage.GetErrorMessage();
            Assert.AreEqual("Epic sadface: Username is required\nEpic sadface: Password is required", errorMessage, "Error message for both username and password validation is incorrect");
        }
    }
}
