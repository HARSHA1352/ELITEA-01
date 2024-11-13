using TechTalk.SpecFlow;
using Pages;
using OpenQA.Selenium;

namespace StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private IWebDriver driver;
        private LoginPage loginPage;

        public LoginSteps(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
        }

        [Given("User is on the login page")]
        public void GivenUserIsOnTheLoginPage()
        {
            loginPage.NavigateToLoginPage();
        }

        [When("User enters correct username and password")]
        public void WhenUserEntersCorrectUsernameAndPassword()
        {
            loginPage.EnterUsername("standard_user");
            loginPage.EnterPassword("secret_sauce");
        }

        [When("User enters incorrect username and password")]
        public void WhenUserEntersIncorrectUsernameAndPassword()
        {
            loginPage.EnterUsername("invalid_user");
            loginPage.EnterPassword("invalid_password");
        }

        [When("User enters username but does not enter password")]
        public void WhenUserEntersUsernameButDoesNotEnterPassword()
        {
            loginPage.EnterUsername("standard_user");
        }

        [When("User does not enter username but enters password")]
        public void WhenUserDoesNotEnterUsernameButEntersPassword()
        {
            loginPage.EnterPassword("secret_sauce");
        }

        [When("User does not enter any credentials")]
        public void WhenUserDoesNotEnterAnyCredentials()
        {
            // No action needed as no credentials are entered
        }

        [When("User clicks on the login button")]
        public void WhenUserClicksOnTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("User should be logged in successfully")]
        public void ThenUserShouldBeLoggedInSuccessfully()
        {
            // Add assertion for successful login
        }

        [Then("User should see an error message")]
        public void ThenUserShouldSeeAnErrorMessage()
        {
            // Add assertion for error message
        }

        [Then("User should see a password required message")]
        public void ThenUserShouldSeeAPasswordRequiredMessage()
        {
            // Add assertion for password required message
        }

        [Then("User should see a username required message")]
        public void ThenUserShouldSeeAUsernameRequiredMessage()
        {
            // Add assertion for username required message
        }

        [Then("User should see both username and password required messages")]
        public void ThenUserShouldSeeBothUsernameAndPasswordRequiredMessages()
        {
            // Add assertion for both username and password required messages
        }
    }
}